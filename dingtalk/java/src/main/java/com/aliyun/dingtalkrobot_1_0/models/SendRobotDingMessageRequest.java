// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SendRobotDingMessageRequest extends TeaModel {
    @NameInMap("contentParams")
    public java.util.Map<String, String> contentParams;

    @NameInMap("dingTemplateId")
    public String dingTemplateId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    @NameInMap("robotCode")
    public String robotCode;

    public static SendRobotDingMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotDingMessageRequest self = new SendRobotDingMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotDingMessageRequest setContentParams(java.util.Map<String, String> contentParams) {
        this.contentParams = contentParams;
        return this;
    }
    public java.util.Map<String, String> getContentParams() {
        return this.contentParams;
    }

    public SendRobotDingMessageRequest setDingTemplateId(String dingTemplateId) {
        this.dingTemplateId = dingTemplateId;
        return this;
    }
    public String getDingTemplateId() {
        return this.dingTemplateId;
    }

    public SendRobotDingMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendRobotDingMessageRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public SendRobotDingMessageRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
