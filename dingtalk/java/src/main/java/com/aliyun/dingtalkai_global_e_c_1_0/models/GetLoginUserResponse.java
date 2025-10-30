// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class GetLoginUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetLoginUserResponseBody body;

    public static GetLoginUserResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLoginUserResponse self = new GetLoginUserResponse();
        return TeaModel.build(map, self);
    }

    public GetLoginUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLoginUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetLoginUserResponse setBody(GetLoginUserResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLoginUserResponseBody getBody() {
        return this.body;
    }

}
