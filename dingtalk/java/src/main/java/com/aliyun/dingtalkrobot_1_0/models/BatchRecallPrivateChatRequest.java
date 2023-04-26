// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallPrivateChatRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("processQueryKeys")
    public java.util.List<String> processQueryKeys;

    @NameInMap("robotCode")
    public String robotCode;

    public static BatchRecallPrivateChatRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallPrivateChatRequest self = new BatchRecallPrivateChatRequest();
        return TeaModel.build(map, self);
    }

    public BatchRecallPrivateChatRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public BatchRecallPrivateChatRequest setProcessQueryKeys(java.util.List<String> processQueryKeys) {
        this.processQueryKeys = processQueryKeys;
        return this;
    }
    public java.util.List<String> getProcessQueryKeys() {
        return this.processQueryKeys;
    }

    public BatchRecallPrivateChatRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
