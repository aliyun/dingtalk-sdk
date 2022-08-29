// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRecognizeRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRecognizeRecordsResponseBody body;

    public static GetRecognizeRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecognizeRecordsResponse self = new GetRecognizeRecordsResponse();
        return TeaModel.build(map, self);
    }

    public GetRecognizeRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecognizeRecordsResponse setBody(GetRecognizeRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecognizeRecordsResponseBody getBody() {
        return this.body;
    }

}
