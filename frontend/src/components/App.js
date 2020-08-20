import React from "react";
import {BrowserRouter, Route, Switch} from "react-router-dom";
import Home from "./Home";
import Header from "./Header";

const App = () => {
    return (
        <div className="ui container">
            <BrowserRouter>
                <div>
                    <Header />
                    <Switch>
                        <Route path="/" exact component={Home} />
                    </Switch>
                </div>
            </BrowserRouter>
        </div>
    );
}

export default App;