// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfWeightResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateKROfWeightResponseBodyData Data { get; set; }
        public class UpdateKROfWeightResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("objectiveProgress")]
            [Validation(Required=false)]
            public UpdateKROfWeightResponseBodyDataObjectiveProgress ObjectiveProgress { get; set; }
            public class UpdateKROfWeightResponseBodyDataObjectiveProgress : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("objectiveScore")]
            [Validation(Required=false)]
            public long? ObjectiveScore { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
