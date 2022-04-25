// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetLeaveTypeRequest : TeaModel {
        /// <summary>
        /// 操作者ID
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 空:开放接口定义假期类型;all:所有假期类型
        /// </summary>
        [NameInMap("vacationSource")]
        [Validation(Required=false)]
        public string VacationSource { get; set; }

    }

}
