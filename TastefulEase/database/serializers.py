from rest_framework.exceptions import ValidationError
from rest_framework import serializers
from .models import *
import json

class DeliveryAddressSerializer(serializers.ModelSerializer):
    class Meta:
        model = DeliveryAddress
        exclude = ['customer']
        
class CustomerSerializer(serializers.ModelSerializer):
    delivery_addresses_info = DeliveryAddressSerializer(read_only=True, many=True)
    delivery_addresses = DeliveryAddressSerializer(write_only=True, many=True)

    class Meta:
        model = Customer
        fields = ['first_name', 'last_name', 'phone_number', 'delivery_addresses', 'delivery_addresses_info']

    def create(self, validated_data):
        delivery_addresses_data = validated_data.pop('delivery_addresses')

        customer = Customer(**validated_data)
        customer, created = Customer.objects.get_or_create(**validated_data)
        if created:
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
        fields = ['id', 'name', 'description', 'price', 'categories_info', 'categories']

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

class OrderSerializer(serializers.ModelSerializer):
    total_amount = serializers.ReadOnlyField()
    class Meta:
        model = Order
        fields = '__all__'

class OrderItemsSerializer(serializers.ModelSerializer):
    class Meta:
        model = OrderItems
        fields = '__all__'
