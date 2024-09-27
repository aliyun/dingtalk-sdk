// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class GetAllFieldsResponseBody : TeaModel {
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<GetAllFieldsResponseBodyValue> Value { get; set; }
        public class GetAllFieldsResponseBodyValue : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>key: id或者name
            ///     value: 对应字段值,不同类型的字段传入的value值不同
            ///       - text: &quot;TextString&quot;          // 文本字符串
            ///       - number: 123                 // 整数/浮点数均可
            ///       - singleSelect: &quot;optionIdxxx1&quot; | &quot;optionName1&quot; // 单选选项Id/单选选项名
            ///       - date: 1688601600000 ｜ &quot;2023-12-20 03:00&quot;
            ///                                     // 支持传时间戳或ISO 8601字符串
            ///       - user: [{
            ///           uid: &quot;1234567&quot;            // 用户uid
            ///         }, {
            ///           uid: &quot;2345678&quot;
            ///         }]</para>
            /// </summary>
            [NameInMap("property")]
            [Validation(Required=false)]
            public Dictionary<string, object> Property { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
