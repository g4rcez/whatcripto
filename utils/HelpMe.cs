namespace whatcripto.utils
{
    public abstract class HelpMe
    {
        public static string maintainer()
        {
            return @"Whatcripto v3.0.0 - Search and Destroy for ciphers
GNU GPL version 3 or later <http://gnu.org/licenses/gpl.html>.

Writen by Allan 'vandalvnl' Garcez
Homepage: https://github.com/vandalvnl/whatcripto
Issues:https://github.com/vandalvnl/whatcripto/issues
or mail-me: vandal.vnl.dev@gmail.com";
        }

        public static string helpOptions()
        {
            return @"-h, --help: Open this menu
            -k, --key: Pass a key to cipher keys
            ";
        }
    }
}
