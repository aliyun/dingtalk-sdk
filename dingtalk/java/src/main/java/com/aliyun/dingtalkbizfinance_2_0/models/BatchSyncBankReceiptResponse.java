// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchSyncBankReceiptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchSyncBankReceiptResponseBody body;

    public static BatchSyncBankReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchSyncBankReceiptResponse self = new BatchSyncBankReceiptResponse();
        return TeaModel.build(map, self);
    }

    public BatchSyncBankReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchSyncBankReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchSyncBankReceiptResponse setBody(BatchSyncBankReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchSyncBankReceiptResponseBody getBody() {
        return this.body;
    }

}
