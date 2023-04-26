// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageRequest extends TeaModel {
    @NameInMap("atAll")
    public Boolean atAll;

    @NameInMap("atAppUserId")
    public String atAppUserId;

    @NameInMap("atDingUserId")
    public String atDingUserId;

    @NameInMap("msgContent")
    public String msgContent;

    @NameInMap("msgType")
    public String msgType;

    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    @NameInMap("robotCode")
    public String robotCode;

    public static SendRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageRequest self = new SendRobotMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotMessageRequest setAtAll(Boolean atAll) {
        this.atAll = atAll;
        return this;
    }
    public Boolean getAtAll() {
        return this.atAll;
    }

    public SendRobotMessageRequest setAtAppUserId(String atAppUserId) {
        this.atAppUserId = atAppUserId;
        return this;
    }
    public String getAtAppUserId() {
        return this.atAppUserId;
    }

    public SendRobotMessageRequest setAtDingUserId(String atDingUserId) {
        this.atDingUserId = atDingUserId;
        return this;
    }
    public String getAtDingUserId() {
        return this.atDingUserId;
    }

    public SendRobotMessageRequest setMsgContent(String msgContent) {
        this.msgContent = msgContent;
        return this;
    }
    public String getMsgContent() {
        return this.msgContent;
    }

    public SendRobotMessageRequest setMsgType(String msgType) {
        this.msgType = msgType;
        return this;
    }
    public String getMsgType() {
        return this.msgType;
    }

    public SendRobotMessageRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

    public SendRobotMessageRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
