// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SendRobotDingMessageRequest extends TeaModel {
    // 模版对应的参数
    @NameInMap("contentParams")
    public java.util.Map<String, String> contentParams;

    // 颁发的模版id，可通过宜搭申请：https://yida.alibaba-inc.com/alibaba/web/APP_NSUGAGIQUMI4ESRA7O7D/inst/homepage/#/FORM-WO866371VGXSECXX4M0NC9KSGAT92VSA3TZSK9B
    @NameInMap("dingTemplateId")
    public String dingTemplateId;

    // 群聊的对外开放Id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 接受人的userId列表
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    // 机器人的Id
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
