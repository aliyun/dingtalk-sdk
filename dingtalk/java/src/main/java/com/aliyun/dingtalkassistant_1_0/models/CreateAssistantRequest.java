// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantRequest extends TeaModel {
    @NameInMap("customAgentMobileLink")
    public String customAgentMobileLink;

    @NameInMap("customAgentPCLink")
    public String customAgentPCLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instructions")
    public String instructions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("recommendPrompts")
    public java.util.List<String> recommendPrompts;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("welcomeContent")
    public String welcomeContent;

    public static CreateAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantRequest self = new CreateAssistantRequest();
        return TeaModel.build(map, self);
    }

    public CreateAssistantRequest setCustomAgentMobileLink(String customAgentMobileLink) {
        this.customAgentMobileLink = customAgentMobileLink;
        return this;
    }
    public String getCustomAgentMobileLink() {
        return this.customAgentMobileLink;
    }

    public CreateAssistantRequest setCustomAgentPCLink(String customAgentPCLink) {
        this.customAgentPCLink = customAgentPCLink;
        return this;
    }
    public String getCustomAgentPCLink() {
        return this.customAgentPCLink;
    }

    public CreateAssistantRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateAssistantRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateAssistantRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public CreateAssistantRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateAssistantRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public CreateAssistantRequest setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public CreateAssistantRequest setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

}
