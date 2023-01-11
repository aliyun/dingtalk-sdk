// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOTORequest extends TeaModel {
    /**
     * <p>消息的msgKey</p>
     */
    @NameInMap("msgKey")
    public String msgKey;

    /**
     * <p>消息体</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <p>机器人的robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>被推送会话人员的userId列表</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static BatchSendOTORequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOTORequest self = new BatchSendOTORequest();
        return TeaModel.build(map, self);
    }

    public BatchSendOTORequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public BatchSendOTORequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public BatchSendOTORequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public BatchSendOTORequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
