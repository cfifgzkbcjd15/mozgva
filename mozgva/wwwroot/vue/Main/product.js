const product= {
    template:`
<div class="counter">
<div v-for="emp in products" style="background:red;margin-top:25px;">
<img v-bind:src="'/Mozgva_Game_Card_Imgs/'+emp.cardImageFileName" />
<p> {{ emp.name }}</p>
<p> {{ emp.description }}</p>
<p>{{emp.Category}}</p>
<p>{{emp.pric}}</p>
<a v-bind:href="'http://localhost:17251/Home/Index/'" >Играть</a>
</br ></br ></br >
</div>
</div>
`,
//< p > {{ emp.name }}</p >
//<p>{{emp.Category}}</p>
//<p>{{emp.price}}</p>
//<a v-bind:href="'http://localhost:17251/Home/Index/'" >Подробнее об игре</a>
//</br ></br ></br >
data(){
    return{
        products: [],
        modalTitle: "",
        Name: "",
        Price: "",
        Category: "",
        Description: "",
        CardImageFileName:""
        
    }
},
methods:{
    refreshData(){
        axios.get(variables.API_URL +"productsApi")
        .then((response)=>{
            this.products=response.data;
        });
    },
    //editClick(emp){
    //    this.modalTitle = "Изменить данные";
    //    this.Name = emp.name;
    //    this.PhoneNumber = emp.phoneNumber;
    //    this.Email = emp.email;
    //},
    //createClick(){
    //    axios.post(variables.API_URL +"scheduleApi",{
    //        EmployeeName:this.EmployeeName,
    //        Department:this.Department,
    //        DateOfJoining:this.DateOfJoining,
    //        PhotoFileName:this.PhotoFileName
    //    })
    //    .then((response)=>{
    //        this.refreshData();
    //        alert(response.data);
    //    });
    //},
    //updateClick(){
    //    axios.put(variables.API_URL + "usersApi", {
    //        Name:this.Name,
    //        Email: this.Email,
    //        PhoneNumber: this.PhoneNumber
    //    })
    //    .then((response)=>{
    //        this.refreshData();
    //        alert("Готово");
    //    });
    //},
    //deleteClick(id){
    //    if(!confirm("Are you sure?")){
    //        return;
    //    }
    //    axios.delete(variables.API_URL +"scheduleApi/"+id)
    //    .then((response)=>{
    //        this.refreshData();
    //        alert(response.data);
    //    });

    //}

},
mounted:function(){
    this.refreshData();
}

}