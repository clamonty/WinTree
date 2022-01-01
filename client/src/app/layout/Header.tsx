import { AppBar, FormControlLabel, FormGroup, Switch, Toolbar, Typography } from "@mui/material";

interface Props {
    isDark: boolean;
    handleThemeChange: () => void;
}

export default function Header({isDark, handleThemeChange}: Props) {

    return (
        
        <AppBar sx={{marginBottom: 4}} position='static'>
            <Toolbar>
                <Typography sx={{marginRight: 3}} variant='h6'>WINTREE</Typography>
                <FormGroup>
                    <FormControlLabel
                        control={<Switch
                            checked={isDark}
                            onChange={handleThemeChange} />}
                            label={""}      
                            />
                </FormGroup>
            </Toolbar>
        </AppBar>
    )
}