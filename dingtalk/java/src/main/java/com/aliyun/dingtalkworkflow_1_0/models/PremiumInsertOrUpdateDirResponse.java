// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumInsertOrUpdateDirResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumInsertOrUpdateDirResponseBody body;

    public static PremiumInsertOrUpdateDirResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumInsertOrUpdateDirResponse self = new PremiumInsertOrUpdateDirResponse();
        return TeaModel.build(map, self);
    }

    public PremiumInsertOrUpdateDirResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumInsertOrUpdateDirResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumInsertOrUpdateDirResponse setBody(PremiumInsertOrUpdateDirResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumInsertOrUpdateDirResponseBody getBody() {
        return this.body;
    }

}
