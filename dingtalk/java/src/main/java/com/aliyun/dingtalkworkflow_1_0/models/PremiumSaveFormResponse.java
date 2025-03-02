// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveFormResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumSaveFormResponseBody body;

    public static PremiumSaveFormResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveFormResponse self = new PremiumSaveFormResponse();
        return TeaModel.build(map, self);
    }

    public PremiumSaveFormResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumSaveFormResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumSaveFormResponse setBody(PremiumSaveFormResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumSaveFormResponseBody getBody() {
        return this.body;
    }

}
