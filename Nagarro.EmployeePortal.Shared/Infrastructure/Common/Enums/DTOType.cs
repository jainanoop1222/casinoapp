namespace Casino.CustomarModel.Shared
{
    /// <summary>
    /// Data Transfer Objects
    /// </summary>
    public enum DTOType
    {

        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,


        [QualifiedTypeName("Casino.CustomarModel.DTOModel.dll", "Casino.CustomarModel.DTOModel.UserDTO")]
        UserDTO = 1

    }
}
