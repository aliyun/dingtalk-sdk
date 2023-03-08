// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDevicePropertiesResponseBody : TeaModel {
        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryDevicePropertiesResponseBodyResult> Result { get; set; }
        public class QueryDevicePropertiesResponseBodyResult : TeaModel {
            /// <summary>
            /// 设备属性名称
            /// </summary>
            [NameInMap("propertyName")]
            [Validation(Required=false)]
            public string PropertyName { get; set; }

            /// <summary>
            /// 设备属性值
            /// </summary>
            [NameInMap("propertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

        }

    }

}
