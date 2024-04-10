// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchSyncBankReceiptResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BatchSyncBankReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchSyncBankReceiptResponseBody self = new BatchSyncBankReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchSyncBankReceiptResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
