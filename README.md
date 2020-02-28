# Teoría patrón MVVM

## View
Es responsable de presentar la aplicación al **USUARIO**. 

Su función es capturar la interacción del usuario y mostrar los resultados.

## Model 
Representa la estructura, los datos y la lógica de los **PROCESOS EMPRESARIALES**.

El modelo incluye las entidades necesarias para *modelar* nuestra aplicación. MVVM también incluqye aquí la **lógica** de persistencia.

```c#
public class Employee
{
    public int Id { get; }
    public string Name { get; set; }
    ...
}
public class EmployeeRepository
{
    public IList<Employee> QueryEmployees() { ... }
    ...
}
```

## ViewModel
Representa la estructura, los datos y la lógica que requiere la **VISTA** 

El ViewModel es el puente entre la vista y el modelo.

1. Expone propiedades a las que se puede enlazar una vista
2. Ideal para propiedades calculadas del modelo requeridas por una vista.
3. El ViewModel proporciona a la vista la estructura y los datos que necesita.
4. El ViewModel está **directamente relacionado con una vista** pero no tiene porque tener una relacción explicita con un modelo. (Puede acceder a varios modelos diferentes para montar los datos requeridos por la vista)
5. Pueden haber ViewModels diferentes basados en la misma clase del modelo. Estos ViewModels se usarán en vistas diferentes.
6. Puede haber un ViewModel que se reutilice en varias vistas. (Si la recuperación de datos para ambas vistas supone una gran sobrecarga entonces mejor separar y tener un ViewModel diferente para cada vista)

### Dependency Properties

Permiten un **enlace bidireccional** para obtener datos de la interfaz de usuario y llevarlos de nuevo a los modelos de vista y viceversa.

### Commands

1. Permiten un control similar a un evento pero **sin estar incluidos en la vista.**. 
2. Conviene controlarlos en el ViewModel para poder hacer pruebas unitarias.
3. Permite mantener una separación clara entre el comportamiento de la interfaz de usuario y su implementación.

ICommand tiene los siguientes métodos:

#### `ICommand.Execute()`
Incluirá el código que pondríamos en un evento normal.

#### `ICommand.CanExecute()`
Para activar o desactivar el commando. Determina si el comando puede ejecutarse en su estado actual.

#### `ICommand.CanExecuteChanged()`
Se produce cuando hay cambios que influyen en si el comando debería ejecutarse o no

```c#
public class EmployeeViewModel : INotifyPropertyChanged
{
    public ICommand GiveBonus {get; private set;}
    public EmployeeViewModel(Employee model)
    {
        GiveBonus = new Command(GiveBonusExecute, GiveBonusCanExecute)
    }

    void GiveBonusExecute()
    {
        //logic for giving bonus
    }

    bool GiveBonusCanExecute()
    {
        //logic for deciding if "give bonus" button should be enabled.
    }

    public event EventHandler CanExecuteChanged;
	public void RaiseCanExecuteChanged()
    {
        if (null != CanExecuteChanged)
        {
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
```