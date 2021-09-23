// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetApplicationAuthorizationServicePlatformResourceResponseBody extends TeaModel {
    // appTotalAmount
    @NameInMap("appTotalAmount")
    public Integer appTotalAmount;

    // instanceId
    @NameInMap("instanceId")
    public String instanceId;

    // instanceTotalAmount
    @NameInMap("instanceTotalAmount")
    public Long instanceTotalAmount;

    // instanceUsageAmount
    @NameInMap("instanceUsageAmount")
    public Long instanceUsageAmount;

    // accountUsageAmount
    @NameInMap("accountUsageAmount")
    public Integer accountUsageAmount;

    // accountTotalAmount
    @NameInMap("accountTotalAmount")
    public Integer accountTotalAmount;

    // pluginUsageAmount
    @NameInMap("pluginUsageAmount")
    public Long pluginUsageAmount;

    // attachmentTotalAmount
    @NameInMap("attachmentTotalAmount")
    public Long attachmentTotalAmount;

    // attachmentUsageAmount
    @NameInMap("attachmentUsageAmount")
    public Long attachmentUsageAmount;

    public static GetApplicationAuthorizationServicePlatformResourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetApplicationAuthorizationServicePlatformResourceResponseBody self = new GetApplicationAuthorizationServicePlatformResourceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setAppTotalAmount(Integer appTotalAmount) {
        this.appTotalAmount = appTotalAmount;
        return this;
    }
    public Integer getAppTotalAmount() {
        return this.appTotalAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setInstanceTotalAmount(Long instanceTotalAmount) {
        this.instanceTotalAmount = instanceTotalAmount;
        return this;
    }
    public Long getInstanceTotalAmount() {
        return this.instanceTotalAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setInstanceUsageAmount(Long instanceUsageAmount) {
        this.instanceUsageAmount = instanceUsageAmount;
        return this;
    }
    public Long getInstanceUsageAmount() {
        return this.instanceUsageAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setAccountUsageAmount(Integer accountUsageAmount) {
        this.accountUsageAmount = accountUsageAmount;
        return this;
    }
    public Integer getAccountUsageAmount() {
        return this.accountUsageAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setAccountTotalAmount(Integer accountTotalAmount) {
        this.accountTotalAmount = accountTotalAmount;
        return this;
    }
    public Integer getAccountTotalAmount() {
        return this.accountTotalAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setPluginUsageAmount(Long pluginUsageAmount) {
        this.pluginUsageAmount = pluginUsageAmount;
        return this;
    }
    public Long getPluginUsageAmount() {
        return this.pluginUsageAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setAttachmentTotalAmount(Long attachmentTotalAmount) {
        this.attachmentTotalAmount = attachmentTotalAmount;
        return this;
    }
    public Long getAttachmentTotalAmount() {
        return this.attachmentTotalAmount;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponseBody setAttachmentUsageAmount(Long attachmentUsageAmount) {
        this.attachmentUsageAmount = attachmentUsageAmount;
        return this;
    }
    public Long getAttachmentUsageAmount() {
        return this.attachmentUsageAmount;
    }

}
