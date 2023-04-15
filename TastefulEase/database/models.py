from django.db import models
from user.models import Customer
# Create your models here.
    
class Category(models.Model):
    name = models.CharField(max_length=50, null=False)

    def __str__(self):
        return self.name

class MenuItem(models.Model):
    name = models.CharField(max_length=50, null=True)
    description = models.TextField(max_length=255, null=True)
    price = models.PositiveIntegerField(null=True)
    image = models.URLField(verbose_name="Menu Item Image")
    categories = models.ManyToManyField(Category)

    def __str__(self):
        return f"{self.name} - {self.price}$"
    
class Order(models.Model):
    customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
    order_date = models.DateTimeField(verbose_name="Order Date")
    coupon = models.ForeignKey("OrderCoupon", on_delete=models.CASCADE, null=True)

    @property
    def total_amount(self):
        orders = OrderItem.objects.filter(order=self)
        total = sum([item.menu_item.price * item.quantity for item in orders])
        return total
    
    def __str__(self):
        return f"{self.customer} - {self.total_amount}$ - {self.order_date}"

class OrderItem(models.Model):
    order = models.ForeignKey(Order, on_delete=models.CASCADE)
    menu_item = models.ForeignKey(MenuItem, on_delete=models.CASCADE)
    quantity = models.IntegerField()

class DeliveryAddress(models.Model):
    customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
    street = models.CharField(max_length=50, null=True)
    city = models.CharField(max_length=50, null=True)
    state = models.CharField(max_length=50, null=True)
    zip_code = models.CharField(max_length=7, null=True)

class Payment(models.Model):
    order = models.ForeignKey(Order, on_delete=models.CASCADE)
    date = models.DateTimeField(verbose_name="Payment Date")
    amount = models.PositiveIntegerField()

class Coupon(models.Model):
    code = models.CharField(max_length=10, null=False)
    discount = models.PositiveIntegerField()

    def __str__(self):
        return f"{self.code} - {self.discount}$"
    
class OrderCoupon(models.Model):
    #order = models.ForeignKey(Order, on_delete=models.CASCADE)
    coupon = models.ForeignKey(Coupon, on_delete=models.CASCADE)
    customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
