select p.name as ProductName, c.name as CategoryName 
from Products as p 
left join CategoryProduct as cp on p.id=cp.product_id 
left join Categories as c on c.id=cp.category_id;