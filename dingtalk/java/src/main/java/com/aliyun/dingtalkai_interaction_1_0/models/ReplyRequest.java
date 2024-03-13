// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class ReplyRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("contentType")
    public String contentType;

    @NameInMap("conversationToken")
    public String conversationToken;

    public static ReplyRequest build(java.util.Map<String, ?> map) throws Exception {
        ReplyRequest self = new ReplyRequest();
        return TeaModel.build(map, self);
    }

    public ReplyRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public ReplyRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public ReplyRequest setConversationToken(String conversationToken) {
        this.conversationToken = conversationToken;
        return this;
    }
    public String getConversationToken() {
        return this.conversationToken;
    }

}
