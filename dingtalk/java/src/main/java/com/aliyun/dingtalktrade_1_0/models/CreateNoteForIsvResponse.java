// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateNoteForIsvResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateNoteForIsvResponseBody body;

    public static CreateNoteForIsvResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateNoteForIsvResponse self = new CreateNoteForIsvResponse();
        return TeaModel.build(map, self);
    }

    public CreateNoteForIsvResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateNoteForIsvResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateNoteForIsvResponse setBody(CreateNoteForIsvResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateNoteForIsvResponseBody getBody() {
        return this.body;
    }

}
