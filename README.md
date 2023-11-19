# FindArea

SQL Запрос для выбора всех пар

select name_product, name_category
from Product left join Category
    on Product.product_id = Category.product_id;
