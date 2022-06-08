// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardRequest extends TeaModel {
    // 卡片实例唯一标识
    @NameInMap("bizId")
    public String bizId;

    // 卡片变量赋值，json结构
    @NameInMap("cardData")
    public String cardData;

    // 设备业务标识
    @NameInMap("deviceCode")
    public String deviceCode;

    // 设备uuid，唯一标识
    @NameInMap("deviceUuid")
    public String deviceUuid;

    // 群id，群的唯一标识
    @NameInMap("openConversationId")
    public String openConversationId;

    // 卡片模板唯一标识，开放平台获取
    @NameInMap("templateId")
    public String templateId;

    // 是否为吊顶卡片
    @NameInMap("topbox")
    public Boolean topbox;

    // 用户通讯录唯一标识
    @NameInMap("userId")
    public String userId;

    public static SendCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendCardRequest self = new SendCardRequest();
        return TeaModel.build(map, self);
    }

    public SendCardRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendCardRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public SendCardRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public SendCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendCardRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public SendCardRequest setTopbox(Boolean topbox) {
        this.topbox = topbox;
        return this;
    }
    public Boolean getTopbox() {
        return this.topbox;
    }

    public SendCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
