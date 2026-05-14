// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAsrTranscriptionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAsrTranscriptionResponseBody body;

    public static GetAsrTranscriptionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAsrTranscriptionResponse self = new GetAsrTranscriptionResponse();
        return TeaModel.build(map, self);
    }

    public GetAsrTranscriptionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAsrTranscriptionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAsrTranscriptionResponse setBody(GetAsrTranscriptionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAsrTranscriptionResponseBody getBody() {
        return this.body;
    }

}
