// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ATMDeviceWorkNotifyRequest extends TeaModel {
    @NameInMap("creatorCorpId")
    public String creatorCorpId;

    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("notifyType")
    public String notifyType;

    @NameInMap("paramContent")
    public String paramContent;

    @NameInMap("targetUrl")
    public String targetUrl;

    public static ATMDeviceWorkNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        ATMDeviceWorkNotifyRequest self = new ATMDeviceWorkNotifyRequest();
        return TeaModel.build(map, self);
    }

    public ATMDeviceWorkNotifyRequest setCreatorCorpId(String creatorCorpId) {
        this.creatorCorpId = creatorCorpId;
        return this;
    }
    public String getCreatorCorpId() {
        return this.creatorCorpId;
    }

    public ATMDeviceWorkNotifyRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public ATMDeviceWorkNotifyRequest setNotifyType(String notifyType) {
        this.notifyType = notifyType;
        return this;
    }
    public String getNotifyType() {
        return this.notifyType;
    }

    public ATMDeviceWorkNotifyRequest setParamContent(String paramContent) {
        this.paramContent = paramContent;
        return this;
    }
    public String getParamContent() {
        return this.paramContent;
    }

    public ATMDeviceWorkNotifyRequest setTargetUrl(String targetUrl) {
        this.targetUrl = targetUrl;
        return this;
    }
    public String getTargetUrl() {
        return this.targetUrl;
    }

}
