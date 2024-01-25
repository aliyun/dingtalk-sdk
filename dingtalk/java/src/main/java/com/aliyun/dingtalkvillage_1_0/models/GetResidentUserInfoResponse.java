// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResidentUserInfoResponseBody body;

    public static GetResidentUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentUserInfoResponse self = new GetResidentUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResidentUserInfoResponse setBody(GetResidentUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentUserInfoResponseBody getBody() {
        return this.body;
    }

}
