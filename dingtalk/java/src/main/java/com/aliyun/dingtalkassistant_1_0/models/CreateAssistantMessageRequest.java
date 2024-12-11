// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    @NameInMap("metadata")
    public java.util.Map<String, ?> metadata;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("role")
    public String role;

    public static CreateAssistantMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantMessageRequest self = new CreateAssistantMessageRequest();
        return TeaModel.build(map, self);
    }

    public CreateAssistantMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateAssistantMessageRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public CreateAssistantMessageRequest setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public CreateAssistantMessageRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

}
