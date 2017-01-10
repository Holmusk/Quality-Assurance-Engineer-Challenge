# Found issues

## User's state during registration

### Crash on registration form

1. Fill all fields on registration form
2. Press Submit button
3. Press Previous button

Result: Crash of application

### Incorrect behavior on Gender view

1. Fill all fields on registration form
2. Press Submit button
3. Select female gender
4. Press Next button
5. Press Previous button

Result: Will be selected male gender

### Lost of user's weight

1. Fill all fields on registration form
2. Press Submit button
3. Select user's gender
4. Press Next button
5. Input user's height
6. Input user's weight
7. Press Next button
8. Press Previous button

Result: user's height will be lost


## Login issue

### Impossible to login using Email

1. Register a new user
2. Logout this user
3. Try to Sign in by this user using their Email as username

Result: No able to login


## Security issues

### Invalid username

1. Fill all fields on registration form
2. In this case username should be incorrect and contains at least one special character

Result: Username field will be marked as incorrect, but user still have a possibility continue registration

### Occupied username

1. Fill all fields on registration form
2. In this case username should be occupied

Result: Username field will be marked as incorrect, but user still have a possibility continue registration

### Occupied Email

1. Fill all fields on registration form
2. In this case Email should be occupied

Result: user have a possibility continue registration
