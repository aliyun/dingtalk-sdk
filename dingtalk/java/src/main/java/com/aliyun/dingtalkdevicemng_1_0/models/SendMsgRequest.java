// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendMsgRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("deviceUuid")
    public String deviceUuid;

    /**
     * <strong>example:</strong>
     * <p>cidxxxxxxx==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

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
