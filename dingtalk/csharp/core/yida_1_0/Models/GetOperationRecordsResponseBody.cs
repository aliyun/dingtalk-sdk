// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetOperationRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOperationRecordsResponseBodyResult> Result { get; set; }
        public class GetOperationRecordsResponseBodyResult : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("actionExit")]
            [Validation(Required=false)]
            public string ActionExit { get; set; }

            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("dataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("digitalSign")]
            [Validation(Required=false)]
            public string DigitalSign { get; set; }

            [NameInMap("domainList")]
            [Validation(Required=false)]
            public List<GetOperationRecordsResponseBodyResultDomainList> DomainList { get; set; }
            public class GetOperationRecordsResponseBodyResultDomainList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>return</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-02-01</para>
                /// </summary>
                [NameInMap("activeTimeGMT")]
                [Validation(Required=false)]
                public string ActiveTimeGMT { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>act-xxaanfaf</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://oss.com/Signature.pdf">https://oss.com/Signature.pdf</a></para>
                /// </summary>
                [NameInMap("digitalSignature")]
                [Validation(Required=false)]
                public string DigitalSignature { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://oss.com/a.pdf">https://oss.com/a.pdf</a></para>
                /// </summary>
                [NameInMap("files")]
                [Validation(Required=false)]
                public string Files { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("formatAction")]
                [Validation(Required=false)]
                public string FormatAction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-01</para>
                /// </summary>
                [NameInMap("operateTimeGMT")]
                [Validation(Required=false)]
                public string OperateTimeGMT { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>remove</para>
                /// </summary>
                [NameInMap("operateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager123</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1732223326,1232321888,12188991</para>
                /// </summary>
                [NameInMap("operatorAgentIdList")]
                [Validation(Required=false)]
                public List<GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList> OperatorAgentIdList { get; set; }
                public class GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>开发部成立于2000年</para>
                    /// </summary>
                    [NameInMap("departmentDescription")]
                    [Validation(Required=false)]
                    public string DepartmentDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>测试应用</para>
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("displayNameInEnglish")]
                    [Validation(Required=false)]
                    public string DisplayNameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>o-YDJKINSSDLLND</para>
                    /// </summary>
                    [NameInMap("orderNumber")]
                    [Validation(Required=false)]
                    public string OrderNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://abc.com/a.png">https://abc.com/a.png</a></para>
                    /// </summary>
                    [NameInMap("personalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>running</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ding173982232112232</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("userInformation")]
                    [Validation(Required=false)]
                    public string UserInformation { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("operatorDisplayName")]
                [Validation(Required=false)]
                public string OperatorDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("operatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>无冬</para>
                /// </summary>
                [NameInMap("operatorNickName")]
                [Validation(Required=false)]
                public string OperatorNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://oss.com/a.jpeg">https://oss.com/a.jpeg</a></para>
                /// </summary>
                [NameInMap("operatorPhotoUrl")]
                [Validation(Required=false)]
                public string OperatorPhotoUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>良好</para>
                /// </summary>
                [NameInMap("operatorStatus")]
                [Validation(Required=false)]
                public string OperatorStatus { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>请购类型</para>
                /// </summary>
                [NameInMap("showName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>同步</para>
                /// </summary>
                [NameInMap("taskExecuteType")]
                [Validation(Required=false)]
                public string TaskExecuteType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-01</para>
                /// </summary>
                [NameInMap("taskHoldTimeGMT")]
                [Validation(Required=false)]
                public long? TaskHoldTimeGMT { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>task-123</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>append task</para>
                /// </summary>
                [NameInMap("taskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i18n</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            [NameInMap("operateTimeGMT")]
            [Validation(Required=false)]
            public string OperateTimeGMT { get; set; }

            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("operatorDisplayName")]
            [Validation(Required=false)]
            public string OperatorDisplayName { get; set; }

            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("operatorNickName")]
            [Validation(Required=false)]
            public string OperatorNickName { get; set; }

            [NameInMap("operatorPhotoUrl")]
            [Validation(Required=false)]
            public string OperatorPhotoUrl { get; set; }

            [NameInMap("operatorStatus")]
            [Validation(Required=false)]
            public string OperatorStatus { get; set; }

            [NameInMap("operatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("taskExecuteType")]
            [Validation(Required=false)]
            public string TaskExecuteType { get; set; }

            [NameInMap("taskHoldTimeGMT")]
            [Validation(Required=false)]
            public long? TaskHoldTimeGMT { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
