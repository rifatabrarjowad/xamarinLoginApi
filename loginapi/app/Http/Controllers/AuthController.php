<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Carbon\Carbon;
use App\User;


class AuthController extends Controller
{
   public function register(Request $request)
   {
       # code...
       $request->validate([
           'name' => 'required|string',
           'email' => 'required|string|unique:users',
           'password' => 'required|string|min:6',

       ]);
       $user = new User([
           'name' => $request->name,
           'email' => $request->email,
           'password' => Hash::make($request->password)
       ]);
       $user->save();
       return response()->json(['massage' => 'User has been registered'], 200);
   }

  
}
