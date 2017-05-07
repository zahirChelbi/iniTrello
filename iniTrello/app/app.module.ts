import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';



@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,

    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        RouterModule.forRoot([
            { path: 'home', component: HomeComponent/*, canActivate: [AuthGuard]*/ },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [],
})
export class AppModule { }

