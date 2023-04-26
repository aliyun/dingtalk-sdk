// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddResidentMemberResponseBody body;

    public static AddResidentMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        AddResidentMemberResponse self = new AddResidentMemberResponse();
        return TeaModel.build(map, self);
    }

    public AddResidentMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddResidentMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddResidentMemberResponse setBody(AddResidentMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddResidentMemberResponseBody getBody() {
        return this.body;
    }

}
