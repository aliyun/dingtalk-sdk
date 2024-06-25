// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatIdToOpenConversationIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidl1B8RVUFmkO50OC9uEbySQ==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static ChatIdToOpenConversationIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatIdToOpenConversationIdResponseBody self = new ChatIdToOpenConversationIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatIdToOpenConversationIdResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
