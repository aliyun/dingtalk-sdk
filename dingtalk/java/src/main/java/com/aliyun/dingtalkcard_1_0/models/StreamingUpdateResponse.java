// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class StreamingUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public StreamingUpdateResponseBody body;

    public static StreamingUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        StreamingUpdateResponse self = new StreamingUpdateResponse();
        return TeaModel.build(map, self);
    }

    public StreamingUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StreamingUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public StreamingUpdateResponse setBody(StreamingUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public StreamingUpdateResponseBody getBody() {
        return this.body;
    }

}
