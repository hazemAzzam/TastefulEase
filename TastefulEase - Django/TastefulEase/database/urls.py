from django.urls import path, include
from rest_framework import routers
from .api import *

router = routers.DefaultRouter()
router.register('customers', CustomerApi)
router.register('delivery_addresses', DeliveryAddressesApi)
router.register('categories', CategoryApi)
router.register('menu_items', MenuItemApi)
router.register('orders', OrderApi)
router.register('order_items', OrderItemApi)
router.register('make_order', MakeOrderApi)

urlpatterns = [
    path('', include(router.urls)),
]