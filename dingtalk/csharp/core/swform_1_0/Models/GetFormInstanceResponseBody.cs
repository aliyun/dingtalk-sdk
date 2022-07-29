// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class GetFormInstanceResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFormInstanceResponseBodyResult Result { get; set; }
        public class GetFormInstanceResponseBodyResult : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }
            [NameInMap("forms")]
            [Validation(Required=false)]
            public List<GetFormInstanceResponseBodyResultForms> Forms { get; set; }
            public class GetFormInstanceResponseBodyResultForms : TeaModel {
                public string Key { get; set; }
                public string Label { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

        /// <summary>
        /// 是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
