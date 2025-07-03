// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetRoleDetailByIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRoleDetailByIdResponseBody body;

    public static GetRoleDetailByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRoleDetailByIdResponse self = new GetRoleDetailByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetRoleDetailByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRoleDetailByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRoleDetailByIdResponse setBody(GetRoleDetailByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRoleDetailByIdResponseBody getBody() {
        return this.body;
    }

}
