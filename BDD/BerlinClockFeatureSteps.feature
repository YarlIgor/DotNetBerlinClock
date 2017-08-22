
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario Outline: Top Yellow Lamp Blinks Every 2 seconds
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time |
| "00:00:00" | "Y OOOO OOOO OOOOOOOOOOO OOOO"|
| "00:00:01" | "O OOOO OOOO OOOOOOOOOOO OOOO"|
| "00:00:59" | "O OOOO OOOO OOOOOOOOOOO OOOO"|

Scenario Outline: Top Row Hours Lamp Lights Red Every 5 Hours
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time |
| "05:00:00" | "Y ROOO OOOO OOOOOOOOOOO OOOO"|
| "10:00:00" | "Y RROO OOOO OOOOOOOOOOO OOOO"|
| "15:00:00" | "Y RRRO OOOO OOOOOOOOOOO OOOO"|
| "20:00:00" | "Y RRRR OOOO OOOOOOOOOOO OOOO"|

Scenario Outline: Botom Row Hours Lamp Lights Red Every Hour
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time |
| "01:00:00" | "Y OOOO ROOO OOOOOOOOOOO OOOO"|
| "02:00:00" | "Y OOOO RROO OOOOOOOOOOO OOOO"|
| "03:00:00" | "Y OOOO RRRO OOOOOOOOOOO OOOO"|
| "04:00:00" | "Y OOOO RRRR OOOOOOOOOOO OOOO"|

Scenario Outline: Top Row Minutes Lamp Lights Red Every First Quarter, Half And Last Quarter Of An Hour
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time |
| "00:15:00" | "Y OOOO OOOO YYROOOOOOOO OOOO"|
| "00:30:00" | "Y OOOO OOOO YYRYYROOOOO OOOO"|
| "00:45:00" | "Y OOOO OOOO YYRYYRYYROO OOOO"|

Scenario Outline: Bottom Row Minutes Lamp Lights Yellow Every Minute
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time |
| "00:01:00" | "Y OOOO OOOO OOOOOOOOOOO YOOO"|
| "00:02:00" | "Y OOOO OOOO OOOOOOOOOOO YYOO"|
| "00:03:00" | "Y OOOO OOOO OOOOOOOOOOO YYYO"|
| "00:04:00" | "Y OOOO OOOO OOOOOOOOOOO YYYY"|

Scenario Outline: Correct are light up
When the time is <time>
Then the clock should look like <converted_time>

Examples: 
| time       | converted_time                 |
| "07:22:02" | "Y ROOO RROO YYRYOOOOOOO YYOO" |
| "13:17:01" | "O RROO RRRO YYROOOOOOOO YYOO" |
| "23:59:59" | "O RRRR RRRO YYRYYRYYRYY YYYY" |
| "24:00:00" | "Y RRRR RRRR OOOOOOOOOOO OOOO" |


Scenario Outline: Incorrect time format
When the time is <time>
Then the user should see an error message "BerlinClock input time could be 24:00:00 or HH:mm:ss. Please specify time in the correct format."

Examples: 
| time       |
| "1:00:00"  |
| "01:2:00"  |
| "01:02:3"  |
| "1:2:3"    |
| "24:00:01" |
| "24:34:56" |
| "24:59:59" |