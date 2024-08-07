// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantThreadResponseBody extends TeaModel {
    @NameInMap("createdAt")
    public Long createdAt;

    @NameInMap("id")
    public String id;

    @NameInMap("metadata")
    public java.util.Map<String, ?> metadata;

    @NameInMap("object")
    public String object;

    public static CreateAssistantThreadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantThreadResponseBody self = new CreateAssistantThreadResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAssistantThreadResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public CreateAssistantThreadResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateAssistantThreadResponseBody setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public CreateAssistantThreadResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

}
