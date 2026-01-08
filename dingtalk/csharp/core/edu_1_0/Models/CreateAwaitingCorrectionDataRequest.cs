// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateAwaitingCorrectionDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/files/corrected_math_hw_T250401-001.pdf">https://example.com/files/corrected_math_hw_T250401-001.pdf</a></para>
        /// </summary>
        [NameInMap("allAssignmentPdfUrl")]
        [Validation(Required=false)]
        public string AllAssignmentPdfUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>501</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding8196cd122f5cc6abecb851</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;paperSize&quot;:&quot;A4&quot;,&quot;duplex&quot;:false,&quot;color&quot;:true}</para>
        /// </summary>
        [NameInMap("printInfo")]
        [Validation(Required=false)]
        public string PrintInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRINTER1</para>
        /// </summary>
        [NameInMap("printerCode")]
        [Validation(Required=false)]
        public string PrinterCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数学</para>
        /// </summary>
        [NameInMap("subjectName")]
        [Validation(Required=false)]
        public string SubjectName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING_GRADING_1</para>
        /// </summary>
        [NameInMap("taskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
