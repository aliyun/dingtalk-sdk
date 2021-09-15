// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddResidentUsersResponse setBody(AddResidentUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public AddResidentUsersResponseBody getBody() {
        return this.body;
    }

}
