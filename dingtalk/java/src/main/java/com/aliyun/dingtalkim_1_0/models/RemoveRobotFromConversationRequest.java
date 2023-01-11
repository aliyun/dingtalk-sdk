// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveRobotFromConversationRequest extends TeaModel {
    /**
     * <p>机器人在会话里的id</p>
     */
    @NameInMap("chatBotUserId")
    public String chatBotUserId;

    /**
     * <p>会话id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static RemoveRobotFromConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveRobotFromConversationRequest self = new RemoveRobotFromConversationRequest();
        return TeaModel.build(map, self);
    }

    public RemoveRobotFromConversationRequest setChatBotUserId(String chatBotUserId) {
        this.chatBotUserId = chatBotUserId;
        return this;
    }
    public String getChatBotUserId() {
        return this.chatBotUserId;
    }

    public RemoveRobotFromConversationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
