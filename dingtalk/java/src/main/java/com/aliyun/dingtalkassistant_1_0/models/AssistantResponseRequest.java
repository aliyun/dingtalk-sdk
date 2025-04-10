// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantResponseRequest extends TeaModel {
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

    public static AssistantResponseRequest build(java.util.Map<String, ?> map) throws Exception {
        AssistantResponseRequest self = new AssistantResponseRequest();
        return TeaModel.build(map, self);
    }

    public AssistantResponseRequest setInput(String input) {
        this.input = input;
        return this;
    }
    public String getInput() {
        return this.input;
    }

    public AssistantResponseRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public AssistantResponseRequest setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public AssistantResponseRequest setStream(Boolean stream) {
        this.stream = stream;
        return this;
    }
    public Boolean getStream() {
        return this.stream;
    }

}
