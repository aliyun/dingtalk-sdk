// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class GetTranscribeBriefResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetTranscribeBriefResponse setBody(GetTranscribeBriefResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTranscribeBriefResponseBody getBody() {
        return this.body;
    }

}
