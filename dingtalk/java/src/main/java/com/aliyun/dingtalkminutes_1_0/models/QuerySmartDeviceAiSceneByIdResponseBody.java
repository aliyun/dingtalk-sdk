// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSceneByIdResponseBody extends TeaModel {
    @NameInMap("agent")
    public QuerySmartDeviceAiSceneByIdResponseBodyAgent agent;

    public static QuerySmartDeviceAiSceneByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSceneByIdResponseBody self = new QuerySmartDeviceAiSceneByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSceneByIdResponseBody setAgent(QuerySmartDeviceAiSceneByIdResponseBodyAgent agent) {
        this.agent = agent;
        return this;
    }
    public QuerySmartDeviceAiSceneByIdResponseBodyAgent getAgent() {
        return this.agent;
    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList extends TeaModel {
        @NameInMap("devServId")
        public Integer devServId;

        @NameInMap("deviceId")
        public Long deviceId;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("sn")
        public String sn;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList setDevServId(Integer devServId) {
            this.devServId = devServId;
            return this;
        }
        public Integer getDevServId() {
            return this.devServId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList setDeviceId(Long deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public Long getDeviceId() {
            return this.deviceId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene extends TeaModel {
        @NameInMap("isvAppId")
        public String isvAppId;

        @NameInMap("isvAppState")
        public Integer isvAppState;

        @NameInMap("isvCorpId")
        public String isvCorpId;

        @NameInMap("isvType")
        public Integer isvType;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene setIsvAppId(String isvAppId) {
            this.isvAppId = isvAppId;
            return this;
        }
        public String getIsvAppId() {
            return this.isvAppId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene setIsvAppState(Integer isvAppState) {
            this.isvAppState = isvAppState;
            return this;
        }
        public Integer getIsvAppState() {
            return this.isvAppState;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene setIsvCorpId(String isvCorpId) {
            this.isvCorpId = isvCorpId;
            return this;
        }
        public String getIsvCorpId() {
            return this.isvCorpId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene setIsvType(Integer isvType) {
            this.isvType = isvType;
            return this;
        }
        public Integer getIsvType() {
            return this.isvType;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel extends TeaModel {
        @NameInMap("modelId")
        public String modelId;

        @NameInMap("modelName")
        public String modelName;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel setModelName(String modelName) {
            this.modelName = modelName;
            return this;
        }
        public String getModelName() {
            return this.modelName;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates extends TeaModel {
        @NameInMap("category")
        public String category;

        @NameInMap("description")
        public String description;

        @NameInMap("iconUrl")
        public String iconUrl;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("title")
        public String title;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList extends TeaModel {
        @NameInMap("projectId")
        public String projectId;

        @NameInMap("projectName")
        public String projectName;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig extends TeaModel {
        @NameInMap("agentPromptTemplateIds")
        public java.util.List<String> agentPromptTemplateIds;

        @NameInMap("collabSheetName")
        public String collabSheetName;

        @NameInMap("collabSheetUrl")
        public String collabSheetUrl;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("sheetId")
        public String sheetId;

        @NameInMap("syncCollabSheet")
        public Boolean syncCollabSheet;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setAgentPromptTemplateIds(java.util.List<String> agentPromptTemplateIds) {
            this.agentPromptTemplateIds = agentPromptTemplateIds;
            return this;
        }
        public java.util.List<String> getAgentPromptTemplateIds() {
            return this.agentPromptTemplateIds;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setCollabSheetName(String collabSheetName) {
            this.collabSheetName = collabSheetName;
            return this;
        }
        public String getCollabSheetName() {
            return this.collabSheetName;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setCollabSheetUrl(String collabSheetUrl) {
            this.collabSheetUrl = collabSheetUrl;
            return this;
        }
        public String getCollabSheetUrl() {
            return this.collabSheetUrl;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setSheetId(String sheetId) {
            this.sheetId = sheetId;
            return this;
        }
        public String getSheetId() {
            return this.sheetId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig setSyncCollabSheet(Boolean syncCollabSheet) {
            this.syncCollabSheet = syncCollabSheet;
            return this;
        }
        public Boolean getSyncCollabSheet() {
            return this.syncCollabSheet;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("isvSystemKey")
        public String isvSystemKey;

        @NameInMap("state")
        public String state;

        @NameInMap("title")
        public String title;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs setIsvSystemKey(String isvSystemKey) {
            this.isvSystemKey = isvSystemKey;
            return this;
        }
        public String getIsvSystemKey() {
            return this.isvSystemKey;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig extends TeaModel {
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("formName")
        public String formName;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("syncYida")
        public Boolean syncYida;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig self = new QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig setSyncYida(Boolean syncYida) {
            this.syncYida = syncYida;
            return this;
        }
        public Boolean getSyncYida() {
            return this.syncYida;
        }

    }

    public static class QuerySmartDeviceAiSceneByIdResponseBodyAgent extends TeaModel {
        @NameInMap("agentId")
        public String agentId;

        @NameInMap("agentInstanceId")
        public String agentInstanceId;

        @NameInMap("agentName")
        public String agentName;

        @NameInMap("allFileGroups")
        public Boolean allFileGroups;

        @NameInMap("attributes")
        public java.util.Map<String, ?> attributes;

        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("belongingId")
        public String belongingId;

        @NameInMap("belongingType")
        public Integer belongingType;

        @NameInMap("country")
        public String country;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("description")
        public String description;

        @NameInMap("deviceList")
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList> deviceList;

        @NameInMap("isvAiScene")
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene isvAiScene;

        @NameInMap("keywords")
        public java.util.List<String> keywords;

        @NameInMap("llmModel")
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel llmModel;

        @NameInMap("mail")
        public String mail;

        @NameInMap("mailOption")
        public String mailOption;

        @NameInMap("minutesTemplates")
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates> minutesTemplates;

        @NameInMap("projectList")
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList> projectList;

        @NameInMap("prompt")
        public String prompt;

        @NameInMap("promptTemplateIds")
        public java.util.List<String> promptTemplateIds;

        @NameInMap("state")
        public Integer state;

        @NameInMap("syncCollabSheetConfig")
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig syncCollabSheetConfig;

        @NameInMap("syncIsvSystemConfigs")
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs> syncIsvSystemConfigs;

        @NameInMap("syncYidaConfig")
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig syncYidaConfig;

        public static QuerySmartDeviceAiSceneByIdResponseBodyAgent build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSceneByIdResponseBodyAgent self = new QuerySmartDeviceAiSceneByIdResponseBodyAgent();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAgentId(String agentId) {
            this.agentId = agentId;
            return this;
        }
        public String getAgentId() {
            return this.agentId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAgentInstanceId(String agentInstanceId) {
            this.agentInstanceId = agentInstanceId;
            return this;
        }
        public String getAgentInstanceId() {
            return this.agentInstanceId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAgentName(String agentName) {
            this.agentName = agentName;
            return this;
        }
        public String getAgentName() {
            return this.agentName;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAllFileGroups(Boolean allFileGroups) {
            this.allFileGroups = allFileGroups;
            return this;
        }
        public Boolean getAllFileGroups() {
            return this.allFileGroups;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAttributes(java.util.Map<String, ?> attributes) {
            this.attributes = attributes;
            return this;
        }
        public java.util.Map<String, ?> getAttributes() {
            return this.attributes;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setBelongingId(String belongingId) {
            this.belongingId = belongingId;
            return this;
        }
        public String getBelongingId() {
            return this.belongingId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setBelongingType(Integer belongingType) {
            this.belongingType = belongingType;
            return this;
        }
        public Integer getBelongingType() {
            return this.belongingType;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setCountry(String country) {
            this.country = country;
            return this;
        }
        public String getCountry() {
            return this.country;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setDeviceList(java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList> deviceList) {
            this.deviceList = deviceList;
            return this;
        }
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentDeviceList> getDeviceList() {
            return this.deviceList;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setIsvAiScene(QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene isvAiScene) {
            this.isvAiScene = isvAiScene;
            return this;
        }
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentIsvAiScene getIsvAiScene() {
            return this.isvAiScene;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setKeywords(java.util.List<String> keywords) {
            this.keywords = keywords;
            return this;
        }
        public java.util.List<String> getKeywords() {
            return this.keywords;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setLlmModel(QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel llmModel) {
            this.llmModel = llmModel;
            return this;
        }
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentLlmModel getLlmModel() {
            return this.llmModel;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setMail(String mail) {
            this.mail = mail;
            return this;
        }
        public String getMail() {
            return this.mail;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setMailOption(String mailOption) {
            this.mailOption = mailOption;
            return this;
        }
        public String getMailOption() {
            return this.mailOption;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setMinutesTemplates(java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates> minutesTemplates) {
            this.minutesTemplates = minutesTemplates;
            return this;
        }
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentMinutesTemplates> getMinutesTemplates() {
            return this.minutesTemplates;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setProjectList(java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList> projectList) {
            this.projectList = projectList;
            return this;
        }
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentProjectList> getProjectList() {
            return this.projectList;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setPrompt(String prompt) {
            this.prompt = prompt;
            return this;
        }
        public String getPrompt() {
            return this.prompt;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setPromptTemplateIds(java.util.List<String> promptTemplateIds) {
            this.promptTemplateIds = promptTemplateIds;
            return this;
        }
        public java.util.List<String> getPromptTemplateIds() {
            return this.promptTemplateIds;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setState(Integer state) {
            this.state = state;
            return this;
        }
        public Integer getState() {
            return this.state;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setSyncCollabSheetConfig(QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig syncCollabSheetConfig) {
            this.syncCollabSheetConfig = syncCollabSheetConfig;
            return this;
        }
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncCollabSheetConfig getSyncCollabSheetConfig() {
            return this.syncCollabSheetConfig;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setSyncIsvSystemConfigs(java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs> syncIsvSystemConfigs) {
            this.syncIsvSystemConfigs = syncIsvSystemConfigs;
            return this;
        }
        public java.util.List<QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncIsvSystemConfigs> getSyncIsvSystemConfigs() {
            return this.syncIsvSystemConfigs;
        }

        public QuerySmartDeviceAiSceneByIdResponseBodyAgent setSyncYidaConfig(QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig syncYidaConfig) {
            this.syncYidaConfig = syncYidaConfig;
            return this;
        }
        public QuerySmartDeviceAiSceneByIdResponseBodyAgentSyncYidaConfig getSyncYidaConfig() {
            return this.syncYidaConfig;
        }

    }

}
