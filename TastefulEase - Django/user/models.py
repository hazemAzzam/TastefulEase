from django.contrib.auth.models import AbstractUser, AbstractBaseUser
from django.contrib.auth.base_user import BaseUserManager

from django.db import models

class CustomerManager(BaseUserManager):
    def create_user(self, phone_number, password=None, **extra_fields):
        user = self.model(phone_number=phone_number, **extra_fields)
        user.set_password(password)
        user.save(using=self._db)
        return user
    
    def create_superuser(self, phone_number, password=None, **extra_fields):
        extra_fields.setdefault('is_staff', True)
        extra_fields.setdefault('is_superuser', True)

        return self.create_user(phone_number, password, **extra_fields)


class Customer(AbstractUser):
    first_name = models.CharField(max_length=50, null=False)
    last_name = models.CharField(max_length=50, null=False)
    phone_number = models.CharField(max_length=11, null=False, unique=True)

    USERNAME_FIELD = 'phone_number'

    REQUIRED_FIELDS = []
    objects = CustomerManager()

    def __str__(self):
        return f"{self.first_name} {self.last_name}"