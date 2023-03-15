// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateInvoiceAccountingStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingStatusResponseBody self = new UpdateInvoiceAccountingStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
