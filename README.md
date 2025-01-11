# RabbitMQ Messaging System
This project demonstrates how to send messages from a Producer to one or multiple Consumers using RabbitMQ.


# How start
## Run RabbitMQ using Docker
Search for the Docker image rabbitmq:4.0-management and run it.

## Start RabbitMQ in Docker
Execute the following command in your project root directory to start RabbitMQ:

```docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:4.0-management```

## Start the Producer
Navigate to the Producer folder in your terminal and run the Producer with ```dotnet run```.
Enter the routing key (this will be used to send messages). For example:

```Routing Key: fruits```

## Start the Consumer
Navigate to the Consumer folder in your terminal and run the Consumer with ```dotnet run```.
Enter the same routing key to listen for messages from the Producer. For example:

```Routing Key: fruits```

## Verify the Setup
If everything is set up correctly, you should see the following message in the terminal:

```Press [enter] to exit.```

## Send Messages
Start typing and sending messages from the Producer terminal. The Consumer(s) will receive these messages.

## Multiple Consumers
You can create multiple Consumers listening to the same routing key. RabbitMQ will use the Round-Robin algorithm to distribute messages evenly among them.

Enjoy experimenting with RabbitMQ! 🎉







