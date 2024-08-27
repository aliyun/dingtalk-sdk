// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumSaveIntegratedProcessInstanceResponseBody body;

    public static PremiumSaveIntegratedProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessInstanceResponse self = new PremiumSaveIntegratedProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumSaveIntegratedProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumSaveIntegratedProcessInstanceResponse setBody(PremiumSaveIntegratedProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumSaveIntegratedProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
