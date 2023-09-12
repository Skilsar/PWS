import { QueryClient, QueryClientProvider } from "react-query";
import AppContainer from "./AppContainer";

const queryClient = new QueryClient();

function App() {
  return (
    <QueryClientProvider client={queryClient}>
      <AppContainer />
    </QueryClientProvider>
  );
}

export default App;
