import React, {useState, useEffect} from 'react'

const App=()=>
{
  const [usuarios, setUsuarios]=useState([]);

  useEffect(()=>{
    const fetchData = async ()=>{
      try{
        const response = await fetch('https://localhost:7135/api/Usuarios');
        const data=await response.json();
        setUsuarios(data);
      }
      catch(error){
        console.error('Error al obtener los usuarios', error);
      }
    };
    fetchData();
  },[]);
  return (
    <div>
      <h2>Lista de Usuarios</h2>
      <ul>
        {usuarios.map((usuario)=>(
          <li key={usuario.id}>{usuario.alias}</li>
        ))}
      </ul>
    </div>

  );
};

export default App;
