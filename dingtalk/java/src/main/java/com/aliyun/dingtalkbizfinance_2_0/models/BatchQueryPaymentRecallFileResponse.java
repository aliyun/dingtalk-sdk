// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryPaymentRecallFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryPaymentRecallFileResponseBody body;

    public static BatchQueryPaymentRecallFileResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryPaymentRecallFileResponse self = new BatchQueryPaymentRecallFileResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryPaymentRecallFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryPaymentRecallFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryPaymentRecallFileResponse setBody(BatchQueryPaymentRecallFileResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryPaymentRecallFileResponseBody getBody() {
        return this.body;
    }

}
