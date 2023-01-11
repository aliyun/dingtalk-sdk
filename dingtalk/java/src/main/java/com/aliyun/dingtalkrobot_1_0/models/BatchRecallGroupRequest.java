// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallGroupRequest extends TeaModel {
    /**
     * <p>机器人的robotCode</p>
     */
    @NameInMap("chatbotId")
    public String chatbotId;

    /**
     * <p>开放的群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>消息id</p>
     */
    @NameInMap("processQueryKeys")
    public java.util.List<String> processQueryKeys;

    public static BatchRecallGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallGroupRequest self = new BatchRecallGroupRequest();
        return TeaModel.build(map, self);
    }

    public BatchRecallGroupRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public BatchRecallGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public BatchRecallGroupRequest setProcessQueryKeys(java.util.List<String> processQueryKeys) {
        this.processQueryKeys = processQueryKeys;
        return this;
    }
    public java.util.List<String> getProcessQueryKeys() {
        return this.processQueryKeys;
    }

}
