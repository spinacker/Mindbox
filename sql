select p.Name, c.Name  from product p 
left outer join productcategory p2 on p.id =p2.productid 
left outer join category c on p2.categoryid = c.Id 
