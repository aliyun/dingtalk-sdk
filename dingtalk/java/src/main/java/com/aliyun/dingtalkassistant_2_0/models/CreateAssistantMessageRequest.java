// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class CreateAssistantMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

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

    public CreateAssistantMessageRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

}
