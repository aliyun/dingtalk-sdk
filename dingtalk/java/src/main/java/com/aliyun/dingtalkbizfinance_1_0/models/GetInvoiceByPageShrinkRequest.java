// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageShrinkRequest extends TeaModel {
    @NameInMap("request")
    public String requestShrink;

    public static GetInvoiceByPageShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageShrinkRequest self = new GetInvoiceByPageShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageShrinkRequest setRequestShrink(String requestShrink) {
        this.requestShrink = requestShrink;
        return this;
    }
    public String getRequestShrink() {
        return this.requestShrink;
    }

}
