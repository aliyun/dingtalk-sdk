// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateProjectCustomfieldStatusResponse setBody(CreateProjectCustomfieldStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProjectCustomfieldStatusResponseBody getBody() {
        return this.body;
    }

}
