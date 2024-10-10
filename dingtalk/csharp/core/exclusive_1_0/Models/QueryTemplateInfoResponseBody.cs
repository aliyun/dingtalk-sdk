// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryTemplateInfoResponseBody : TeaModel {
        [NameInMap("abilitySwitch")]
        [Validation(Required=false)]
        public long? AbilitySwitch { get; set; }

        [NameInMap("appInfo")]
        [Validation(Required=false)]
        public QueryTemplateInfoResponseBodyAppInfo AppInfo { get; set; }
        public class QueryTemplateInfoResponseBodyAppInfo : TeaModel {
            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

        }

        [NameInMap("conversationScope")]
        [Validation(Required=false)]
        public List<string> ConversationScope { get; set; }

        [NameInMap("createAt")]
        [Validation(Required=false)]
        public long? CreateAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("grayConversationIds")]
        [Validation(Required=false)]
        public List<string> GrayConversationIds { get; set; }

        [NameInMap("grayInfo")]
        [Validation(Required=false)]
        public QueryTemplateInfoResponseBodyGrayInfo GrayInfo { get; set; }
        public class QueryTemplateInfoResponseBodyGrayInfo : TeaModel {
            [NameInMap("tenThousandPercent")]
            [Validation(Required=false)]
            public int? TenThousandPercent { get; set; }

            [NameInMap("whiteSet")]
            [Validation(Required=false)]
            public List<string> WhiteSet { get; set; }

        }

        [NameInMap("grayTemplateId")]
        [Validation(Required=false)]
        public string GrayTemplateId { get; set; }

        [NameInMap("groupSettingList")]
        [Validation(Required=false)]
        public List<QueryTemplateInfoResponseBodyGroupSettingList> GroupSettingList { get; set; }
        public class QueryTemplateInfoResponseBodyGroupSettingList : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public bool? State { get; set; }

        }

        [NameInMap("iconMediaId")]
        [Validation(Required=false)]
        public string IconMediaId { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        [NameInMap("modifyOrderId")]
        [Validation(Required=false)]
        public long? ModifyOrderId { get; set; }

        [NameInMap("modifyStatus")]
        [Validation(Required=false)]
        public long? ModifyStatus { get; set; }

        [NameInMap("parentTemplateDetailVO")]
        [Validation(Required=false)]
        public QueryTemplateInfoResponseBodyParentTemplateDetailVO ParentTemplateDetailVO { get; set; }
        public class QueryTemplateInfoResponseBodyParentTemplateDetailVO : TeaModel {
            [NameInMap("robotTemplateList")]
            [Validation(Required=false)]
            public List<QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList> RobotTemplateList { get; set; }
            public class QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList : TeaModel {
                [NameInMap("brief")]
                [Validation(Required=false)]
                public string Brief { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("createAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("dev")]
                [Validation(Required=false)]
                public string Dev { get; set; }

                [NameInMap("groupTemplateId")]
                [Validation(Required=false)]
                public string GroupTemplateId { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("modifiedAt")]
                [Validation(Required=false)]
                public long? ModifiedAt { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outgoingToken")]
                [Validation(Required=false)]
                public string OutgoingToken { get; set; }

                [NameInMap("outgoingUrl")]
                [Validation(Required=false)]
                public string OutgoingUrl { get; set; }

                [NameInMap("previewMediaId")]
                [Validation(Required=false)]
                public string PreviewMediaId { get; set; }

                [NameInMap("sourceUrl")]
                [Validation(Required=false)]
                public string SourceUrl { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("toolbarPluginList")]
            [Validation(Required=false)]
            public List<QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList> ToolbarPluginList { get; set; }
            public class QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList : TeaModel {
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("createAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("icons")]
                [Validation(Required=false)]
                public string Icons { get; set; }

                [NameInMap("modifiedAt")]
                [Validation(Required=false)]
                public long? ModifiedAt { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("publishSubState")]
        [Validation(Required=false)]
        public string PublishSubState { get; set; }

        [NameInMap("robotTemplateList")]
        [Validation(Required=false)]
        public List<string> RobotTemplateList { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("templateIntroduction")]
        [Validation(Required=false)]
        public QueryTemplateInfoResponseBodyTemplateIntroduction TemplateIntroduction { get; set; }
        public class QueryTemplateInfoResponseBodyTemplateIntroduction : TeaModel {
            [NameInMap("banner")]
            [Validation(Required=false)]
            public string Banner { get; set; }

            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("templateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

        [NameInMap("templateVisibility")]
        [Validation(Required=false)]
        public QueryTemplateInfoResponseBodyTemplateVisibility TemplateVisibility { get; set; }
        public class QueryTemplateInfoResponseBodyTemplateVisibility : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds> DeptIds { get; set; }
            public class QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

            }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<QueryTemplateInfoResponseBodyTemplateVisibilityUserIds> UserIds { get; set; }
            public class QueryTemplateInfoResponseBodyTemplateVisibilityUserIds : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("toolbarPluginList")]
        [Validation(Required=false)]
        public List<string> ToolbarPluginList { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
