// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteOrgCarbonResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public WriteOrgCarbonResponseBody body;

    public static WriteOrgCarbonResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteOrgCarbonResponse self = new WriteOrgCarbonResponse();
        return TeaModel.build(map, self);
    }

    public WriteOrgCarbonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteOrgCarbonResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WriteOrgCarbonResponse setBody(WriteOrgCarbonResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteOrgCarbonResponseBody getBody() {
        return this.body;
    }

}
