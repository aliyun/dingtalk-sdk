// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddRobotToConversationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>@lALPDe7s26Bre</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <strong>example:</strong>
     * <p>小加</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cid123cd</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
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
