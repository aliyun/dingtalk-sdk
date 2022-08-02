// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationResponseBody extends TeaModel {
    // 群chatId。
    @NameInMap("chatId")
    public String chatId;

    // 群会话Id。
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CreateCoupleGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupConversationResponseBody self = new CreateCoupleGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupConversationResponseBody setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

    public CreateCoupleGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
