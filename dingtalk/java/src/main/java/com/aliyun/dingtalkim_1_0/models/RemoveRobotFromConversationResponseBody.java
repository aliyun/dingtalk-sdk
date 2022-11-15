// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveRobotFromConversationResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("chatBotUserId")
    public String chatBotUserId;

    public static RemoveRobotFromConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveRobotFromConversationResponseBody self = new RemoveRobotFromConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveRobotFromConversationResponseBody setChatBotUserId(String chatBotUserId) {
        this.chatBotUserId = chatBotUserId;
        return this;
    }
    public String getChatBotUserId() {
        return this.chatBotUserId;
    }

}
