// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptVoucherStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateReceiptVoucherStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptVoucherStatusResponseBody self = new UpdateReceiptVoucherStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptVoucherStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
