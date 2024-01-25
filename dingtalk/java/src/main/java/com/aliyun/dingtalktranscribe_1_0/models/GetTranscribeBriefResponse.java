// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class GetTranscribeBriefResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTranscribeBriefResponseBody body;

    public static GetTranscribeBriefResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTranscribeBriefResponse self = new GetTranscribeBriefResponse();
        return TeaModel.build(map, self);
    }

    public GetTranscribeBriefResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTranscribeBriefResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTranscribeBriefResponse setBody(GetTranscribeBriefResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTranscribeBriefResponseBody getBody() {
        return this.body;
    }

}
