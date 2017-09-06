#include <bits/stdc++.h>
#define MOD 1000000007
#define INF 1<<29
#define times int t;scanf("%d",&t);while(t--)

using namespace std;
typedef long int li;
typedef long long int lli;
typedef unsigned long long int ullli;
typedef vector<int> vi;
typedef vector<vi> vvi;
//typedef pair<int,int>pi;
typedef map<int,int>mi;
//typedef unordered_map<int,int> umi;
typedef set<int>si;
//typedef unordered_set<int>usi;
#define vec(x) vector<x>
#define mat(x) vector< vector<x> >
#define rep(i,n) for(int i=0;i<(n);i++)
#define Fori(a,b) for(int i=(a);i<=(b);i++)
#define Forj(a,b) for(int j=(a);j<=(b);j++)
#define mp(a,b) make_pair((a),(b))
#define DEBUG(x) cout<<"#x : "<<x<<endl;
#define graph(x,n) vector<list<x> >graph(n);
#define type(x) __typeof(x.begin())
#define foreach(i,x) for(type(x) i=x.begin();i!=x.end();++i)
#define pb(x) push_back(x)
#define pi(x,y) pair<x,y>

bool FindEmpty(mat(int) &grid,int &r,int &c){
    for(r=0;r<9;r++){
        for(c=0;c<9;c++){
            //printf("%d ",grid[i][j]);
            if(grid[r][c]==0){
               // cout<<r<<" "<<c<<endl;
                return true;
            }
        }
    }
    return false;
}
bool RowCheck(mat(int) &grid,int r,int num){
    for(int i=0;i<9;i++)if(grid[r][i]==num)return true;
    return false;
}

bool ColCheck(mat(int) &grid,int c,int num){
    for(int i=0;i<9;i++)if(grid[i][c]==num)return true;
    return false;
}

bool Box(mat(int) &grid,int r,int c,int num){
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            if(grid[r+i][c+j]==num)return true;
        }
    }
    return false;
}

bool isSafe(mat(int) &grid,int r,int c,int num){
    return(!RowCheck(grid,r,num)&&
            !ColCheck(grid,c,num)&&
            !Box(grid,r-r%3,c-c%3,num));
}

bool solve(mat(int) &grid){
    int r,c;
    if(!FindEmpty(grid,r,c))return true;
   // cout<<r<<" "<<c<<endl;
    for(int num=1;num<=9;num++){
        if(isSafe(grid,r,c,num)){
            grid[r][c]=num;
            if(solve(grid))return true;
            grid[r][c]=0;
        }
    }
return false;
}
void Print(mat(int) &arr){
    Fori(0,8){
        Forj(0,8){
            //printf("%d ",grid[i][j]);
            cout<<arr[i][j]<<" ";
        }
       // printf("\n");
    }
    printf("\n");
}

int main() {
	// your code goes here
	//freopen("input.in","r",stdin);
    //freopen("output.out","w",stdout);
    int n=9;
    times{
        vvi arr(n,vi(n,0));
        Fori(0,8){
            Forj(0,8){
                scanf("%d",&arr[i][j]);
            }
        }
        if(solve(arr)==true){
            Print(arr);
        }else{
            printf("Solution doesn't exit\n");
        }
        //Print(arr);
    }
    
	return 0;
}