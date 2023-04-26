// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetUserHolidaysResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetUserHolidaysResponseBodyResult> Result { get; set; }
        public class GetUserHolidaysResponseBodyResult : TeaModel {
            [NameInMap("holidays")]
            [Validation(Required=false)]
            public List<GetUserHolidaysResponseBodyResultHolidays> Holidays { get; set; }
            public class GetUserHolidaysResponseBodyResultHolidays : TeaModel {
                [NameInMap("holidayName")]
                [Validation(Required=false)]
                public string HolidayName { get; set; }

                [NameInMap("holidayType")]
                [Validation(Required=false)]
                public string HolidayType { get; set; }

                [NameInMap("realWorkDate")]
                [Validation(Required=false)]
                public long? RealWorkDate { get; set; }

                [NameInMap("workDate")]
                [Validation(Required=false)]
                public long? WorkDate { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
