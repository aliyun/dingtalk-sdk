// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetRoleUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRoleUsersResponseBody body;

    public static GetRoleUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRoleUsersResponse self = new GetRoleUsersResponse();
        return TeaModel.build(map, self);
    }

    public GetRoleUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRoleUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRoleUsersResponse setBody(GetRoleUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRoleUsersResponseBody getBody() {
        return this.body;
    }

}
