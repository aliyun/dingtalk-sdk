// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdRequest extends TeaModel {
    @NameInMap("chatId")
    public String chatId;

    public static GetConversationIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConversationIdRequest self = new GetConversationIdRequest();
        return TeaModel.build(map, self);
    }

    public GetConversationIdRequest setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

}
