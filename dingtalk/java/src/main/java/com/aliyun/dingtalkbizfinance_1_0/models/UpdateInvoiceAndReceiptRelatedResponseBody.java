// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAndReceiptRelatedResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceAndReceiptRelatedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAndReceiptRelatedResponseBody self = new UpdateInvoiceAndReceiptRelatedResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAndReceiptRelatedResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
