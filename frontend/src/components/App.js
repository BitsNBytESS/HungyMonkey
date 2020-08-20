import React from "react";
import {BrowserRouter, Route, Switch} from "react-router-dom";
import Home from "./Home";

const App = () => {
    return (
        <div className="ui container">
            <BrowserRouter>
                <div>
                    <Switch>
                        <Route path="/" exact component={Home} />
                    </Switch>
                </div>
            </BrowserRouter>
        </div>
    );
}

export default App;