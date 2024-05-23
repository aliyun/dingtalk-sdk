// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalSendMessageRequest extends TeaModel {
    @NameInMap("mobileUrl")
    public String mobileUrl;

    @NameInMap("params")
    public String params;

    @NameInMap("pcUrl")
    public String pcUrl;

    @NameInMap("sourceDingUserId")
    public String sourceDingUserId;

    @NameInMap("targetDingUserIds")
    public java.util.List<String> targetDingUserIds;

    @NameInMap("templateId")
    public String templateId;

    public static AgoalSendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalSendMessageRequest self = new AgoalSendMessageRequest();
        return TeaModel.build(map, self);
    }

    public AgoalSendMessageRequest setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public AgoalSendMessageRequest setParams(String params) {
        this.params = params;
        return this;
    }
    public String getParams() {
        return this.params;
    }

    public AgoalSendMessageRequest setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public AgoalSendMessageRequest setSourceDingUserId(String sourceDingUserId) {
        this.sourceDingUserId = sourceDingUserId;
        return this;
    }
    public String getSourceDingUserId() {
        return this.sourceDingUserId;
    }

    public AgoalSendMessageRequest setTargetDingUserIds(java.util.List<String> targetDingUserIds) {
        this.targetDingUserIds = targetDingUserIds;
        return this;
    }
    public java.util.List<String> getTargetDingUserIds() {
        return this.targetDingUserIds;
    }

    public AgoalSendMessageRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
