// Signature file for parser generated by fsyacc
module FSharp.PowerPack.FsLex.Parser
type token = 
  | EOF
  | BAR
  | DOT
  | PLUS
  | STAR
  | QMARK
  | EQUALS
  | UNDERSCORE
  | LBRACK
  | RBRACK
  | HAT
  | DASH
  | RULE
  | PARSE
  | LET
  | AND
  | LPAREN
  | RPAREN
  | UNICODE_CATEGORY of (string)
  | CHAR of (char)
  | CODE of (AST.Code)
  | STRING of (string)
  | IDENT of (string)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_BAR
    | TOKEN_DOT
    | TOKEN_PLUS
    | TOKEN_STAR
    | TOKEN_QMARK
    | TOKEN_EQUALS
    | TOKEN_UNDERSCORE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_HAT
    | TOKEN_DASH
    | TOKEN_RULE
    | TOKEN_PARSE
    | TOKEN_LET
    | TOKEN_AND
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_UNICODE_CATEGORY
    | TOKEN_CHAR
    | TOKEN_CODE
    | TOKEN_STRING
    | TOKEN_IDENT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startspec
    | NONTERM_spec
    | NONTERM_codeopt
    | NONTERM_Macros
    | NONTERM_macro
    | NONTERM_Rules
    | NONTERM_rule
    | NONTERM_args
    | NONTERM_optbar
    | NONTERM_clauses
    | NONTERM_clause
    | NONTERM_regexp
    | NONTERM_charset
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val spec : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (AST.Spec) 
