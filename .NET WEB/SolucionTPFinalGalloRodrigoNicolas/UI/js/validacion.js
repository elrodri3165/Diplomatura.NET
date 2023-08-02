function validar(){
    var nombre = document.getElementById('nombre').value;
    var correo = document.getElementById('correo').value;
    var mensaje = document.getElementById('textarea').value;
    
    var exp = /\w+@\w+\.+[a-z]/;
    
    if (nombre ==="" || correo==="" || mensaje==="" || mensaje==="" || nombre===null || correo===null){
    alert ("Debe completar todos los campos");
    return false;
    }
    
    else if (correo.lenght>50 || correo.lenght<3){
    alert ("El campo correo es muy largo o muy corto, debe tener mas de 3 y menos de 50 letras");
    return false;
    }
        
    else if (!exp.test(correo)){
    alert("El correo no es correcto");
    return false;
    }
}