
/* Показать среднее количество товаров по каждому типу товара.", 
$"select * {fromProducts} WHERE Count = ( select  AVG(Count)  {fromProducts} )")


select * from Products WHERE Count = ( select  AVG(Count)  from Products )
*/
select Distinct Type,AVG(Count)  from Products GROUP BY Type;

select* from Products