// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetSignDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignDetailResponseBody body;

    public static GetSignDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignDetailResponse self = new GetSignDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetSignDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignDetailResponse setBody(GetSignDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignDetailResponseBody getBody() {
        return this.body;
    }

}
