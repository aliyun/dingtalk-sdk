// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetJobPostResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetJobPostResponseBodyContent Content { get; set; }
        public class GetJobPostResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("establishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
