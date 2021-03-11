// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetUserHolidaysResponseBody : TeaModel {
        /// <summary>
        /// 员工假期列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetUserHolidaysResponseBodyResult> Result { get; set; }
        public class GetUserHolidaysResponseBodyResult : TeaModel {
            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 假期列表
            /// </summary>
            [NameInMap("holidays")]
            [Validation(Required=false)]
            public List<GetUserHolidaysResponseBodyResultHolidays> Holidays { get; set; }
            public class GetUserHolidaysResponseBodyResultHolidays : TeaModel {
                /// <summary>
                /// 日期
                /// </summary>
                [NameInMap("workDate")]
                [Validation(Required=false)]
                public long? WorkDate { get; set; }

                /// <summary>
                /// 假期名称
                /// </summary>
                [NameInMap("holidayName")]
                [Validation(Required=false)]
                public string HolidayName { get; set; }

                /// <summary>
                /// 假期类型，festival：法定节假日；rest：调休日；overtime：加班日；
                /// </summary>
                [NameInMap("holidayType")]
                [Validation(Required=false)]
                public string HolidayType { get; set; }

                /// <summary>
                /// 补休日，只有假期类型为加班日时才有值
                /// </summary>
                [NameInMap("realWorkDate")]
                [Validation(Required=false)]
                public long? RealWorkDate { get; set; }

            }

        }

    }

}
