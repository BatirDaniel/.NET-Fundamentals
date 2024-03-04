namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// Nullable<T> :
    ///    - It can have a value
    ///    - It can be null
    /// </summary>
    public class NullableValueTypes
    {
        public void CheckNullable()
        {
            var txtRate = new Nullable<int>();

            var checkIfHasValue = txtRate.HasValue;
            int defaultVal = txtRate.GetValueOrDefault();

            // returns checkIfHasValue => false and defaultVal => 0

            txtRate = 5;

            checkIfHasValue = txtRate.HasValue;
            defaultVal = txtRate.GetValueOrDefault();

            //returns checkIfHasValue => true and defaultVal => 5
        }
    }
}
