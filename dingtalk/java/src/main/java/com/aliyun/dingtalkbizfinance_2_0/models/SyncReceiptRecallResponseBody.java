// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SyncReceiptRecallResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SyncReceiptRecallResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncReceiptRecallResponseBody self = new SyncReceiptRecallResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncReceiptRecallResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
