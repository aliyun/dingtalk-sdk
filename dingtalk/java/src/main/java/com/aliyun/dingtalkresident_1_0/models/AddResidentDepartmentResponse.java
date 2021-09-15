// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentDepartmentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddResidentDepartmentResponseBody body;

    public static AddResidentDepartmentResponse build(java.util.Map<String, ?> map) throws Exception {
        AddResidentDepartmentResponse self = new AddResidentDepartmentResponse();
        return TeaModel.build(map, self);
    }

    public AddResidentDepartmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddResidentDepartmentResponse setBody(AddResidentDepartmentResponseBody body) {
        this.body = body;
        return this;
    }
    public AddResidentDepartmentResponseBody getBody() {
        return this.body;
    }

}
