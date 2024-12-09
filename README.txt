We need to organized integration from Rabbit
- Main service contains InputIntegrationService, that works with message in specific format
For example


RoutingKey: Author
Message:
<Author>
<FirstName>Alexander</FirstName>
<LastName>Pushkin</LastName>
<DateOfBirth>1799-06-06</DateOfBirth>
</Author>

RoutingKey: Book
Message:
{
	"Name":"Evgeniy Onegin"
}

- We also have 2 separate services that can handle both those messages
- Each of them should not know, how we get those messages (from Rabbit)
- We need to organize work with services, so we could easily add new handlers without significant chaning of main service 