// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountPeriodResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceAccountPeriodResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountPeriodResponseBody self = new UpdateInvoiceAccountPeriodResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountPeriodResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
