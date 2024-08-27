// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFieldModifiedHistoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetFieldModifiedHistoryResponseBody body;

    public static PremiumGetFieldModifiedHistoryResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFieldModifiedHistoryResponse self = new PremiumGetFieldModifiedHistoryResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetFieldModifiedHistoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetFieldModifiedHistoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetFieldModifiedHistoryResponse setBody(PremiumGetFieldModifiedHistoryResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetFieldModifiedHistoryResponseBody getBody() {
        return this.body;
    }

}
