// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UploadLearningDataCallbackRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOMEWORK</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672502400000</para>
        /// </summary>
        [NameInMap("generatedTime")]
        [Validation(Required=false)]
        public long? GeneratedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0123456</para>
        /// </summary>
        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shuxue</para>
        /// </summary>
        [NameInMap("subjectCode")]
        [Validation(Required=false)]
        public string SubjectCode { get; set; }

    }

}
