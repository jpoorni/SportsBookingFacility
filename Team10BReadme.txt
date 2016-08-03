Module Information

1. Customer & Facilty Maintenance done using Entity Frame Work 
2. Booking done as 3 layer Architecture - (MVC) without Entity frame work. We have used 3 entity classes, 
   1 controller, 4 brokers
3. Validation 
	Customer & Facility
	a) Made sure all the required fields are entered before saving
	b) Use case validation - Only 18 years and above can be a registered as a member
	c) Special characters are not allowed in names
	d) only numeric text is allowed in phone numbers, postal code
	e) Maximum characters allowed for a field are checked
	f) Double click on one row of the grid view allows user to see the full details and edit if necessary
	g) Short cuts can be used (alt + A, alt+P etc.,) for the buttons for easy navigation

	Booking
	a) Business Rule - Only one slot booking is allowed. To make another booking user has 
	   to search the available slots and perform the booking task.
	b) Search criteria - search by customer name , facility booked and Booked Date
	c) Only the customers who are registered can book the sports facility
	d) Tool Strip is used to show the progress of the process to the user in the new booking screen & 
	   have a avoided using message box in this screen
	e) Short cuts can be used (alt + A, alt+P etc.,) for the buttons for easy navigation
	
	Reports
	a) Used Crystal reports for report generation
	b) Few reports are using views to generate report
	c) 4 Reports are generated demonstration pie chart,bar chart 


Thanks And Regards
Team 10B
	