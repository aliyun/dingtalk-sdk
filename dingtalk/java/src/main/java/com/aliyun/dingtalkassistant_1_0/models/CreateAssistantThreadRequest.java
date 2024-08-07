// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantThreadRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("metadata")
    public java.util.Map<String, String> metadata;

    public static CreateAssistantThreadRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantThreadRequest self = new CreateAssistantThreadRequest();
        return TeaModel.build(map, self);
    }

    public CreateAssistantThreadRequest setMetadata(java.util.Map<String, String> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, String> getMetadata() {
        return this.metadata;
    }

}
