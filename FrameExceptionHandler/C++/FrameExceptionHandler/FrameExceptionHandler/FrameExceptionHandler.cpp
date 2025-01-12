#include <cstdio>

struct Error
{
    const char* message;
};

class FrameExceptionHandler
{
private:
    Error *_error = nullptr;
    
public:
    FrameExceptionHandler(Error *error)
    {
        _error = error;
    }

    FrameExceptionHandler *NextHandler = nullptr;
    
    void Append(Error *newError)
    {
        NextHandler = new FrameExceptionHandler(newError);
    }

    const char * GetError()
    {
        return _error->message;
    }
};

int main(int argc, char* argv[])
{
    Error *error1 = new Error();
    error1->message = "Error has occurred";
    FrameExceptionHandler *handler1 = new FrameExceptionHandler(error1);

    Error *error2 = new Error();
    error2->message = "Another error has occurred";
    handler1->Append(error2);

    printf("Error 1 is: %s\n", handler1->GetError());
    printf("Error 2 is: %s\n", handler1->NextHandler->GetError());
    
    return 0;
}
