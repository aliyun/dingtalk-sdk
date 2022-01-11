// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPlatformResourceResponseBody extends TeaModel {
    // accountTotalAmount
    @NameInMap("accountTotalAmount")
    public Integer accountTotalAmount;

    // accountUsageAmount
    @NameInMap("accountUsageAmount")
    public Integer accountUsageAmount;

    // appTotalAmount
    @NameInMap("appTotalAmount")
    public Integer appTotalAmount;

    // attachmentTotalAmount
    @NameInMap("attachmentTotalAmount")
    public Long attachmentTotalAmount;

    // attachmentUsageAmount
    @NameInMap("attachmentUsageAmount")
    public Long attachmentUsageAmount;

    // instanceTotalAmount
    @NameInMap("instanceTotalAmount")
    public Long instanceTotalAmount;

    // instanceUsageAmount
    @NameInMap("instanceUsageAmount")
    public Long instanceUsageAmount;

    // pluginUsageAmount
    @NameInMap("pluginUsageAmount")
    public Long pluginUsageAmount;

    public static GetPlatformResourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPlatformResourceResponseBody self = new GetPlatformResourceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPlatformResourceResponseBody setAccountTotalAmount(Integer accountTotalAmount) {
        this.accountTotalAmount = accountTotalAmount;
        return this;
    }
    public Integer getAccountTotalAmount() {
        return this.accountTotalAmount;
    }

    public GetPlatformResourceResponseBody setAccountUsageAmount(Integer accountUsageAmount) {
        this.accountUsageAmount = accountUsageAmount;
        return this;
    }
    public Integer getAccountUsageAmount() {
        return this.accountUsageAmount;
    }

    public GetPlatformResourceResponseBody setAppTotalAmount(Integer appTotalAmount) {
        this.appTotalAmount = appTotalAmount;
        return this;
    }
    public Integer getAppTotalAmount() {
        return this.appTotalAmount;
    }

    public GetPlatformResourceResponseBody setAttachmentTotalAmount(Long attachmentTotalAmount) {
        this.attachmentTotalAmount = attachmentTotalAmount;
        return this;
    }
    public Long getAttachmentTotalAmount() {
        return this.attachmentTotalAmount;
    }

    public GetPlatformResourceResponseBody setAttachmentUsageAmount(Long attachmentUsageAmount) {
        this.attachmentUsageAmount = attachmentUsageAmount;
        return this;
    }
    public Long getAttachmentUsageAmount() {
        return this.attachmentUsageAmount;
    }

    public GetPlatformResourceResponseBody setInstanceTotalAmount(Long instanceTotalAmount) {
        this.instanceTotalAmount = instanceTotalAmount;
        return this;
    }
    public Long getInstanceTotalAmount() {
        return this.instanceTotalAmount;
    }

    public GetPlatformResourceResponseBody setInstanceUsageAmount(Long instanceUsageAmount) {
        this.instanceUsageAmount = instanceUsageAmount;
        return this;
    }
    public Long getInstanceUsageAmount() {
        return this.instanceUsageAmount;
    }

    public GetPlatformResourceResponseBody setPluginUsageAmount(Long pluginUsageAmount) {
        this.pluginUsageAmount = pluginUsageAmount;
        return this;
    }
    public Long getPluginUsageAmount() {
        return this.pluginUsageAmount;
    }

}
