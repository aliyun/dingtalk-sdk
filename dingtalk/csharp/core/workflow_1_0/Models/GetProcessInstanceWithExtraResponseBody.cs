// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceWithExtraResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessInstanceWithExtraResponseBodyResult Result { get; set; }
        public class GetProcessInstanceWithExtraResponseBodyResult : TeaModel {
            [NameInMap("approverUserIds")]
            [Validation(Required=false)]
            public List<string> ApproverUserIds { get; set; }

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

            [NameInMap("bizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20240505xxxx</para>
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
            public List<GetProcessInstanceWithExtraResponseBodyResultFormComponentValues> FormComponentValues { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultFormComponentValues : TeaModel {
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

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

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fvdsfxxxxxx</para>
            /// </summary>
            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            [NameInMap("operationRecords")]
            [Validation(Required=false)]
            public List<GetProcessInstanceWithExtraResponseBodyResultOperationRecords> OperationRecords { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultOperationRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aacc_ddee</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments> Attachments { get; set; }
                public class GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
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
                    /// <para>50000</para>
                    /// </summary>
                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>.pdf</para>
                    /// </summary>
                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>158469</para>
                    /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>AzBltRlvKukX3WsbLxpDnTZskRNK5GtVfuDlDQ_Qxsp</para>
                /// </summary>
                [NameInMap("handSignToken")]
                [Validation(Required=false)]
                public string HandSignToken { get; set; }

                [NameInMap("images")]
                [Validation(Required=false)]
                public List<string> Images { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>审批人节点</para>
                /// </summary>
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
                /// <para>manager123</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25489</para>
            /// </summary>
            [NameInMap("originatorDeptId")]
            [Validation(Required=false)]
            public string OriginatorDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试部门</para>
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceWithExtraResponseBodyResultTasks> Tasks { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aabb_ccdd</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-12T14:17Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-12T14:17Z</para>
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aflow.dingtalk.com?procInsId=lTGxxx</para>
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aflow.dingtalk.com?procInsId=lTGxxx</para>
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fewferxxxx</para>
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
                /// <para>CANCELED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager123</para>
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
