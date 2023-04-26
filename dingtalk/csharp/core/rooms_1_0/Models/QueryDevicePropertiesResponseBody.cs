// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDevicePropertiesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryDevicePropertiesResponseBodyResult> Result { get; set; }
        public class QueryDevicePropertiesResponseBodyResult : TeaModel {
            [NameInMap("propertyName")]
            [Validation(Required=false)]
            public string PropertyName { get; set; }

            [NameInMap("propertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

        }

    }

}
