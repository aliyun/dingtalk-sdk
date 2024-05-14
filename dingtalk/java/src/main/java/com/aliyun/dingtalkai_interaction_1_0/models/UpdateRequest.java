// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class UpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contentType")
    public String contentType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationToken")
    public String conversationToken;

    public static UpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRequest self = new UpdateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UpdateRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public UpdateRequest setConversationToken(String conversationToken) {
        this.conversationToken = conversationToken;
        return this;
    }
    public String getConversationToken() {
        return this.conversationToken;
    }

}
