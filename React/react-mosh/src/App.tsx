import { useState } from "react";
import Alert from "./components/Alert";
import Button from "./components/Button";
import ListGroup from "./components/ListGroup";

function App() {
  const [alertVisible, setAlertVisible] = useState(false);

  const items = ["New York", "San Francisco", "Tokyo", "London", "Paris"];

  return (
    <div>
      {alertVisible && (
        <Alert
          onClose={() => {
            setAlertVisible(false);
          }}
        >
          My Alert
        </Alert>
      )}
      <ListGroup
        items={items}
        heading="Cities"
        onSelectItem={(item) => {
          console.log(item);
        }}
      />
      <Button
        onClick={() => {
          setAlertVisible(true);
        }}
      >
        My button
      </Button>
    </div>
  );
}

export default App;
