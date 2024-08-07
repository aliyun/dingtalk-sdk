// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantRunRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("instructions")
    public String instructions;

    @NameInMap("metadata")
    public java.util.Map<String, ?> metadata;

    @NameInMap("stream")
    public Boolean stream;

    public static CreateAssistantRunRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantRunRequest self = new CreateAssistantRunRequest();
        return TeaModel.build(map, self);
    }

    public CreateAssistantRunRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public CreateAssistantRunRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public CreateAssistantRunRequest setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public CreateAssistantRunRequest setStream(Boolean stream) {
        this.stream = stream;
        return this;
    }
    public Boolean getStream() {
        return this.stream;
    }

}
