// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusRequest : TeaModel {
        /// <summary>
        /// 自定义字段ID。
        /// </summary>
        [NameInMap("customfieldId")]
        [Validation(Required=false)]
        public string CustomfieldId { get; set; }

        /// <summary>
        /// 自定义字段InstanceId(如果提供自定义字段ID 或者 自定义字段名称 则忽略)。
        /// </summary>
        [NameInMap("customfieldInstanceId")]
        [Validation(Required=false)]
        public string CustomfieldInstanceId { get; set; }

        /// <summary>
        /// 自定义字段名称(如果提供自定义字段ID 则忽略)。
        /// </summary>
        [NameInMap("customfieldName")]
        [Validation(Required=false)]
        public string CustomfieldName { get; set; }

        /// <summary>
        /// 字段值集合。
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<CreateProjectCustomfieldStatusRequestValue> Value { get; set; }
        public class CreateProjectCustomfieldStatusRequestValue : TeaModel {
            /// <summary>
            /// 字段值id。
            /// </summary>
            [NameInMap("fieldvalueId")]
            [Validation(Required=false)]
            public string FieldvalueId { get; set; }

            /// <summary>
            /// 字段值元信息(json格式)。
            /// </summary>
            [NameInMap("metaString")]
            [Validation(Required=false)]
            public string MetaString { get; set; }

            /// <summary>
            /// 字段值渲染值。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
