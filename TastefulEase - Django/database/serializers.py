from rest_framework.exceptions import ValidationError
from rest_framework import serializers
from .models import *
from user.models import Customer
import json
from datetime import datetime

class DeliveryAddressSerializer(serializers.ModelSerializer):
    class Meta:
        model = DeliveryAddress
        exclude = ['customer']
        
class CustomerSerializer(serializers.ModelSerializer):
    delivery_addresses_info = DeliveryAddressSerializer(read_only=True, many=True)
    delivery_addresses = DeliveryAddressSerializer(write_only=True, many=True)
    
    class Meta:
        model = Customer
        fields = ['id', 'first_name', 'password', 'last_name', 'phone_number', 'delivery_addresses', 'delivery_addresses_info']

    def create(self, validated_data):
        print(validated_data)
        delivery_addresses_data = validated_data.pop('delivery_addresses')
        
        customer = Customer.objects.create_user(
            phone_number = validated_data['phone_number'],
            password = validated_data['password'],
            first_name = validated_data['first_name'],
            last_name = validated_data['last_name']
        )

        delivery_addresses = [DeliveryAddress(customer=customer, **address) for address in delivery_addresses_data]
        for delivert_address in delivery_addresses:
            delivert_address.save()

        return customer
    
    def update(self, instance, validated_data):
        delivery_addresses_data = validated_data.pop('delivery_addresses')
        customer = Customer.objects.get(id=instance.id)
        DeliveryAddress.objects.filter(customer=customer).delete()

        new_delivery_addresses = [DeliveryAddress(customer=customer, **address) for address in delivery_addresses_data]
        DeliveryAddress.objects.bulk_create(new_delivery_addresses)

        customer.first_name = validated_data['first_name']
        customer.last_name = validated_data['last_name']
        customer.phone_number = validated_data['phone_number']
        customer.save()
        
        return instance
    
    def to_representation(self, instance):
        representation = super().to_representation(instance)
        delivery_addresses = DeliveryAddress.objects.filter(customer=instance)
        delivery_addresses_serializer = DeliveryAddressSerializer(delivery_addresses, many=True)
        representation['delivery_addresses_info'] = delivery_addresses_serializer.data
        return representation

        
class CategorySerializer(serializers.ModelSerializer):
    class Meta:
        model = Category
        fields = '__all__'
        
class MenuItemSerializer(serializers.ModelSerializer):
    categories_info = CategorySerializer(source="categories", many=True, read_only=True)
    categories = CategorySerializer(
        many=True,
        write_only=True,
    )
    
    class Meta:
        model = MenuItem
        fields = ['id', 'name', 'description', 'price', 'image', 'categories_info', 'categories']

    def create(self, validated_data):
        categories_data = validated_data.pop('categories', [])
        categories = []

        for category_data in categories_data:
            category, created = Category.objects.get_or_create(name=category_data['name'])
            categories.append(category)

        menu_item, created = MenuItem.objects.get_or_create(**validated_data)
        if created:
            menu_item.categories.set(categories)
        
        return menu_item

class OrderItemsSerializer(serializers.ModelSerializer):
    order = serializers.PrimaryKeyRelatedField(queryset=Order.objects.all(), required=False, write_only=True)
    class Meta:
        model = OrderItem
        fields = ['id', 'menu_item', 'quantity', 'order']

class OrderSerializer(serializers.ModelSerializer):
    order_items_info = OrderItemsSerializer(source='order_items', many=True, read_only=True)
    order_items = OrderItemsSerializer(many=True, write_only=True, required=False)

    total_amount = serializers.ReadOnlyField()
    number_of_items = serializers.ReadOnlyField()

    class Meta:
        model = Order
        fields = '__all__'

    def create(self, validated_data):
        order_items_info = validated_data.pop('order_items')
        print(order_items_info)
        order = Order.objects.create(**validated_data)
        order.status = "Not Paied"
        order_items = [OrderItem(order=order, **item) for item in order_items_info]
        print(order_items)
        OrderItem.objects.bulk_create(order_items)
        order.customer.last_order = datetime.now

        return order
    
    def to_representation(self, instance):
        representation=super().to_representation(instance)
        order_items = OrderItem.objects.filter(order=instance)
        order_items_serializer = OrderItemsSerializer(order_items, many=True)
        representation["order_items"] = order_items_serializer.data
        return representation


class MakeOrderSerializer(serializers.ModelSerializer):
    order_items_info = OrderItemsSerializer(source='order_items', many=True, read_only=True)
    order_items = OrderItemsSerializer(many=True, write_only=True)
    
    class Meta:
        model = Order
        fields = ['customer', 'order_date', 'coupon', 'order_items', 'order_items_info']

    def create(self, validated_data):
        order_items_info = validated_data.pop('order_items')
        print(order_items_info)
        order = Order.objects.create(**validated_data)

        order_items = [OrderItem(order=order, **item) for item in order_items_info]
        print(order_items)
        OrderItem.objects.bulk_create(order_items)

        return order
    
    def to_representation(self, instance):
        representation=super().to_representation(instance)
        order_items = OrderItem.objects.filter(order=instance)
        order_items_serializer = OrderItemsSerializer(order_items, many=True)
        representation["order_items"] = order_items_serializer.data
        return representation
    

class PaymentSerializer(serializers.ModelSerializer):
    class Meta:
        model = Payment
        fields = '__all__'

    def create(self, validated_data):
        order = validated_data["order"]
        order.status="Paied"
        order.save()
        #order = Order.objects.get(order=validated_data["order"])
        #order.status = "Paied"
        #order.save()
        return super().create(validated_data)