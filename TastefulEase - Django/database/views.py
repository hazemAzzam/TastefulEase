from rest_framework import viewsets
from .serializers import *
from .models import *
from django.db.models import Case, CharField, Count, Value, When
from .filters import *
from rest_framework.views import APIView
from django.contrib.auth import authenticate
from django.http import JsonResponse

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
    filterset_class = Menu_Item_Filter

class OrderApi(viewsets.ModelViewSet):
    queryset = Order.objects.all().order_by("status")
    serializer_class = OrderSerializer

class OrderItemApi(viewsets.ModelViewSet):
    queryset = OrderItem.objects.all()
    serializer_class = OrderItemsSerializer

#class MakeOrderApi(viewsets.ModelViewSet):
#    queryset = Order.objects.all()
#    serializer_class = MakeOrderSerializer

class PaymentApi(viewsets.ModelViewSet):
    queryset = Payment.objects.all()
    serializer_class = PaymentSerializer

class CouponApi(viewsets.ModelViewSet):
    queryset = Coupon.objects.all()
    serializer_class = CouponSerializer


class Login(APIView):
    def post(self, request):
        if request.method == 'POST':
            phone_number = request.data["phone_number"]
            password = request.data["password"]
            user = authenticate(request, phone_number=phone_number, password=password)
            if user:
                customSerialzier = CustomerSerializer(user)

                return JsonResponse(customSerialzier.data, content_type='application/json')

            else:
                error = {'error': 'phone_number or password is incorrect!'}
                return JsonResponse(error, status=401)