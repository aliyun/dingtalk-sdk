// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceDataTransferDoneResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateInvoiceDataTransferDoneResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceDataTransferDoneResponseBody self = new UpdateInvoiceDataTransferDoneResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceDataTransferDoneResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
