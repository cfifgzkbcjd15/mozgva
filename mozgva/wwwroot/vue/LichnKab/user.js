const user={template:`
<div>
    <div v-for="emp in aspnetusers">
Имя:<br\><input v-bind:value="emp.name" disabled>
<br\>
<br\>
E-mail<br\><input v-bind:value="emp.email" disabled>
<br\>
<br\> 
Номер телефона:<br\><input v-bind:value="emp.phoneNumber" disabled>
<br\>
<br\>
<a v-bind:href="'http://localhost:5000/Home/Index/'+emp.id" >Подробнее об игре</a>
<button type="button"
            class="waves-effect waves-light btn"
            data-bs-toggle="modal"
            data-bs-target="#exampleModal"
            @click="editClick(emp)">
                Изменить
            </button>

<div class="modal fade" id="exampleModal" tabindex="-1"
    aria-labelledby="exampleModalLabel" aria-hidden="true">
<div class="modal-dialog modal-lg modal-dialog-centered">
<div class="modal-content">
    <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">{{modalTitle}}</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal"
        aria-label="Close"></button>
    </div>

    <div class="modal-body">
    <div class="d-flex flex-row bd-highlight mb-3">
        <div class="p-2 w-50 bd-highlight">
            <div class="input-group mb-3">
                <span class="input-group-text">Имя</span>
                <input type="text" class="form-control" v-model="Name">
            </div>

        </div>
    </div>
 <div class="d-flex flex-row bd-highlight mb-3">
        <div class="p-2 w-50 bd-highlight">
            <div class="input-group mb-3">
                <span class="input-group-text">E-mail</span>
                <input type="text" class="form-control" v-model="Email">
            </div>

        </div>
    </div>
 <div class="d-flex flex-row bd-highlight mb-3">
        <div class="p-2 w-50 bd-highlight">
            <div class="input-group mb-3">
                <span class="input-group-text">Номер телефона</span>
                <input type="text" class="form-control" v-model="PhoneNumber">
            </div>

        </div>
    </div>
        <button type="button" @click="updateClick()"
        v-if="Email!=null" class="btn btn-primary">
        Update
        </button>

    </div>

</div>
</div>
</div>


</div>


`,

data(){
    return{
        aspnetusers: [],
        modalTitle: "",
        Name: "",
        Id: "",
        PhoneNumber: "",
        Email:"",
        users:[]
        
    }
},
methods:{
    refreshData(){
        axios.get(variables.API_URL +"usersApi")
        .then((response)=>{
            this.aspnetusers=response.data;
        });
    },
    editClick(emp){
        this.modalTitle = "Edit Users";
        this.Name = emp.name;
        this.PhoneNumber = emp.phoneNumber;
        this.Email = emp.email;
    },
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
    updateClick(){
        axios.put(variables.API_URL + "usersApi", {
            Name:this.Name,
            Email: this.Email,
            PhoneNumber: this.PhoneNumber
        })
        .then((response)=>{
            this.refreshData();
            alert("Готово");
        });
    },
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