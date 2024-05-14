// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SaveClassLearningDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignNum")]
        [Validation(Required=false)]
        public int? AssignNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignStudentUserIds")]
        [Validation(Required=false)]
        public List<string> AssignStudentUserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("fileSuffix")]
        [Validation(Required=false)]
        public string FileSuffix { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("generatedTime")]
        [Validation(Required=false)]
        public long? GeneratedTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("questionNum")]
        [Validation(Required=false)]
        public int? QuestionNum { get; set; }

        [NameInMap("questionPictureNum")]
        [Validation(Required=false)]
        public int? QuestionPictureNum { get; set; }

        [NameInMap("standardAnswerPictureNum")]
        [Validation(Required=false)]
        public int? StandardAnswerPictureNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subjectCode")]
        [Validation(Required=false)]
        public string SubjectCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("teacherUserId")]
        [Validation(Required=false)]
        public string TeacherUserId { get; set; }

    }

}
