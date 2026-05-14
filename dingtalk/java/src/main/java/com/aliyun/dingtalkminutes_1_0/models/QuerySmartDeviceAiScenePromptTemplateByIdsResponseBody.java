// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody extends TeaModel {
    @NameInMap("agentPromptTemplates")
    public java.util.List<QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates> agentPromptTemplates;

    public static QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody self = new QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody setAgentPromptTemplates(java.util.List<QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates> agentPromptTemplates) {
        this.agentPromptTemplates = agentPromptTemplates;
        return this;
    }
    public java.util.List<QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates> getAgentPromptTemplates() {
        return this.agentPromptTemplates;
    }

    public static class QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates extends TeaModel {
        @NameInMap("agentPromptTemplateId")
        public String agentPromptTemplateId;

        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("belongingId")
        public String belongingId;

        @NameInMap("belongingType")
        public String belongingType;

        @NameInMap("category")
        public String category;

        @NameInMap("country")
        public String country;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("description")
        public String description;

        @NameInMap("order")
        public String order;

        @NameInMap("prompt")
        public String prompt;

        @NameInMap("title")
        public String title;

        public static QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates self = new QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setAgentPromptTemplateId(String agentPromptTemplateId) {
            this.agentPromptTemplateId = agentPromptTemplateId;
            return this;
        }
        public String getAgentPromptTemplateId() {
            return this.agentPromptTemplateId;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setBelongingId(String belongingId) {
            this.belongingId = belongingId;
            return this;
        }
        public String getBelongingId() {
            return this.belongingId;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setBelongingType(String belongingType) {
            this.belongingType = belongingType;
            return this;
        }
        public String getBelongingType() {
            return this.belongingType;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setCountry(String country) {
            this.country = country;
            return this;
        }
        public String getCountry() {
            return this.country;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setOrder(String order) {
            this.order = order;
            return this;
        }
        public String getOrder() {
            return this.order;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setPrompt(String prompt) {
            this.prompt = prompt;
            return this;
        }
        public String getPrompt() {
            return this.prompt;
        }

        public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
