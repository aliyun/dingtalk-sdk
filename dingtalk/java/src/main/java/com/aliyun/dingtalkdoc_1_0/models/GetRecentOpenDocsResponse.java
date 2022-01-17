// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentOpenDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRecentOpenDocsResponseBody body;

    public static GetRecentOpenDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecentOpenDocsResponse self = new GetRecentOpenDocsResponse();
        return TeaModel.build(map, self);
    }

    public GetRecentOpenDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecentOpenDocsResponse setBody(GetRecentOpenDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecentOpenDocsResponseBody getBody() {
        return this.body;
    }

}
