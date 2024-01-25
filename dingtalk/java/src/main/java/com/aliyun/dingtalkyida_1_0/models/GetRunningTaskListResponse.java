// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTaskListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRunningTaskListResponseBody body;

    public static GetRunningTaskListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRunningTaskListResponse self = new GetRunningTaskListResponse();
        return TeaModel.build(map, self);
    }

    public GetRunningTaskListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRunningTaskListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRunningTaskListResponse setBody(GetRunningTaskListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRunningTaskListResponseBody getBody() {
        return this.body;
    }

}
