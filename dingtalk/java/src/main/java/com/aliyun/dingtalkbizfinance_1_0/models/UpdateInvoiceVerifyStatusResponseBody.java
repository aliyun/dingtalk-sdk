// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceVerifyStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusResponseBody self = new UpdateInvoiceVerifyStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
