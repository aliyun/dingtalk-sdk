// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingPeriodDateResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceAccountingPeriodDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingPeriodDateResponseBody self = new UpdateInvoiceAccountingPeriodDateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingPeriodDateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
