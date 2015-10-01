Syntax Meaning

(expr) Capture matched expression expr into indexed group
(?number) Capture matched substring into a specified group number
(?'name') Capture matched substring into group name
(?'name1-name2') Undefine name2, and store interval and current group into name1; if name2 is undefined,
matching backtracks; name1 is optional
(?:expr) Noncapturing group