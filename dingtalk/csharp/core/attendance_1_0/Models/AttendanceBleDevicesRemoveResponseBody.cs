// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesRemoveResponseBody : TeaModel {
        /// <summary>
        /// 移出错误列表
        /// </summary>
        [NameInMap("errorList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesRemoveResponseBodyErrorList> ErrorList { get; set; }
        public class AttendanceBleDevicesRemoveResponseBodyErrorList : TeaModel {
            /// <summary>
            /// 错误code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 移除失败蓝牙设备Id列表
            /// </summary>
            [NameInMap("failureList")]
            [Validation(Required=false)]
            public List<long?> FailureList { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        /// <summary>
        /// 移除成功蓝牙设备Id列表
        /// </summary>
        [NameInMap("successList")]
        [Validation(Required=false)]
        public List<long?> SuccessList { get; set; }

    }

}
