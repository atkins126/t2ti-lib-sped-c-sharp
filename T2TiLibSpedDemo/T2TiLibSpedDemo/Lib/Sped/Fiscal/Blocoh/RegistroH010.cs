/*******************************************************************************
Title: T2Ti ERP Fenix
Description: Model relacionado ao SPED Fiscal

The MIT License

Copyright: Copyright (C) 2020 T2Ti.COM

* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
* 
* The author may be contacted at: t2ti.com@gmail.com
*
@author Albert Eije (alberteije@gmail.com)
@version 1.0.0
*******************************************************************************/
namespace T2Ti.Lib.Sped.Fiscal
{
    public class RegistroH010
    {
        public string codItem { get; set; } // Código do item (campo 02 do Registro 0200)
        public string unid { get; set; } // Unidade do item
        public System.Nullable<System.Decimal> qtd { get; set; } // Quantidade do item
        public System.Nullable<System.Decimal> vlUnit { get; set; } // Valor unitário do item
        public System.Nullable<System.Decimal> vlItem { get; set; } // Valor do item
        public string indProp { get; set; } // Indicador de propriedade/posse do item
        public string codPart { get; set; } // Código do participante (campo 02 do Registro 0150)
        public string txtCompl { get; set; } // Descrição complementar
        public string codCta { get; set; } // Código da conta analítica contábil debitada/creditada
    }
}
