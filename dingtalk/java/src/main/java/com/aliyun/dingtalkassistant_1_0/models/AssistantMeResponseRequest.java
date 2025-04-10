// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantMeResponseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("input")
    public String input;

    @NameInMap("instructions")
    public String instructions;

    @NameInMap("metadata")
    public java.util.Map<String, ?> metadata;

    @NameInMap("stream")
    public Boolean stream;

    public static AssistantMeResponseRequest build(java.util.Map<String, ?> map) throws Exception {
        AssistantMeResponseRequest self = new AssistantMeResponseRequest();
        return TeaModel.build(map, self);
    }

    public AssistantMeResponseRequest setInput(String input) {
        this.input = input;
        return this;
    }
    public String getInput() {
        return this.input;
    }

    public AssistantMeResponseRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public AssistantMeResponseRequest setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public AssistantMeResponseRequest setStream(Boolean stream) {
        this.stream = stream;
        return this;
    }
    public Boolean getStream() {
        return this.stream;
    }

}
