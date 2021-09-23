// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPlatformResourceResponseBody extends TeaModel {
    // appTotalAmount
    @NameInMap("appTotalAmount")
    public Integer appTotalAmount;

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

    public static GetPlatformResourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPlatformResourceResponseBody self = new GetPlatformResourceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPlatformResourceResponseBody setAppTotalAmount(Integer appTotalAmount) {
        this.appTotalAmount = appTotalAmount;
        return this;
    }
    public Integer getAppTotalAmount() {
        return this.appTotalAmount;
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

    public GetPlatformResourceResponseBody setAccountUsageAmount(Integer accountUsageAmount) {
        this.accountUsageAmount = accountUsageAmount;
        return this;
    }
    public Integer getAccountUsageAmount() {
        return this.accountUsageAmount;
    }

    public GetPlatformResourceResponseBody setAccountTotalAmount(Integer accountTotalAmount) {
        this.accountTotalAmount = accountTotalAmount;
        return this;
    }
    public Integer getAccountTotalAmount() {
        return this.accountTotalAmount;
    }

    public GetPlatformResourceResponseBody setPluginUsageAmount(Long pluginUsageAmount) {
        this.pluginUsageAmount = pluginUsageAmount;
        return this;
    }
    public Long getPluginUsageAmount() {
        return this.pluginUsageAmount;
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

}
