// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTaskListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetRunningTaskListResponse setBody(GetRunningTaskListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRunningTaskListResponseBody getBody() {
        return this.body;
    }

}
