// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateProjectCustomfieldStatusResponseBody body;

    public static CreateProjectCustomfieldStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectCustomfieldStatusResponse self = new CreateProjectCustomfieldStatusResponse();
        return TeaModel.build(map, self);
    }

    public CreateProjectCustomfieldStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProjectCustomfieldStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateProjectCustomfieldStatusResponse setBody(CreateProjectCustomfieldStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProjectCustomfieldStatusResponseBody getBody() {
        return this.body;
    }

}
