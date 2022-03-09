// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteObjectiveResponseBody body;

    public static DeleteObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectiveResponse self = new DeleteObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public DeleteObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteObjectiveResponse setBody(DeleteObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteObjectiveResponseBody getBody() {
        return this.body;
    }

}
