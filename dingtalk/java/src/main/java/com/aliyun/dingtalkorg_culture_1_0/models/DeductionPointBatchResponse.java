// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class DeductionPointBatchResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeductionPointBatchResponseBody body;

    public static DeductionPointBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        DeductionPointBatchResponse self = new DeductionPointBatchResponse();
        return TeaModel.build(map, self);
    }

    public DeductionPointBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeductionPointBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeductionPointBatchResponse setBody(DeductionPointBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public DeductionPointBatchResponseBody getBody() {
        return this.body;
    }

}
