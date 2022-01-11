// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOTORequest extends TeaModel {
    // 消息的msgKey
    @NameInMap("msgKey")
    public String msgKey;

    // 消息体
    @NameInMap("msgParam")
    public String msgParam;

    // 机器人的robotCode
    @NameInMap("robotCode")
    public String robotCode;

    // 被推送会话人员的userId列表
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
