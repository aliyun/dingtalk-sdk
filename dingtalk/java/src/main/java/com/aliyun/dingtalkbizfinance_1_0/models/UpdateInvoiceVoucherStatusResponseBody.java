// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVoucherStatusResponseBody extends TeaModel {
    /**
     * <p>业务返回结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>系统调用结果</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateInvoiceVoucherStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVoucherStatusResponseBody self = new UpdateInvoiceVoucherStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVoucherStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateInvoiceVoucherStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
