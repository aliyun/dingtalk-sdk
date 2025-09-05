// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripInvoiceShrinkRequest extends TeaModel {
    @NameInMap("channelOrderNo")
    public String channelOrderNo;

    @NameInMap("channelType")
    public String channelType;

    @NameInMap("customerCorpId")
    public String customerCorpId;

    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("invoiceDetailList")
    public String invoiceDetailListShrink;

    public static SyncTripInvoiceShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripInvoiceShrinkRequest self = new SyncTripInvoiceShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SyncTripInvoiceShrinkRequest setChannelOrderNo(String channelOrderNo) {
        this.channelOrderNo = channelOrderNo;
        return this;
    }
    public String getChannelOrderNo() {
        return this.channelOrderNo;
    }

    public SyncTripInvoiceShrinkRequest setChannelType(String channelType) {
        this.channelType = channelType;
        return this;
    }
    public String getChannelType() {
        return this.channelType;
    }

    public SyncTripInvoiceShrinkRequest setCustomerCorpId(String customerCorpId) {
        this.customerCorpId = customerCorpId;
        return this;
    }
    public String getCustomerCorpId() {
        return this.customerCorpId;
    }

    public SyncTripInvoiceShrinkRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public SyncTripInvoiceShrinkRequest setInvoiceDetailListShrink(String invoiceDetailListShrink) {
        this.invoiceDetailListShrink = invoiceDetailListShrink;
        return this;
    }
    public String getInvoiceDetailListShrink() {
        return this.invoiceDetailListShrink;
    }

}
