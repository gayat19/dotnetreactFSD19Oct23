use pubs

select * from authors
--where clause restricts the number of rows
select * from authors where state = 'CA'
--column selection
select au_lname, au_fname from authors