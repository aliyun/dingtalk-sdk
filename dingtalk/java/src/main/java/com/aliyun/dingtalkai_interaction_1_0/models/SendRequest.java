// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class SendRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contentType")
    public String contentType;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("unionId")
    public String unionId;

    public static SendRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRequest self = new SendRequest();
        return TeaModel.build(map, self);
    }

    public SendRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public SendRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
