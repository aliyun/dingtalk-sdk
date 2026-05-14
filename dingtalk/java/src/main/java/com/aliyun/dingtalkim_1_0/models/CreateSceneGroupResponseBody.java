// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>chatxxxxxx</p>
     */
    @NameInMap("chat_id")
    public String chatId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxxx==</p>
     */
    @NameInMap("open_conversation_id")
    public String openConversationId;

    public static CreateSceneGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupResponseBody self = new CreateSceneGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupResponseBody setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

    public CreateSceneGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
