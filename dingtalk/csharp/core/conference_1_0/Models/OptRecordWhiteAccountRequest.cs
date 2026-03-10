// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class OptRecordWhiteAccountRequest : TeaModel {
        [NameInMap("requestBody")]
        [Validation(Required=false)]
        public OptRecordWhiteAccountRequestRequestBody RequestBody { get; set; }
        public class OptRecordWhiteAccountRequestRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_record</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public int? Operation { get; set; }

            [NameInMap("settingRangeList")]
            [Validation(Required=false)]
            public List<OptRecordWhiteAccountRequestRequestBodySettingRangeList> SettingRangeList { get; set; }
            public class OptRecordWhiteAccountRequestRequestBodySettingRangeList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vLY8xxxxxxxQiEiE</para>
                /// </summary>
                [NameInMap("settingRangeId")]
                [Validation(Required=false)]
                public string SettingRangeId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("settingRangeType")]
                [Validation(Required=false)]
                public int? SettingRangeType { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vLXXXiEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
