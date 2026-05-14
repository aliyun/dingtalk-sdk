// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateAsrTranscriptionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAsrTranscriptionResponseBody body;

    public static CreateAsrTranscriptionResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAsrTranscriptionResponse self = new CreateAsrTranscriptionResponse();
        return TeaModel.build(map, self);
    }

    public CreateAsrTranscriptionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAsrTranscriptionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAsrTranscriptionResponse setBody(CreateAsrTranscriptionResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAsrTranscriptionResponseBody getBody() {
        return this.body;
    }

}
