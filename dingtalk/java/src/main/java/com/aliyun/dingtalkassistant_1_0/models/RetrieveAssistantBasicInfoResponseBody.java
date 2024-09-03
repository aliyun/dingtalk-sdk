// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantBasicInfoResponseBody extends TeaModel {
    @NameInMap("actionNames")
    public java.util.List<String> actionNames;

    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("assistantUnionId")
    public String assistantUnionId;

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

    public static RetrieveAssistantBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantBasicInfoResponseBody self = new RetrieveAssistantBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantBasicInfoResponseBody setActionNames(java.util.List<String> actionNames) {
        this.actionNames = actionNames;
        return this;
    }
    public java.util.List<String> getActionNames() {
        return this.actionNames;
    }

    public RetrieveAssistantBasicInfoResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public RetrieveAssistantBasicInfoResponseBody setAssistantUnionId(String assistantUnionId) {
        this.assistantUnionId = assistantUnionId;
        return this;
    }
    public String getAssistantUnionId() {
        return this.assistantUnionId;
    }

    public RetrieveAssistantBasicInfoResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public RetrieveAssistantBasicInfoResponseBody setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public RetrieveAssistantBasicInfoResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public RetrieveAssistantBasicInfoResponseBody setFallbackContent(String fallbackContent) {
        this.fallbackContent = fallbackContent;
        return this;
    }
    public String getFallbackContent() {
        return this.fallbackContent;
    }

    public RetrieveAssistantBasicInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public RetrieveAssistantBasicInfoResponseBody setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public RetrieveAssistantBasicInfoResponseBody setKnowledgeFileNames(java.util.List<String> knowledgeFileNames) {
        this.knowledgeFileNames = knowledgeFileNames;
        return this;
    }
    public java.util.List<String> getKnowledgeFileNames() {
        return this.knowledgeFileNames;
    }

    public RetrieveAssistantBasicInfoResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public RetrieveAssistantBasicInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public RetrieveAssistantBasicInfoResponseBody setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public RetrieveAssistantBasicInfoResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public RetrieveAssistantBasicInfoResponseBody setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

}
