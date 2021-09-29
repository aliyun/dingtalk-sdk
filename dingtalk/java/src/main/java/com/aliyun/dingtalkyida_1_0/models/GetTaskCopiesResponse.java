// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTaskCopiesResponseBody body;

    public static GetTaskCopiesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTaskCopiesResponse self = new GetTaskCopiesResponse();
        return TeaModel.build(map, self);
    }

    public GetTaskCopiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTaskCopiesResponse setBody(GetTaskCopiesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTaskCopiesResponseBody getBody() {
        return this.body;
    }

}
