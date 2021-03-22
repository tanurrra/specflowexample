using OpenQA.Selenium;

namespace specflowselenium.PageObjects
{
    /** 
     * Func1, Func3 - helper functions to convert interpolated string with variable into normal string.
     * This enables Page Objects to take arguments.
     **/
    public delegate By Func<A>(A a);
    public delegate By Func<A, B, C>(A a, B b, C c);

}