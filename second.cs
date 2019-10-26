protected override void OnCreate(Bundle savedInstanceState) {  
    base.OnCreate(savedInstanceState);  
    SetContentView(Resource.Layout.Second);  
    Button button = FindViewById < Button > (Resource.Id.First);  
    button.Click += delegate { 
    //this navigate to the main page again
        StartActivity(typeof(MainActivity));  
    };  
   
}  
