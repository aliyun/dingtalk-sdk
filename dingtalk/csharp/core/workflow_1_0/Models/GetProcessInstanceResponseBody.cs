// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessInstanceResponseBodyResult Result { get; set; }
        public class GetProcessInstanceResponseBodyResult : TeaModel {
            [NameInMap("approverUserIds")]
            [Validation(Required=false)]
            public List<string> ApproverUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;instance1&quot;,&quot;instance2&quot;]</para>
            /// </summary>
            [NameInMap("attachedProcessInstanceIds")]
            [Validation(Required=false)]
            public List<string> AttachedProcessInstanceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MODIFY</para>
            /// </summary>
            [NameInMap("bizAction")]
            [Validation(Required=false)]
            public string BizAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;mykey&quot;: &quot;myData&quot;}</para>
            /// </summary>
            [NameInMap("bizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("ccUserIds")]
            [Validation(Required=false)]
            public List<string> CcUserIds { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31T11:52Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-31T11:52Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("formComponentValues")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultFormComponentValues> FormComponentValues { get; set; }
            public class GetProcessInstanceResponseBodyResultFormComponentValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TextField-bizAlias</para>
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DDSelectField</para>
                /// </summary>
                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DDHolidayField-J2Bxxxx</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>组件1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AG3U12xWRFex63h6bCPUWw10221698052827</para>
            /// </summary>
            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            [NameInMap("operationRecords")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultOperationRecords> OperationRecords { get; set; }
            public class GetProcessInstanceResponseBodyResultOperationRecords : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> Attachments { get; set; }
                public class GetProcessInstanceResponseBodyResultOperationRecordsAttachments : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>学历证明</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pdf</para>
                    /// </summary>
                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    [NameInMap("spaceId")]
                    [Validation(Required=false)]
                    public string SpaceId { get; set; }

                }

                [NameInMap("ccUserIds")]
                [Validation(Required=false)]
                public List<string> CcUserIds { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-31T11:52Z</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("images")]
                [Validation(Required=false)]
                public List<string> Images { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>评论</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AGREE</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("showName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXECUTE_TASK_NORMAL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager1</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("originatorDeptId")]
            [Validation(Required=false)]
            public string OriginatorDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("originatorDeptName")]
            [Validation(Required=false)]
            public string OriginatorDeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager1</para>
            /// </summary>
            [NameInMap("originatorUserId")]
            [Validation(Required=false)]
            public string OriginatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultTasks> Tasks { get; set; }
            public class GetProcessInstanceResponseBodyResultTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-31T11:52Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-31T11:52Z</para>
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.xxxx.com">https://www.xxxx.com</a></para>
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.xxxx.com">https://www.xxxx.com</a></para>
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REDIRECTED</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NEW</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager1</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx提交的请假申请</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
