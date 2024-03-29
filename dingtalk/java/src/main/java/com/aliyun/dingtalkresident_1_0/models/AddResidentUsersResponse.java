// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddResidentUsersResponseBody body;

    public static AddResidentUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        AddResidentUsersResponse self = new AddResidentUsersResponse();
        return TeaModel.build(map, self);
    }

    public AddResidentUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddResidentUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddResidentUsersResponse setBody(AddResidentUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public AddResidentUsersResponseBody getBody() {
        return this.body;
    }

}
