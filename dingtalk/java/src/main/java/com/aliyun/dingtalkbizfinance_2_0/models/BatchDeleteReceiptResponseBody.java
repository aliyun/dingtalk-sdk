// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteReceiptResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BatchDeleteReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteReceiptResponseBody self = new BatchDeleteReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchDeleteReceiptResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
