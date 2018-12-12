using System.Collections.Generic;
using System.Windows.Forms;

namespace FormAssistant
{
   /// <summary>
   /// This class contains helpful methods that assist working with forms.
   /// </summary>
   public static class FormHelper
   {

      /// <summary>
      /// Attempts to find a <seealso cref="Control"/> by its <paramref name="controlName"/> within 
      /// the specified <paramref name="controlContainer"/>.
      /// </summary>
      /// 
      /// <typeparam name="TControl">Type of the <seealso cref="Control"/>.</typeparam>
      /// <typeparam name="TControlContainer">Type of the <paramref name="controlContainer"/>.</typeparam>
      /// <param name="controlName">The name of the <seealso cref="Control"/> that you want to retrieve.</param>
      /// <param name="controlContainer">The <seealso cref="ContainerControl"/> to search.</param>
      /// 
      /// <returns>
      /// <seealso cref="Control"/> if found; otherwise null.
      /// </returns>
      public static TControl FindControlByName<TControl, TControlContainer>(
         string controlName, TControlContainer controlContainer) 
         where TControl : Control
         where TControlContainer : ScrollableControl
      {
         foreach (Control control in controlContainer.Controls)
         {
            if (control.Name == controlName)
               return control as TControl;
         }
         return null;
      }

      /// <summary>
      /// Compiles and returns a <seealso cref="List{TControl}"/> from the specified
      /// <paramref name="controlContainer"/>.
      /// </summary>
      /// 
      /// <typeparam name="TControl">Type of the <seealso cref="Control"/>s to retrieve.</typeparam>
      /// <typeparam name="TControlContainer">Type of the <seealso cref="ScrollableControl"/> to get 
      ///    <typeparamref name="TControl"/>s from.</typeparam>
      /// <param name="controlContainer">The <seealso cref="ScrollableControl"/> to get 
      ///    <typeparamref name="TControl"/>s from.</param>
      ///    
      /// <returns>
      /// <seealso cref="List{TControl}"/> from the specified <paramref name="controlContainer"/>.
      /// </returns>
      public static List<TControl> GetControlsInControlContainer<TControl, TControlContainer>(
         TControlContainer controlContainer) 
         where TControl : Control
         where TControlContainer : ScrollableControl
      {
         List<TControl> controlList = new List<TControl>();
         foreach (Control control in controlContainer.Controls)
         {
            if (control.GetType() == typeof(TControl))
               controlList.Add((TControl)control);
         }
         return controlList;
      }

      /// <summary>
      /// Compiles and returns a <seealso cref="List{Control}"/> of all <seealso cref="Control"/>s 
      /// from the specified <paramref name="controlContainer"/>.
      /// </summary>
      /// 
      /// <typeparam name="TControlContainer">Type of the <seealso cref="ScrollableControl"/> to get
      ///    <seealso cref="Control"/>s from.</typeparam>
      /// <param name="controlContainer">The <seealso cref="ScrollableControl"/> to get
      ///    <seealso cref="Control"/>s from.</param>
      ///    
      /// <returns>
      /// <seealso cref="List{Control}"/> of all <seealso cref="Control"/>s from the 
      /// specified <paramref name="controlContainer"/>.
      /// </returns>
      public static List<Control> GetControlsInControlContainer<TControlContainer>(
         TControlContainer controlContainer)
         where TControlContainer : ScrollableControl
      {
         List<Control> allControlsList = new List<Control>();
         foreach (Control control in controlContainer.Controls)
            allControlsList.Add(control);
         return allControlsList;
      }

   }
}