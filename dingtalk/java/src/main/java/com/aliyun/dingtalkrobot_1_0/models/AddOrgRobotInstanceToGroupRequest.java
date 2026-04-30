// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRobotInstanceToGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static AddOrgRobotInstanceToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRobotInstanceToGroupRequest self = new AddOrgRobotInstanceToGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgRobotInstanceToGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddOrgRobotInstanceToGroupRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
