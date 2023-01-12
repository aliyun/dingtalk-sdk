// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AppendRowsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AppendRowsResponseBody body;

    public static AppendRowsResponse build(java.util.Map<String, ?> map) throws Exception {
        AppendRowsResponse self = new AppendRowsResponse();
        return TeaModel.build(map, self);
    }

    public AppendRowsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppendRowsResponse setBody(AppendRowsResponseBody body) {
        this.body = body;
        return this;
    }
    public AppendRowsResponseBody getBody() {
        return this.body;
    }

}
