// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddRobotToConversationResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("chatBotUserId")
    public String chatBotUserId;

    public static AddRobotToConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRobotToConversationResponseBody self = new AddRobotToConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRobotToConversationResponseBody setChatBotUserId(String chatBotUserId) {
        this.chatBotUserId = chatBotUserId;
        return this;
    }
    public String getChatBotUserId() {
        return this.chatBotUserId;
    }

}
