# Generated by Django 4.1.6 on 2023-04-20 10:47

import datetime
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('database', '0002_alter_payment_date_delete_ordercoupon'),
    ]

    operations = [
        migrations.AlterField(
            model_name='payment',
            name='date',
            field=models.DateTimeField(default=datetime.datetime(2023, 4, 20, 12, 47, 42, 921377), verbose_name='Payment Date'),
        ),
    ]