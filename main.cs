protected override void OnCreate(Bundle bundle) {  
    base.OnCreate(bundle);  
    // Set our view from the "main" layout resource  
    SetContentView(Resource.Layout.Main);  
    Button button = FindViewById < Button > (Resource.Id.second);  
    button.Click += delegate {  
    // here load the second form by namespace name
        StartActivity(typeof(second));  
    };  
}  
