// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumSaveFormInstanceResponseBody body;

    public static PremiumSaveFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveFormInstanceResponse self = new PremiumSaveFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumSaveFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumSaveFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumSaveFormInstanceResponse setBody(PremiumSaveFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumSaveFormInstanceResponseBody getBody() {
        return this.body;
    }

}
