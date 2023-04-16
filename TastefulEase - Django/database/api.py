from rest_framework import viewsets
from .serializers import *
from .models import *
from django.db.models import Case, CharField, Count, Value, When

class CustomerApi(viewsets.ModelViewSet):
    queryset = Customer.objects.all()
    serializer_class = CustomerSerializer

class DeliveryAddressesApi(viewsets.ModelViewSet):
    queryset = DeliveryAddress.objects.all()
    serializer_class = DeliveryAddressSerializer

class CategoryApi(viewsets.ModelViewSet):
    queryset = Category.objects.all()
    serializer_class = CategorySerializer

class MenuItemApi(viewsets.ModelViewSet):
    queryset = MenuItem.objects.all()
    serializer_class = MenuItemSerializer

class OrderApi(viewsets.ModelViewSet):
    queryset = Order.objects.all().order_by("status")
    serializer_class = OrderSerializer

class OrderItemApi(viewsets.ModelViewSet):
    queryset = OrderItem.objects.all()
    serializer_class = OrderItemsSerializer

class MakeOrderApi(viewsets.ModelViewSet):
    queryset = Order.objects.all()
    serializer_class = MakeOrderSerializer

class PaymentApi(viewsets.ModelViewSet):
    queryset = Payment.objects.all()
    serializer_class = PaymentSerializer