from django.urls import path, include
from rest_framework import routers
from .api import *

router = routers.DefaultRouter()
router.register('customers', CustomerApi)
router.register('delivery-addresses', DeliveryAddressesApi)
router.register('categories', CategoryApi)
router.register('menu-items', MenuItemApi)
router.register('orders', OrderApi)
router.register('order-items', OrderItemApi)
router.register('Payments', PaymentApi)
router.register("Coupons", CouponApi)

urlpatterns = [
    path('', include(router.urls)),
]