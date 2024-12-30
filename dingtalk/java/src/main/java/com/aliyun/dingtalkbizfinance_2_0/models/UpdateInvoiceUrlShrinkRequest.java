// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceUrlShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static UpdateInvoiceUrlShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceUrlShrinkRequest self = new UpdateInvoiceUrlShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceUrlShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
