// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceIgnoreStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceIgnoreStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceIgnoreStatusResponseBody self = new UpdateInvoiceIgnoreStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceIgnoreStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
