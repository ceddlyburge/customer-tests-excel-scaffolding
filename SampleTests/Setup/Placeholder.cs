namespace SampleTests.Setup
{
    // This folder / namespace contains all the generated specification specific setup files

    // Files are generated unless there is already a '<ClassName>Override.cs' file in the
    // Setup folder. This allows you to override the generated files if you 
    // want to.

    // A file is generated for each root obect being tested. Only the setup parts of the
    // class is generated, but the classes are `partial`, so you can add the rest of the 
    // implementation in the Setup folder.
    // An example of this is:
    // https://github.com/resgroup/customer-tests-excel/blob/master/SampleTests/Setup/Calculator.cs

    // The `/assembliesUnderTest` specified on the command line are searched to find matching
    // interfaces, and suitable files generated for them. 
    // An example of this is:
    // https://github.com/resgroup/customer-tests-excel/blob/master/SampleTests/Setup/Cargo.cs
    // If there is no matching interface then a dummy file is created. This will compile, but 
    // won't set anything up in your code. These files can be useful for showing how things 
    // work, and sometimes you might just use them, and map values from them in to your 
    // system under test manually in the root object files. 
    // An example of this is:
    // https://github.com/resgroup/customer-tests-excel/blob/master/SampleTests/Setup/A_Table.cs
}