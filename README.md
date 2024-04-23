# Caregiver Website

Caregiver Website is a platform that connects customers with caregivers, babysitters, and nurses for personalized care services.

## Goals

- Develop a user-friendly platform for caregiving connections.
- Streamline searching, browsing profiles, and making reservations.
- Enhance transparency and reliability with administrator approval for requests.
- Provide a reliable network of qualified caregivers and nurses.
- Improve the overall caregiving experience for customers and caregivers.

## Functional Requirements

### Customer (Normal User)

- **Sign Up, Sign In**: Allows customers to create and log into their accounts.
- **View Available Nurses**: Displays a list of available nurses and their details.
- **Reserve a Nurse**: Allows customers to reserve a nurse for their care.
- **Search**: Enables customers to search for specific nurses or services.
- **View and Edit Profile, Delete Account**: Provides options to manage customer profile and account.

### Caregiver/Nurse/Babysitter

- **Fill Form to Sign Up, Sign In**: Enables caregivers, nurses, and babysitters to register and log into their accounts.
- **Receive Notifications for Reservations**: Notifies caregivers and nurses of new service requests.
- **Accept or Decline Service Requests**: Allows caregivers and nurses to manage service requests.
- **View Reservations (Old and New)**: Displays past and current reservations.
- **Edit Profile, Delete Account**: Provides options to manage caregiver/nurse/babysitter profiles and accounts.

### Admin

- **Sign In**: Allows administrators to log into their accounts.
- **Accept or Decline Registrations**: Manages registrations of caregivers, babysitters, and nurses.
- **Manage Caregivers, Babysitters, and Nurses**: Provides tools to manage user data.
- **View User and Transaction Data**: Accesses user and transaction records.
- **Edit Profile**: Allows administrators to modify their profile information.

## System Architecture
![image](https://github.com/Emanakh/Caregiver-Project/assets/104126088/c83e2380-5071-451a-8b4a-1771fec84e0f)

## Database Diagram
![image](https://github.com/Emanakh/Caregiver-Project/assets/104126088/253a5f1d-8816-41e2-8e18-72c06eaf9ed1)

## Technology Stack
Backend:
### Foundational Technologies: C# , ASP.NET Web API

● Backend Implemented a 3-tier architecture featuring distinct layers like Presentation Layer (Controllers), Business
Layer (Repositories), and Data Access Layer.
● Entity Framework Core as a Database using Mapping mechanisms as TPH.
● Implementing design patterns as dependency Injection, generic repository and SOLID principles.
● Ensured security with JWT authentication and Identity for User Management.
● Technology Stack: ASP.NET Core 8, Entity Framework Core, RESTful APIs, MS SQL Server, JWT Authentication,
Angular, Identity, HTML, CSS, Bootstrap, TypeScript.

## Database and Integrations:
1- SQL Server
2- Stripe Payment
3- Twilio (Sending Messages)
4- MailKit (Sending Mails)
