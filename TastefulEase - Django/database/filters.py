import django_filters
from .models import MenuItem

class Menu_Item_Filter(django_filters.FilterSet):
    categories=django_filters.CharFilter(field_name='categories__name', lookup_expr='iexact')
    class Meta:
        model=MenuItem
        fields = ['categories']