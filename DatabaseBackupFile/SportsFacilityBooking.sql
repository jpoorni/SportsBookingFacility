PRINT ('hello')


select * from BookingTran
select * from Slots
select * from Facilities
select * from Customers


CREATE VIEW TrendByFacility AS
select f.Name, sum(a.BookingCount) as BookingCount
from (
	select b.FacilityId, count(b.BookingId) as BookingCount from BookingTran b  group by b.FacilityId
) a,  Facilities f
where
	a.FacilityId=f.FacilityId
	group by f.Name  

select * from TrendByFacility

select FacilityId, count(FacilityId) from BookingTran group by FacilityId

select IssueDate, count(BookingId) as BookingCount from BookingTran group by IssueDate order by IssueDate desc
select datename(dw,IssueDate) as WeekDay, count(BookingId) as BookingCount from BookingTran group by IssueDate 

select datename(dw,IssueDate) as WeekDay, count(BookingId) as BookingCount from BookingTran group by IssueDate 
--select cast(IssueDate as IssueDate1) from BookingTran

-- -- View for weekday trend
select * from BookingTrendOnWeekDays where 

create view BookingTrendOnWeekDays AS
(

	select ab.* from 
		(
			select datename(dw,a.IssueDate) as WeekDay, count(a.BookingId) BookingCount from 
			(
				select  cast(IssueDate as date) as IssueDate,  BookingId from BookingTran
			) a group by datename(dw,a.IssueDate) 
			
		) ab
)



Create view CrossTabFacilityWeekDay as
select a.WeekDay, sum(a.BookingCount) as BookingCount,f.name as facilityName from
(
	select datename(dw,IssueDate) as WeekDay, count(BookingId) as BookingCount, FacilityId from BookingTran group by IssueDate,FacilityId 
) a, Facilities F
where a.facilityId=f.facilityId 
group by a.WeekDay,f.Name

select * from CrossTabFacilityWeekDay


select * from BookingTrendOnWeekDays


select IssueDate, count(BookingId) as BookingCount,FacilityId from BookingTran group by IssueDate,FacilityId order by IssueDate desc
select datename(dw,IssueDate) as WeekDay, count(BookingId) as BookingCount,FacilityId from BookingTran group by IssueDate,FacilityId order by IssueDate desc


--select datename(dw,IssueDate) from BookingTran

select IssueDate, FacilityId, count(FacilityId) from BookingTran group by IssueDate, FacilityId order by IssueDate desc


select count(*) from BookingTran where FacilityId=2000

insert into BookingTran values ( 2000, 11, 2,GETUTCDATE()+2, 1);
insert into BookingTran values ( 3000, 02, 4, GETUTCDATE()+2, 0);
insert into BookingTran values ( 3000, 03, 4, GETUTCDATE()+2, 0);
insert into BookingTran values ( 1000, 04, 4, GETUTCDATE()+2, 0);
insert into BookingTran values ( 1000, 10, 4, GETUTCDATE()+2, 0);
insert into BookingTran values ( 1000, 11, 4, GETUTCDATE()+2, 0);
insert into BookingTran values ( 2000, 12, 4, GETUTCDATE(), 0);
insert into BookingTran values ( 5000, 13, 4, GETUTCDATE(), 0);
insert into BookingTran values ( 5000, 11, 4, GETUTCDATE(), 0);
insert into BookingTran values ( 5000, 12, 4, GETUTCDATE(), 0);
insert into BookingTran values ( 4000, 13, 4, GETUTCDATE(), 0);
insert into BookingTran values ( 4000, 11, 4, GETUTCDATE(), 0);


update BookingTran
set IssueDate='2015-10-19'
where BookingId>34

commit;

select * from BookingTrendOnWeekDays
ORDER BY
   CASE WHEN weekday='Monday' THEN 1
		WHEN weekday='Tuesday' THEN 2
		WHEN weekday='Wednesday' THEN 3
		WHEN weekday='Thursday' THEN 4
		WHEN weekday='Friday' THEN 5
		WHEN weekday='Saturday' THEN 6
		WHEN weekday='Sunday' THEN 7
	END