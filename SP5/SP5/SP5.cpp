// SP5.cpp : Определяет точку входа для приложения.
//

#include "framework.h"
#include "SP5.h"

#define MAX_LOADSTRING 100

// Глобальные переменные:
HINSTANCE hInst;                                // текущий экземпляр
WCHAR szTitle[MAX_LOADSTRING];                  // Текст строки заголовка
WCHAR szWindowClass[MAX_LOADSTRING];            // имя класса главного окна

// Задание 1
bool Task1 = false;
const int IDButton1 = 1;
HWND But1;

//  Задание 2
bool task2 = false;
const int IDButton2 = 2;
HWND But2;

//  Задание 3
bool task3 = false;
const int IDButton3 = 3;
const int IDI_TIMER1 = 8;
HWND But3;
HWND win;
HWND sharp;
HWND desk;
UINT_PTR wTimer = 5;

HDC hdc_sharp;
HDC hdc_desktop;
HDC hdc_win;
HDC hdc_client;
RECT rect;
//int CircleCenterX = 0, CircleCenterY = 0;
int R = 50;
int dx = 16;
int dy = 9;

//  Задание 4
bool task4 = false;
const int IDButton4 = 4;
HWND But4;
BOOL draw = false;
POINT PBegin, PEndOld, PEnd;
HPEN pen;
RECT redactor = { 20, 80, 800, 450 };

BOOL red = true;
BOOL blue = false;
BOOL green = false;

HWND ButRed;
HWND ButBlue;
HWND ButGreen;
const int IDButRed = 5;
const int IDButBlue = 6;
const int IDButGreen = 7;

// Отправить объявления функций, включенных в этот модуль кода:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Разместите код здесь.

    // Инициализация глобальных строк
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_SP5, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Выполнить инициализацию приложения:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_SP5));

    MSG msg;

    // Цикл основного сообщения:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  ФУНКЦИЯ: MyRegisterClass()
//
//  ЦЕЛЬ: Регистрирует класс окна.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_SP5));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_SP5);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   ФУНКЦИЯ: InitInstance(HINSTANCE, int)
//
//   ЦЕЛЬ: Сохраняет маркер экземпляра и создает главное окно
//
//   КОММЕНТАРИИ:
//
//        В этой функции маркер экземпляра сохраняется в глобальной переменной, а также
//        создается и выводится главное окно программы.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Сохранить маркер экземпляра в глобальной переменной

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   But1 = CreateWindow(TEXT("BUTTON"), TEXT("Задание 1"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON, 
       20, 20, 150, 50, hWnd, (HMENU)IDButton1, hInstance, NULL);

   But2 = CreateWindow(TEXT("BUTTON"), TEXT("Задание 2"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON, 
       200, 20, 150, 50, hWnd, (HMENU)IDButton2, hInstance, NULL);

   But3 = CreateWindow(TEXT("BUTTON"), TEXT("Задание 3"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON, 
       380, 20, 150, 50, hWnd, (HMENU)IDButton3, hInstance, NULL);
   
   But4 = CreateWindow(TEXT("BUTTON"), TEXT("Задание 4"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON, 
       560, 20, 150, 50, hWnd, (HMENU)IDButton4, hInstance, NULL);

   ButRed = CreateWindow(TEXT("BUTTON"), TEXT("Red"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON,
       880, 20, 120, 20, hWnd, (HMENU)IDButRed, hInstance, NULL);
   ButBlue = CreateWindow(TEXT("BUTTON"), TEXT("Blue"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON,
       880, 50, 120, 20, hWnd, (HMENU)IDButBlue, hInstance, NULL);
   ButGreen = CreateWindow(TEXT("BUTTON"), TEXT("Green"), WS_VISIBLE | WS_CHILD | BS_PUSHBUTTON,
       880, 80, 120, 20, hWnd, (HMENU)IDButGreen, hInstance, NULL);

   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

void DrawFlag(HDC hdc, int x0, int y0, int width, int height)
{
    HBRUSH white = CreateSolidBrush(RGB(255, 255, 255));
    HBRUSH blue = CreateSolidBrush(RGB(0, 0, 255));
    HBRUSH red = CreateSolidBrush(RGB(255, 0, 0));
    SelectObject(hdc, white);
    Rectangle(hdc, x0, y0, x0 + width, y0 + height);
    SelectObject(hdc, blue);
    Rectangle(hdc, x0, y0 + height, x0 + width, y0 + 2*height);
    SelectObject(hdc, red);
    Rectangle(hdc, x0, y0 + 2*height, x0 + width, y0 + 3*height);
    DeleteObject(white);
    DeleteObject(blue);
    DeleteObject(red);
}
void Circle(HWND hwnd, HDC hdc, int x_c, int y_c, int R, COLORREF color, RECT& circleRECT)
{
    SelectObject(hdc, CreateSolidBrush(color));
    Ellipse(hdc, x_c - R, y_c - R, x_c + R, y_c + R);
    circleRECT = { x_c - R*3, y_c - R*3,  x_c + R*3, y_c + R*3 };
}

//
//  ФУНКЦИЯ: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  ЦЕЛЬ: Обрабатывает сообщения в главном окне.
//
//  WM_COMMAND  - обработать меню приложения
//  WM_PAINT    - Отрисовка главного окна
//  WM_DESTROY  - отправить сообщение о выходе и вернуться
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_LBUTTONDOWN:
    {
        //Если курсор в указанной для редактора области и соответствующая кнопка была нажата
        if (task4 &&
            LOWORD(lParam) > redactor.left &&
            LOWORD(lParam) < redactor.right &&
            HIWORD(lParam) > redactor.top &&
            HIWORD(lParam) < redactor.bottom)
        {
            //Начали рисование линии
            draw = true;
            //Определили начальную точку
            PBegin.x =  PEndOld.x = LOWORD(lParam);
            PBegin.y = PEndOld.y = HIWORD(lParam);
            if (red)
                pen = CreatePen(PS_SOLID, 2, RGB(255, 0, 0));
            if (blue)
                pen = CreatePen(PS_SOLID, 2, RGB(0, 0, 255));
            if (green)
                pen = CreatePen(PS_SOLID, 2, RGB(0, 255, 0));
        }
        break;
    }
    case WM_MOUSEMOVE:
    {
        //Если курсор в указанной для редактора области и линия рисуется
        if (draw &&
            LOWORD(lParam) > redactor.left &&
            LOWORD(lParam) < redactor.right &&
            HIWORD(lParam) > redactor.top &&
            HIWORD(lParam) < redactor.bottom)
        {
            HDC hdc = GetDC(hWnd);
            SelectObject(hdc, pen);
            SetROP2(hdc, R2_NOTXORPEN);
            MoveToEx(hdc, PBegin.x, PBegin.y, nullptr);
            LineTo(hdc, PEndOld.x, PEndOld.y);
            MoveToEx(hdc, PBegin.x, PBegin.y, nullptr);
            LineTo(hdc, LOWORD(lParam), HIWORD(lParam));
            PEndOld.x = LOWORD(lParam);
            PEndOld.y = HIWORD(lParam);
            ReleaseDC(hWnd, hdc);
        }
        break;
    }
    case WM_LBUTTONUP:
    {
        //Если курсор в указанной для редактора области и линия рисовалась
        if (draw &&
            LOWORD(lParam) > redactor.left &&
            LOWORD(lParam) < redactor.right &&
            HIWORD(lParam) > redactor.top &&
            HIWORD(lParam) < redactor.bottom)
        {
            DeleteObject(pen);
            draw = false;
        }
        break;
    }
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
            // Разобрать выбор в меню:
            switch (wmId)
            {
            case IDButton1:
            {
                Task1 = true;
                RECT rectWin;
                GetClientRect(hWnd, &rectWin);
                InvalidateRect(hWnd, &rectWin, true);
                UpdateWindow(hWnd);
                break;
            }
            case IDButton2:
            {
                task2 = true;
                RECT rectWin;
                GetClientRect(hWnd, &rectWin);
                InvalidateRect(hWnd, &rectWin, true);
                UpdateWindow(hWnd);
                break;
            }
            case IDButton3:
            {
                if (!task3)
                {
                    task3 = true;
                    RECT client;
                    hdc_win = GetWindowDC(hWnd);
                    desk = GetDesktopWindow();
                    hdc_desktop = GetWindowDC(desk);
                    sharp = FindWindow(NULL, L"Form1");
                    hdc_sharp = GetDC(sharp);
                    hdc_client = GetDC(hWnd);
                    SetTimer(hWnd, IDI_TIMER1, 50, (TIMERPROC)NULL);
                    GetClientRect(hWnd, &client);
                    InvalidateRect(hWnd, &client, true);
                    UpdateWindow(hWnd);
                }
                else
                {
                    task3 = false;

                    KillTimer(hWnd, IDI_TIMER1);
                    ReleaseDC(desk, hdc_desktop);
                    ReleaseDC(sharp, hdc_sharp);
                    ReleaseDC(hWnd, hdc_win);
                    ReleaseDC(hWnd, hdc_client);
                }
            break;
            }
            case IDButton4:
            {
                task4 = true;
                RECT rectWin;
                GetClientRect(hWnd, &rectWin);
                InvalidateRect(hWnd, &rectWin, true);
                UpdateWindow(hWnd);
                break;
            }
            case IDButRed:
            {
                red = true;
                blue = false;
                green = false;
                break;
            }
            case IDButBlue:
            {
                red = false;
                blue = true;
                green = false;
                break;
            }
            case IDButGreen:
            {
                red = false;
                blue = false;
                green = true;
                break;
            }
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
    {
        PAINTSTRUCT ps;
        HDC hdc = BeginPaint(hWnd, &ps);
        // TODO: Добавьте сюда любой код прорисовки, использующий HDC...

        if (Task1)
        {
            HWND win = GetDesktopWindow();
            HDC cl = GetDC(win);
            RECT rec;
            long long red = 0, green = 0, blue = 0, count = 0;
            GetWindowRect(win, &rec);
            for (int i = 0; i < rec.right; i += 300)
                for (int j = 0; j < rec.bottom; j += 300)
                {
                    count++;
                    COLORREF color = GetPixel(cl, i, j);
                    red += GetRValue(color);
                    green += GetGValue(color);
                    blue += GetBValue(color);
                }
            red = int(red / count);
            green = int(green / count);
            blue = int(blue / count);
            COLORREF wincolor = RGB(red, green, blue);
            ReleaseDC(win, cl);

            RECT hWnd_rect;
            GetWindowRect(hWnd, &hWnd_rect);
            hWnd_rect.top = 0;
            hWnd_rect.left = 0;
            FillRect(hdc, &hWnd_rect, (HBRUSH)CreateSolidBrush(wincolor));

            SetBkColor(hdc, wincolor);

            HGDIOBJ font = CreateFont(64, 0, 0, 0, 0, false, false, false, ANSI_CHARSET, OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY, FF_DONTCARE, L"Courier new");
            SetTextColor(hdc, RGB(rand() % 256, rand() % 256, rand() % 256));
            SelectObject(hdc, font);
            TextOut(hdc, 20, 70, TEXT("Hello, World!"), 12);

            SelectObject(hdc, CreateSolidBrush(RGB(rand() % 256, rand() % 256, rand() % 256)));
            Rectangle(hdc, 40, 150, 90, 200);

            SelectObject(hdc, CreateSolidBrush(RGB(rand() % 256, rand() % 256, rand() % 256)));
            Ellipse(hdc, 190, 150, 240, 200);

            SelectObject(hdc, CreateSolidBrush(RGB(rand() % 256, rand() % 256, rand() % 256)));
            POINT vertex[3];
            vertex[0].x = 110;
            vertex[0].y = 200;
            vertex[1].x = 140;
            vertex[1].y = 150;
            vertex[2].x = 170;
            vertex[2].y = 200;
            Polygon(hdc, vertex, 3);

            Task1 = false;
        }
        if (task2)
        {
            HDC hdc;
            HPEN hp;
            HWND win;
            int length = 200, height = 50;

            hdc = GetDC(hWnd);
            DrawFlag(hdc, length * 2, height * 3, length, height);
            ReleaseDC(hWnd, hdc);

            hdc = GetWindowDC(hWnd);
            DrawFlag(hdc, 0, 0, length, height);
            ReleaseDC(hWnd, hdc);

            win = GetDesktopWindow();
            hdc = GetWindowDC(win);
            DrawFlag(hdc, 0, 0, length, height);
            ReleaseDC(win, hdc);

            task2 = false;
        }
        if (task3)
        {   //SetTimer(hWnd, IDI_TIMER1, 50, (TIMERPROC)NULL);
            Circle(hWnd, hdc_win, dx + 100, dy, R, RGB(0, 0, 255), rect);
            Circle(hWnd, hdc_client, dx, dy, R, RGB(0, 255, 255), rect);

        }
        if (task4)
        {
            HPEN pen = CreatePen(PS_SOLID, 3, RGB(0, 0, 0));
            SelectObject(hdc, pen);
            Rectangle(hdc, redactor.left, redactor.top, redactor.right, redactor.bottom);
            DeleteObject(pen);

            EndPaint(hWnd, &ps);
        }
        break;
    }

    case WM_TIMER:
    {
        dx += 13;
        dy += 9;
        InvalidateRect(hWnd, &rect, true);
        Circle(desk, hdc_desktop, dx, dy, R, RGB(255, 0, 0), rect);
        rect.top += 10;
        rect.right += 10;
        rect.bottom += 10;
        rect.left += 10;

        if (sharp)
        {
            InvalidateRect(sharp, &rect, true);
            UpdateWindow(sharp);
            Circle(sharp, hdc_sharp, dx, dy, R, RGB(0, 255, 0), rect);
        }

        InvalidateRect(desk, &rect, true);
        UpdateWindow(desk);
        break;
    }
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Обработчик сообщений для окна "О программе".
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}
