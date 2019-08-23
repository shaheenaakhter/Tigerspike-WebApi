Angular App:
==========
Following npm packages installed

install angular google maps 
npm install @types/googlemaps --save-dev
npm install @agm/core --save

install bootstrap for bootstrap and jquery
npm install bootstrap@4
npm install jquery --save

install toastr service for notifications messages
npm install ngx-toastr --save  

Restful Api:
============
install AutoMapper nuget package

Issues Encountered
==================
1.Error 'Unable to load favicon.icon' encountered using while running application with Angular version 8 .0 and ASP.Net Core 2.2 ,
Have used Angular 7.0 and used Angular Cli for compliation for command prompt and ng serve to fix the issue rather than using VS 2017 to run and debug the App.
2.Google Maps Api zoom issue in zone.js file,fix the issue defining the zoom property and assigning value in component.
3.Changing favicon.ico to different image types like jpg/png and add the ref in the link in index.html page with href=# or href ='' to get rid of favicon.ico issue.
4.Working with observables for Search function ,as the code do not hit during the debug,have to used debouncetime() function to wait for the keying input in the input control and also distinctUntilChanged() to emit search term only when previous search is different from new search.
5.Setting Asp.Net Identity and other business tables within same DBContext took bit longer than expected ,as creating the table with code first migration was
wasn't creating table in the Database,have to create and update migrations few times :).
6.Adding new user with Asp.Net identity was erroring out,since the column 'Descriminator' deleted in ASP.Net Core 2.2,have to modify the table columns locally
7.Setting JWT token required bit of reading ,googling and experimenting with ASP.Net core :).

Constraint:
==========
Apologises the Application is developed only for desktop not the mobile due to time constraints and ill health.