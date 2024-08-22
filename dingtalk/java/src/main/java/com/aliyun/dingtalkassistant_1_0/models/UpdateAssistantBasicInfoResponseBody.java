// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class UpdateAssistantBasicInfoResponseBody extends TeaModel {
    @NameInMap("actionNames")
    public java.util.List<String> actionNames;

    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("createdAt")
    public Long createdAt;

    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("description")
    public String description;

    @NameInMap("fallbackContent")
    public String fallbackContent;

    @NameInMap("icon")
    public String icon;

    @NameInMap("instructions")
    public String instructions;

    @NameInMap("knowledgeFileNames")
    public java.util.List<String> knowledgeFileNames;

    @NameInMap("model")
    public String model;

    @NameInMap("name")
    public String name;

    @NameInMap("recommendPrompts")
    public java.util.List<String> recommendPrompts;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("welcomeContent")
    public String welcomeContent;

    public static UpdateAssistantBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateAssistantBasicInfoResponseBody self = new UpdateAssistantBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateAssistantBasicInfoResponseBody setActionNames(java.util.List<String> actionNames) {
        this.actionNames = actionNames;
        return this;
    }
    public java.util.List<String> getActionNames() {
        return this.actionNames;
    }

    public UpdateAssistantBasicInfoResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public UpdateAssistantBasicInfoResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public UpdateAssistantBasicInfoResponseBody setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public UpdateAssistantBasicInfoResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateAssistantBasicInfoResponseBody setFallbackContent(String fallbackContent) {
        this.fallbackContent = fallbackContent;
        return this;
    }
    public String getFallbackContent() {
        return this.fallbackContent;
    }

    public UpdateAssistantBasicInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateAssistantBasicInfoResponseBody setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public UpdateAssistantBasicInfoResponseBody setKnowledgeFileNames(java.util.List<String> knowledgeFileNames) {
        this.knowledgeFileNames = knowledgeFileNames;
        return this;
    }
    public java.util.List<String> getKnowledgeFileNames() {
        return this.knowledgeFileNames;
    }

    public UpdateAssistantBasicInfoResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public UpdateAssistantBasicInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateAssistantBasicInfoResponseBody setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public UpdateAssistantBasicInfoResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public UpdateAssistantBasicInfoResponseBody setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

}
