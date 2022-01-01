import { Container, createTheme, CssBaseline, ThemeProvider } from "@mui/material";
import { useState } from "react";
import Catalog from "../../features/catalog/Catalog";
// Import product type for type checking
import Header from "./Header";  
function App() {
  // State to track dark mode
  const [isDark, setIsDark] = useState(false);

  const handleThemeChange = () => {
    setIsDark(!isDark);
  }
  // Set palette theme based on isDark state
  const theme = createTheme({
    palette: {
      mode: isDark ? 'dark' : 'light',
      background: {
        default: isDark ? '#121212' : '#eaeaea'
      }
    }
  });

  // <CssBasline/> is Material-UI style reset
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline/>
      <Header isDark={isDark} handleThemeChange={handleThemeChange}/>
      <Container>
        <Catalog/>
      </Container>
    </ThemeProvider>
  );
}

export default App;
