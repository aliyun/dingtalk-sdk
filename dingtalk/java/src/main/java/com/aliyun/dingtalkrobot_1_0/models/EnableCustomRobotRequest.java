// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class EnableCustomRobotRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>enable</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sendNotification")
    public Boolean sendNotification;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    public static EnableCustomRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        EnableCustomRobotRequest self = new EnableCustomRobotRequest();
        return TeaModel.build(map, self);
    }

    public EnableCustomRobotRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public EnableCustomRobotRequest setSendNotification(Boolean sendNotification) {
        this.sendNotification = sendNotification;
        return this;
    }
    public Boolean getSendNotification() {
        return this.sendNotification;
    }

    public EnableCustomRobotRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
