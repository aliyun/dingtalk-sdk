// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskNoteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateTaskNoteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskNoteResponse setBody(UpdateTaskNoteResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskNoteResponseBody getBody() {
        return this.body;
    }

}
