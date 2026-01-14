// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantThreadResponseBody extends TeaModel {
    @NameInMap("createdAt")
    public Long createdAt;

    @NameInMap("id")
    public String id;

    @NameInMap("object")
    public String object;

    public static RetrieveAssistantThreadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantThreadResponseBody self = new RetrieveAssistantThreadResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantThreadResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public RetrieveAssistantThreadResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public RetrieveAssistantThreadResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

}
