// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskNoteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTaskNoteResponseBody body;

    public static UpdateTaskNoteResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskNoteResponse self = new UpdateTaskNoteResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskNoteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskNoteResponse setBody(UpdateTaskNoteResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskNoteResponseBody getBody() {
        return this.body;
    }

}
