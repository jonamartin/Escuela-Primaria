using System;
using Primaria;
using System.Collections.Generic;
class Escuela 
{
    public Escuela () 
    {
        List<Materia> materias = new List<Materia>();
        materias.Add(new Materia("Matemáticas"));
        materias.Add(new Materia("Lengua"));
        materias.Add(new Materia("Musica"));
        materias.Add(new Materia("Educacion Fisica"));
        List<Grado> grados = new List<Grado>();
        for (int i = 1; i<=7; i++)
        {
            grados.Add(new Grado(materias,i));
        }
    }
    
}