// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddRobotToConversationRequest extends TeaModel {
    // 机器人meidaId
    @NameInMap("icon")
    public String icon;

    // 机器人名称
    @NameInMap("name")
    public String name;

    // 会话id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 机器人编码
    @NameInMap("robotCode")
    public String robotCode;

    public static AddRobotToConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRobotToConversationRequest self = new AddRobotToConversationRequest();
        return TeaModel.build(map, self);
    }

    public AddRobotToConversationRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public AddRobotToConversationRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddRobotToConversationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddRobotToConversationRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
