// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetJobPositionResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetJobPositionResponseBodyContent Content { get; set; }
        public class GetJobPositionResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
            /// </summary>
            [NameInMap("establishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobCode")]
            [Validation(Required=false)]
            public string JobCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>有良好的技术素养</para>
            /// </summary>
            [NameInMap("jobRequirements")]
            [Validation(Required=false)]
            public string JobRequirements { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>技术开发</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
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
