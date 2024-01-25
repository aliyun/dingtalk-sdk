// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentOpenDocsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetRecentOpenDocsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRecentOpenDocsResponse setBody(GetRecentOpenDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecentOpenDocsResponseBody getBody() {
        return this.body;
    }

}
