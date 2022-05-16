// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesTeamMgmtRequest : TeaModel {
        /// <summary>
        /// 本次操作的行为，取值： ● add：增加   -- 创建群 ● update：更新 -- 群成员变更
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// ISV的唯一标识,由BPaaS分配
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 基础数据名称。比如班组
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// 事件配置列表(启用卡片列表),所有枚举值： 任务分配提醒: TASK_ASSIGN_REMINDER 任务逾期提醒: TASK_OVERDUE_REMINDER 置顶加急任务: STICK_URGET_TASK 报工审批提醒: OUTPUT_APPROVE_REMINDER 报工审批反馈: OUTPUT_APPROVE_RESULT 班组概览 :TEAM_OVERVIEW 我的任务:MYTASK_OVERVIEW     例如： ["STICK_URGET_TASK","OUTPUT_APPROVE_REMINDER"]
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestExtendData : TeaModel {
            /// <summary>
            /// 字段唯一标识
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 字段中文描述
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 字段的取值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 字段的类型(string,number,boolean)
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// 群配置
        /// </summary>
        [NameInMap("groupConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupConfig { get; set; }

        /// <summary>
        /// 群插件列表
        /// </summary>
        [NameInMap("groupPlugins")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestGroupPlugins> GroupPlugins { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestGroupPlugins : TeaModel {
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 群类型，枚举
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// 班组模型实例的唯一Id， 由业务方传递
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 班组长(支持多个)
        /// </summary>
        [NameInMap("leaders")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestLeaders> Leaders { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestLeaders : TeaModel {
            /// <summary>
            /// 工人姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 工人staffNo
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 班组成员(群成员)
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestMembers> Members { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestMembers : TeaModel {
            /// <summary>
            /// 工人姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 工人staffNo
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 班组群名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的工序
        /// </summary>
        [NameInMap("processIds")]
        [Validation(Required=false)]
        public List<string> ProcessIds { get; set; }

    }

}
