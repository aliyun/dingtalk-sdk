// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteStudentResponseBody body;

    public static DeleteStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteStudentResponse self = new DeleteStudentResponse();
        return TeaModel.build(map, self);
    }

    public DeleteStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteStudentResponse setBody(DeleteStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteStudentResponseBody getBody() {
        return this.body;
    }

}
