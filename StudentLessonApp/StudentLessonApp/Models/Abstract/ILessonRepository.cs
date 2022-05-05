﻿using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Abstract
{
    public interface ILessonRepository : IReadOnlySet<Lesson>
    {
    }
}
