// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetLastOrgAuthDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetLastOrgAuthDataResponseBody body;

    public static GetLastOrgAuthDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLastOrgAuthDataResponse self = new GetLastOrgAuthDataResponse();
        return TeaModel.build(map, self);
    }

    public GetLastOrgAuthDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLastOrgAuthDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetLastOrgAuthDataResponse setBody(GetLastOrgAuthDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLastOrgAuthDataResponseBody getBody() {
        return this.body;
    }

}
