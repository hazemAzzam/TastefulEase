# Generated by Django 4.1.6 on 2023-04-12 21:02

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('database', '0008_alter_category_name'),
    ]

    operations = [
        migrations.AlterField(
            model_name='menuitem',
            name='name',
            field=models.CharField(max_length=50, null=True),
        ),
    ]