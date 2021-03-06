import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { FooterComponent } from './footer/footer.component';
import { DetailsComponent } from './details/details.component';
import { SearchComponent } from './search/search.component';
import { PostNewAdComponent } from './post-new-ad/post-new-ad.component';
import { ErrorComponent } from './error/error.component';
import { CategoryPipe } from './category.pipe';
import { SuccessComponent } from './success/success.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FooterComponent,
    DetailsComponent,
    SearchComponent,
    PostNewAdComponent,
    ErrorComponent,
    CategoryPipe,
    SuccessComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'details/:id', component: DetailsComponent },
      { path: 'search/:word/:catid/:subcatid/:city', component: SearchComponent },
      { path: 'search/:catid/:subcatid', component: SearchComponent },
      { path: 'search/:catid', component: SearchComponent },
      { path: 'search', component: SearchComponent },
      { path: 'success/:id', component: SuccessComponent },
      { path: 'post-new-ad', component: PostNewAdComponent },
      { path: '**', component: ErrorComponent }
    ], {scrollPositionRestoration: 'enabled'})
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
