// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QuerySmartDeviceAiSceneByIdResponseBody : TeaModel {
        [NameInMap("agent")]
        [Validation(Required=false)]
        public QuerySmartDeviceAiSceneByIdResponseBodyAgent Agent { get; set; }
        public class QuerySmartDeviceAiSceneByIdResponseBodyAgent : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("agentInstanceId")]
            [Validation(Required=false)]
            public string AgentInstanceId { get; set; }

            [NameInMap("agentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("allFileGroups")]
            [Validation(Required=false)]
            public bool? AllFileGroups { get; set; }

            [NameInMap("attributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> Attributes { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("belongingId")]
            [Validation(Required=false)]
            public string BelongingId { get; set; }

            [NameInMap("belongingType")]
            [Validation(Required=false)]
            public int? BelongingType { get; set; }

            [NameInMap("country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("deviceList")]
            [Validation(Required=false)]
            public List<QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList> DeviceList { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList : TeaModel {
                [NameInMap("devServId")]
                [Validation(Required=false)]
                public int? DevServId { get; set; }

                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public long? DeviceId { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

            [NameInMap("isvAiScene")]
            [Validation(Required=false)]
            public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene IsvAiScene { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene : TeaModel {
                [NameInMap("isvAppId")]
                [Validation(Required=false)]
                public string IsvAppId { get; set; }

                [NameInMap("isvAppState")]
                [Validation(Required=false)]
                public int? IsvAppState { get; set; }

                [NameInMap("isvCorpId")]
                [Validation(Required=false)]
                public string IsvCorpId { get; set; }

                [NameInMap("isvType")]
                [Validation(Required=false)]
                public int? IsvType { get; set; }

            }

            [NameInMap("keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("llmModel")]
            [Validation(Required=false)]
            public QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel LlmModel { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel : TeaModel {
                [NameInMap("modelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            [NameInMap("mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            [NameInMap("mailOption")]
            [Validation(Required=false)]
            public string MailOption { get; set; }

            [NameInMap("minutesTemplates")]
            [Validation(Required=false)]
            public List<QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates> MinutesTemplates { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates : TeaModel {
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                [NameInMap("templateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("projectList")]
            [Validation(Required=false)]
            public List<QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList> ProjectList { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList : TeaModel {
                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("promptTemplateIds")]
            [Validation(Required=false)]
            public List<string> PromptTemplateIds { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("syncCollabSheetConfig")]
            [Validation(Required=false)]
            public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig SyncCollabSheetConfig { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig : TeaModel {
                [NameInMap("agentPromptTemplateIds")]
                [Validation(Required=false)]
                public List<string> AgentPromptTemplateIds { get; set; }

                [NameInMap("collabSheetName")]
                [Validation(Required=false)]
                public string CollabSheetName { get; set; }

                [NameInMap("collabSheetUrl")]
                [Validation(Required=false)]
                public string CollabSheetUrl { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("sheetId")]
                [Validation(Required=false)]
                public string SheetId { get; set; }

                [NameInMap("syncCollabSheet")]
                [Validation(Required=false)]
                public bool? SyncCollabSheet { get; set; }

            }

            [NameInMap("syncIsvSystemConfigs")]
            [Validation(Required=false)]
            public List<QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs> SyncIsvSystemConfigs { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("isvSystemKey")]
                [Validation(Required=false)]
                public string IsvSystemKey { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("syncYidaConfig")]
            [Validation(Required=false)]
            public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig SyncYidaConfig { get; set; }
            public class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig : TeaModel {
                [NameInMap("appCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                [NameInMap("formUuid")]
                [Validation(Required=false)]
                public string FormUuid { get; set; }

                [NameInMap("syncYida")]
                [Validation(Required=false)]
                public bool? SyncYida { get; set; }

            }

        }

    }

}
