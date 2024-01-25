// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetAccountMappingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAccountMappingResponseBody body;

    public static GetAccountMappingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAccountMappingResponse self = new GetAccountMappingResponse();
        return TeaModel.build(map, self);
    }

    public GetAccountMappingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAccountMappingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAccountMappingResponse setBody(GetAccountMappingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAccountMappingResponseBody getBody() {
        return this.body;
    }

}
