// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskQueueResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTaskQueueResponseBody body;

    public static GetTaskQueueResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTaskQueueResponse self = new GetTaskQueueResponse();
        return TeaModel.build(map, self);
    }

    public GetTaskQueueResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTaskQueueResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTaskQueueResponse setBody(GetTaskQueueResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTaskQueueResponseBody getBody() {
        return this.body;
    }

}
