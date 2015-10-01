// Zero Width Assertions

Expression Meaning
^ 	Start of string (or line in multiline mode)
$ 	End of string (or line in multiline mode)
\A 	Start of string (ignores multiline mode)
\z 	End of string (ignores multiline mode)
\Z 	End of line or string
\G 	Where search started
\b 	On a word boundary
\B 	Not on a word boundary
(?=expr) Continue matching only if expression expr matches on right (positive lookahead)
(?!expr) Continue matching only if expression expr doesn’t match on right (negative lookahead)
(?<=expr) Continue matching only if expression expr matches on left (positive lookbehind)
(?<!expr) Continue matching only if expression expr doesn’t match on left (negative lookbehind)

(?>expr) Subexpression expr is matched once and not backtracked