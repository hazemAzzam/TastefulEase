from database.models import *
from django.http import HttpResponse, JsonResponse
from django.contrib.auth import authenticate
from django.views.decorators.csrf import csrf_exempt
from database.serializers import CustomerSerializer, OrderSerializer, OrderItemsSerializer
import json
from rest_framework.views import APIView

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

#@csrf_exempt
#def login(request):
#    print(request.POST)
#    if request.method == 'POST':
#        phone_number = request.POST["phone_number"]
#        password = request.POST["password"]
#        user = authenticate(request, phone_number=phone_number, password=password)
#        if user:
#            customSerialzier = CustomerSerializer(user)
#
#            return JsonResponse(customSerialzier.data, content_type='application/json')
#
#        else:
#            error = {'error': 'phone_number or password is incorrect!'}
#            return JsonResponse(error, status=401)
#        
#@csrf_exempt 
#def make_order(request):
#    data_customer = request.POST['customer']
#    json_data_customer = json.loads(data_customer)
#
#    data_order_date = request.POST['order_date']
#
#    data_order_items = json.loads(request.POST['order_items'])
#
#    for item in data_order_items:
#        menu_item = MenuItem(**item['menu_item'])
#        print(menu_item)
#
#    customer = Customer.objects.get(id=json_data_customer)
#    order = Order(customer=customer, order_date=data_order_date)
#
#    print(order)
#
#    #order_date = request.POST['order_date']
#    #order_items = request.POST['order_items']
#    #
#    #customer = Customer(id=data.pop('customer'))
#    #order = Order(customer=customer, **data)
#    #
#    #orderSerializer = OrderSerializer(order=order)
#    return JsonResponse(request.POST)
