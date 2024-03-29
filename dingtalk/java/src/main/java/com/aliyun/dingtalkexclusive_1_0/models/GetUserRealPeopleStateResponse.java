// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealPeopleStateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserRealPeopleStateResponseBody body;

    public static GetUserRealPeopleStateResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealPeopleStateResponse self = new GetUserRealPeopleStateResponse();
        return TeaModel.build(map, self);
    }

    public GetUserRealPeopleStateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserRealPeopleStateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserRealPeopleStateResponse setBody(GetUserRealPeopleStateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserRealPeopleStateResponseBody getBody() {
        return this.body;
    }

}
