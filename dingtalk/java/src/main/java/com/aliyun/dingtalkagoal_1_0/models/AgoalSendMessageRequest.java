// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalSendMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://agoal.dingtalk.com">https://agoal.dingtalk.com</a></p>
     */
    @NameInMap("mobileUrl")
    public String mobileUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;A&quot;:&quot;a&quot;, &quot;B&quot;:&quot;b&quot;}</p>
     */
    @NameInMap("params")
    public String params;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://agoal.dingtalk.com">https://agoal.dingtalk.com</a></p>
     */
    @NameInMap("pcUrl")
    public String pcUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>211042291978xxxx</p>
     */
    @NameInMap("sourceDingUserId")
    public String sourceDingUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetDingUserIds")
    public java.util.List<String> targetDingUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1d01a14febc7482ca3b6e1d30cf5xxxx</p>
     */
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
