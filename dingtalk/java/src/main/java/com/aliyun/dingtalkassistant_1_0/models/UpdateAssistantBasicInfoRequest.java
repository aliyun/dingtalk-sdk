// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class UpdateAssistantBasicInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("description")
    public String description;

    @NameInMap("fallbackContent")
    public String fallbackContent;

    @NameInMap("icon")
    public String icon;

    @NameInMap("instructions")
    public String instructions;

    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("recommendPrompts")
    public java.util.List<String> recommendPrompts;

    @NameInMap("welcomeContent")
    public String welcomeContent;

    public static UpdateAssistantBasicInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAssistantBasicInfoRequest self = new UpdateAssistantBasicInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAssistantBasicInfoRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public UpdateAssistantBasicInfoRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateAssistantBasicInfoRequest setFallbackContent(String fallbackContent) {
        this.fallbackContent = fallbackContent;
        return this;
    }
    public String getFallbackContent() {
        return this.fallbackContent;
    }

    public UpdateAssistantBasicInfoRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateAssistantBasicInfoRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public UpdateAssistantBasicInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateAssistantBasicInfoRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public UpdateAssistantBasicInfoRequest setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public UpdateAssistantBasicInfoRequest setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

}
