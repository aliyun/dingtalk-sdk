// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class ExportMinutesTaskResultRequest : TeaModel {
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("summaryExportSetting")]
        [Validation(Required=false)]
        public ExportMinutesTaskResultRequestSummaryExportSetting SummaryExportSetting { get; set; }
        public class ExportMinutesTaskResultRequestSummaryExportSetting : TeaModel {
            [NameInMap("enableBilingual")]
            [Validation(Required=false)]
            public bool? EnableBilingual { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("targetLang")]
            [Validation(Required=false)]
            public string TargetLang { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>763xxxxxx325f32</para>
        /// </summary>
        [NameInMap("taskUuid")]
        [Validation(Required=false)]
        public string TaskUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5xxxxxxxxxxxxxxEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
