// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncTaskInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAsyncTaskInfoResponseBody body;

    public static GetAsyncTaskInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskInfoResponse self = new GetAsyncTaskInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAsyncTaskInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAsyncTaskInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAsyncTaskInfoResponse setBody(GetAsyncTaskInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAsyncTaskInfoResponseBody getBody() {
        return this.body;
    }

}
