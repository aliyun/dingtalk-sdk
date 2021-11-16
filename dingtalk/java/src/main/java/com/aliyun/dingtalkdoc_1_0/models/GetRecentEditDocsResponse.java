// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRecentEditDocsResponseBody body;

    public static GetRecentEditDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecentEditDocsResponse self = new GetRecentEditDocsResponse();
        return TeaModel.build(map, self);
    }

    public GetRecentEditDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecentEditDocsResponse setBody(GetRecentEditDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecentEditDocsResponseBody getBody() {
        return this.body;
    }

}
