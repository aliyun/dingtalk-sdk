// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class SalaryThirdDataIntegrationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atData</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SalaryThirdDataIntegrationRequestItems> Items { get; set; }
        public class SalaryThirdDataIntegrationRequestItems : TeaModel {
            [NameInMap("bizContents")]
            [Validation(Required=false)]
            public List<SalaryThirdDataIntegrationRequestItemsBizContents> BizContents { get; set; }
            public class SalaryThirdDataIntegrationRequestItemsBizContents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>工作时长</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
