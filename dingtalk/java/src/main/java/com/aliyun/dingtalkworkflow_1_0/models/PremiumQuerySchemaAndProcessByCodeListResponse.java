// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumQuerySchemaAndProcessByCodeListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumQuerySchemaAndProcessByCodeListResponseBody body;

    public static PremiumQuerySchemaAndProcessByCodeListResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumQuerySchemaAndProcessByCodeListResponse self = new PremiumQuerySchemaAndProcessByCodeListResponse();
        return TeaModel.build(map, self);
    }

    public PremiumQuerySchemaAndProcessByCodeListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumQuerySchemaAndProcessByCodeListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumQuerySchemaAndProcessByCodeListResponse setBody(PremiumQuerySchemaAndProcessByCodeListResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumQuerySchemaAndProcessByCodeListResponseBody getBody() {
        return this.body;
    }

}
