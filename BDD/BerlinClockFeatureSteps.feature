
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario: Midnight 00:00
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""


Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Just before midnight
When the time is "23:59:59"
Then the clock should look like
"""
O
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight 24:00
When the time is "24:00:00"
Then the clock should look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Just after midnight 00:00:01
When the time is "00:00:01"
Then the clock should look like
"""
O
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Just after midnight 00:00:59
When the time is "00:00:59"
Then the clock should look like
"""
O
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Morning 05:00:00
When the time is "05:00:00"
Then the clock should look like
"""
Y
ROOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Morning 10:00:00
When the time is "10:00:00"
Then the clock should look like
"""
Y
RROO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Afternoon 15:00:00
When the time is "15:00:00"
Then the clock should look like
"""
Y
RRRO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Evening 20:00:00
When the time is "20:00:00"
Then the clock should look like
"""
Y
RRRR
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: After midnight 01:00:00
When the time is "01:00:00"
Then the clock should look like
"""
Y
OOOO
ROOO
OOOOOOOOOOO
OOOO
"""

Scenario: After midnight 02:00:00
When the time is "02:00:00"
Then the clock should look like
"""
Y
OOOO
RROO
OOOOOOOOOOO
OOOO
"""

Scenario: After midnight 03:00:00
When the time is "03:00:00"
Then the clock should look like
"""
Y
OOOO
RRRO
OOOOOOOOOOO
OOOO
"""

Scenario: After midnight 04:00:00
When the time is "04:00:00"
Then the clock should look like
"""
Y
OOOO
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Quarter after midnight
When the time is "00:15:00"
Then the clock should look like
"""
Y
OOOO
OOOO
YYROOOOOOOO
OOOO
"""

Scenario: Half an hour after midnight
When the time is "00:30:00"
Then the clock should look like
"""
Y
OOOO
OOOO
YYRYYROOOOO
OOOO
"""

Scenario: Last quarter of midnight
When the time is "00:45:00"
Then the clock should look like
"""
Y
OOOO
OOOO
YYRYYRYYROO
OOOO
"""

Scenario: One minute after midnight
When the time is "00:01:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
YOOO
"""

Scenario: Two minutes after midnight
When the time is "00:02:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
YYOO
"""

Scenario: Three minutes after midnight
When the time is "00:03:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
YYYO
"""

Scenario: Four minutes after midnight
When the time is "00:04:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
YYYY
"""

Scenario: Morning 07:22:02
When the time is "07:22:02"
Then the clock should look like
"""
Y
ROOO
RROO
YYRYOOOOOOO
YYOO
"""