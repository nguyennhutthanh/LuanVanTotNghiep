import React from 'react'
import { ThemeProvider, makeStyles, useTheme } from '@material-ui/core/styles'
import { Button, Toolbar, AppBar } from '@material-ui/core'
import clsx from 'clsx'
import useSettings from 'app/hooks/useSettings'

const useStyles = makeStyles(({ palette, ...theme }) => ({
    footer: {
        minHeight: 'var(--topbar-height)',
        '@media (max-width: 499px)': {
            display: 'table',
            width: '100%',
            minHeight: 'auto',
            padding: '1rem 0',
            '& .container': {
                flexDirection: 'column !important',
                '& a': {
                    margin: '0 0 16px !important',
                },
            },
        },
    },
    appbar: {
        zIndex: 96,
    }
}))
const divStyle = {
    backgroundImage: 'linear-gradient(to left, rgba(255,0,0,0), rgb(142 235 111))'
};

const Footer = () => {
    const classes = useStyles()
    const theme = useTheme()
    const { settings } = useSettings()

    const footerTheme = settings.themes[settings.footer.theme] || theme

    return (
        <ThemeProvider theme={footerTheme}>
            <AppBar
                position="static"
                className={classes.appbar}
                style={divStyle}
            >
                <Toolbar className={clsx('flex items-center', classes.footer)}>
                    <div className="flex items-center container w-full">
                        <p className="m-0" style={{ fontWeight: 700, color: 'black' }}>
                            Khóa Luận Tốt Nghiệp {' ( '} Hệ thống quản lý siêu thị thực phẩm sạch{' )'}
                        </p>
                        <span className="m-auto"></span>
                        <p className="m-0" >
                            Copyright ©️ <a href="http://localhost:3000">Nguyễn Nhựt Thanh</a> All rights reserved.
                        </p>
                    </div>
                </Toolbar>
            </AppBar>
        </ThemeProvider>
    )
}

export default Footer
