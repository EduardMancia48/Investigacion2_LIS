<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Relations\HasMany;
  
use Illuminate\Database\Eloquent\Model;

class Author extends Model
{
    public $fillable = ['name'];
  
    public function book() : HasMany{
      return $this->hasMany(Blog::class);
    }
}
