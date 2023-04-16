from django.db import models
from user.models import Customer
from datetime import datetime
    
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
    coupon = models.ForeignKey("Coupon", on_delete=models.CASCADE, null=True)
    status = models.CharField(max_length=10, default="Not Paied", null=True, blank=True)

    @property
    def total_amount(self):
        orders = OrderItem.objects.filter(order=self)
        total = sum([item.menu_item.price * item.quantity for item in orders])
        return total
    
    @property
    def total_amount_after(self):
        total = self.total_amount
        if self.coupon:
            coupon = Coupon.objects.get(code=self.coupon.code)
            discount = coupon.discount
            total = total - total * discount
        return total

    @property
    def number_of_items(self):
        orders = OrderItem.objects.filter(order=self)
        noitems = sum([item.quantity for item in orders])
        return noitems
    
    @property
    def discount(self):
        if self.coupon:
            couponObj = Coupon.objects.get(code=self.coupon.code)
            return couponObj.discount
        else:
            return 0
    
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
    date = models.DateTimeField(default=datetime.now(),verbose_name="Payment Date")

    def delete(self, *args, **kwargs):
        order = self.order
        order.status = "Not Paied"
        order.save()
        super().delete(*args, **kwargs)

class Coupon(models.Model):
    code = models.CharField(max_length=10, unique=True, primary_key=True)
    discount = models.DecimalField(max_digits=3, decimal_places=1)

    def __str__(self):
        return f"{self.code} - {self.discount * 100}%"

