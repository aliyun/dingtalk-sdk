// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class AddRoleMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddRoleMemberResponseBody body;

    public static AddRoleMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRoleMemberResponse self = new AddRoleMemberResponse();
        return TeaModel.build(map, self);
    }

    public AddRoleMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRoleMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRoleMemberResponse setBody(AddRoleMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRoleMemberResponseBody getBody() {
        return this.body;
    }

}
