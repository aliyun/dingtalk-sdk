// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumSaveIntegratedProcessResponseBody body;

    public static PremiumSaveIntegratedProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessResponse self = new PremiumSaveIntegratedProcessResponse();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumSaveIntegratedProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumSaveIntegratedProcessResponse setBody(PremiumSaveIntegratedProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumSaveIntegratedProcessResponseBody getBody() {
        return this.body;
    }

}
