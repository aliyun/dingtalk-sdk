// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceTransferDataShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static QueryInvoiceTransferDataShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceTransferDataShrinkRequest self = new QueryInvoiceTransferDataShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceTransferDataShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
