import { useAuth0 } from "@auth0/auth0-react";
import '../App.css';

const LoginButton = () => {
    const { loginWithRedirect, isAuthenticated } = useAuth0();

    return (
        !isAuthenticated && (
            <button onClick={() => loginWithRedirect()}>
                <p className="button">
                    Sign In
                </p>
            </button>
        )
    )
}

export default LoginButton