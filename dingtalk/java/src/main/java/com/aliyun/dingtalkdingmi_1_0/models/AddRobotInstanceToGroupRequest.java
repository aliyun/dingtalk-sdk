// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AddRobotInstanceToGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd123</p>
     */
    @NameInMap("chatbotId")
    public String chatbotId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static AddRobotInstanceToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRobotInstanceToGroupRequest self = new AddRobotInstanceToGroupRequest();
        return TeaModel.build(map, self);
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
