// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteResidentDepartmentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteResidentDepartmentResponseBody body;

    public static DeleteResidentDepartmentResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteResidentDepartmentResponse self = new DeleteResidentDepartmentResponse();
        return TeaModel.build(map, self);
    }

    public DeleteResidentDepartmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteResidentDepartmentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteResidentDepartmentResponse setBody(DeleteResidentDepartmentResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteResidentDepartmentResponseBody getBody() {
        return this.body;
    }

}
