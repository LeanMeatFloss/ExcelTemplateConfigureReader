# ExcelTemplateConfigureReader

A useful tools for reading Excel Configures to export a Key-Value lists based on EPPLUS and .net core.

## Description

When trying to use excel as configure file input, those scenarios often occurs:

- The key was stored in a row or a column;
- The cell may be merged;
- Each line have a unique id;

## Solution Tips

When trying to read a cell that has been merged, the value upper (direction to the position of key) it will be replaced.
