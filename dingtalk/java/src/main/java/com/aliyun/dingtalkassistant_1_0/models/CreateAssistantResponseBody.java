// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantResponseBody extends TeaModel {
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

    public static CreateAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantResponseBody self = new CreateAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAssistantResponseBody setActionNames(java.util.List<String> actionNames) {
        this.actionNames = actionNames;
        return this;
    }
    public java.util.List<String> getActionNames() {
        return this.actionNames;
    }

    public CreateAssistantResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public CreateAssistantResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public CreateAssistantResponseBody setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateAssistantResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateAssistantResponseBody setFallbackContent(String fallbackContent) {
        this.fallbackContent = fallbackContent;
        return this;
    }
    public String getFallbackContent() {
        return this.fallbackContent;
    }

    public CreateAssistantResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateAssistantResponseBody setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public CreateAssistantResponseBody setKnowledgeFileNames(java.util.List<String> knowledgeFileNames) {
        this.knowledgeFileNames = knowledgeFileNames;
        return this;
    }
    public java.util.List<String> getKnowledgeFileNames() {
        return this.knowledgeFileNames;
    }

    public CreateAssistantResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public CreateAssistantResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateAssistantResponseBody setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public CreateAssistantResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public CreateAssistantResponseBody setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

}
