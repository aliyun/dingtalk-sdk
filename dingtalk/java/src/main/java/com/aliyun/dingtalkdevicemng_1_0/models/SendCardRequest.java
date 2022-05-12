// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("cardData")
    public String cardData;

    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("deviceUuid")
    public String deviceUuid;

    @NameInMap("encodeCid")
    public String encodeCid;

    @NameInMap("templateId")
    public String templateId;

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

    public SendCardRequest setEncodeCid(String encodeCid) {
        this.encodeCid = encodeCid;
        return this;
    }
    public String getEncodeCid() {
        return this.encodeCid;
    }

    public SendCardRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public SendCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
