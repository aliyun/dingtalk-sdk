// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AddRobotInstanceToGroupRequest extends TeaModel {
    // 企业id
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 机器人id
    @NameInMap("chatbotId")
    public String chatbotId;

    // 对话id
    @NameInMap("openConversationId")
    public String openConversationId;

    public static AddRobotInstanceToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRobotInstanceToGroupRequest self = new AddRobotInstanceToGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddRobotInstanceToGroupRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public AddRobotInstanceToGroupRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public AddRobotInstanceToGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
