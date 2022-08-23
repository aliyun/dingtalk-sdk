// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueResponseBody : TeaModel {
        /// <summary>
        /// 返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateCustomfieldValueResponseBodyResult Result { get; set; }
        public class UpdateCustomfieldValueResponseBodyResult : TeaModel {
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<UpdateCustomfieldValueResponseBodyResultCustomfields> Customfields { get; set; }
            public class UpdateCustomfieldValueResponseBodyResultCustomfields : TeaModel {
                public string CustomfieldId { get; set; }
                public List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue : TeaModel {
                    public string Title { get; set; }
                }
            }
        };

    }

}
