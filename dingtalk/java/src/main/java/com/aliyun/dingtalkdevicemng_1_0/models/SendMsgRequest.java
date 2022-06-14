// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendMsgRequest extends TeaModel {
    // 消息内容
    @NameInMap("content")
    public String content;

    // 设备业务标识
    @NameInMap("deviceCode")
    public String deviceCode;

    // 设备唯一系统标识
    @NameInMap("deviceUuid")
    public String deviceUuid;

    // 开放群唯一标识
    @NameInMap("openConversationId")
    public String openConversationId;

    // 用户列表，群聊时为被@的人，单聊时为目标对象
    @NameInMap("userList")
    public java.util.List<String> userList;

    public static SendMsgRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMsgRequest self = new SendMsgRequest();
        return TeaModel.build(map, self);
    }

    public SendMsgRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendMsgRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public SendMsgRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public SendMsgRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendMsgRequest setUserList(java.util.List<String> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<String> getUserList() {
        return this.userList;
    }

}
