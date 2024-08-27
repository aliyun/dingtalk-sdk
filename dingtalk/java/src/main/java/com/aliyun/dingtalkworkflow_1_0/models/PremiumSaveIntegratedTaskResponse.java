// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumSaveIntegratedTaskResponseBody body;

    public static PremiumSaveIntegratedTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedTaskResponse self = new PremiumSaveIntegratedTaskResponse();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumSaveIntegratedTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumSaveIntegratedTaskResponse setBody(PremiumSaveIntegratedTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumSaveIntegratedTaskResponseBody getBody() {
        return this.body;
    }

}
