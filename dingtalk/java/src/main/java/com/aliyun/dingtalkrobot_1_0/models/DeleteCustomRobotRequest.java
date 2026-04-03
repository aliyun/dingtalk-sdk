// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class DeleteCustomRobotRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

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

    public static DeleteCustomRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCustomRobotRequest self = new DeleteCustomRobotRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCustomRobotRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public DeleteCustomRobotRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public DeleteCustomRobotRequest setSendNotification(Boolean sendNotification) {
        this.sendNotification = sendNotification;
        return this;
    }
    public Boolean getSendNotification() {
        return this.sendNotification;
    }

    public DeleteCustomRobotRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
