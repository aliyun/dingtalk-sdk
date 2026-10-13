// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class UpdateAICardRequest : TeaModel {
        [NameInMap("a2uiAnnotations")]
        [Validation(Required=false)]
        public List<UpdateAICardRequestA2uiAnnotations> A2uiAnnotations { get; set; }
        public class UpdateAICardRequestA2uiAnnotations : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("surfaceId")]
            [Validation(Required=false)]
            public string SurfaceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("a2uiMessages")]
        [Validation(Required=false)]
        public List<string> A2uiMessages { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSING</para>
        /// </summary>
        [NameInMap("flowStatus")]
        [Validation(Required=false)]
        public string FlowStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2ui_order_001</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update_001</para>
        /// </summary>
        [NameInMap("outUpdateId")]
        [Validation(Required=false)]
        public string OutUpdateId { get; set; }

    }

}
