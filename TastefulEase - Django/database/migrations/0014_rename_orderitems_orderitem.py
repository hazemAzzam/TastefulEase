# Generated by Django 4.1.6 on 2023-04-15 09:54

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('database', '0013_menuitem_image'),
    ]

    operations = [
        migrations.RenameModel(
            old_name='OrderItems',
            new_name='OrderItem',
        ),
    ]