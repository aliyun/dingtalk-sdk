// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DelAccountMappingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DelAccountMappingResponseBody body;

    public static DelAccountMappingResponse build(java.util.Map<String, ?> map) throws Exception {
        DelAccountMappingResponse self = new DelAccountMappingResponse();
        return TeaModel.build(map, self);
    }

    public DelAccountMappingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DelAccountMappingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DelAccountMappingResponse setBody(DelAccountMappingResponseBody body) {
        this.body = body;
        return this;
    }
    public DelAccountMappingResponseBody getBody() {
        return this.body;
    }

}
