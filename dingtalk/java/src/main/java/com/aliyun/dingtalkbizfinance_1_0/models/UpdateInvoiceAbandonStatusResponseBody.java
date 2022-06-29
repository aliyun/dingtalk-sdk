// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAbandonStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceAbandonStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAbandonStatusResponseBody self = new UpdateInvoiceAbandonStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAbandonStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
