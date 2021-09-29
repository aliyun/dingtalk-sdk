// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpTasksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpTasksResponseBody body;

    public static GetCorpTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpTasksResponse self = new GetCorpTasksResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpTasksResponse setBody(GetCorpTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpTasksResponseBody getBody() {
        return this.body;
    }

}
