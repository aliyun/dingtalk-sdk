// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAttachmentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAttachmentResponseBody body;

    public static QueryAttachmentResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAttachmentResponse self = new QueryAttachmentResponse();
        return TeaModel.build(map, self);
    }

    public QueryAttachmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAttachmentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAttachmentResponse setBody(QueryAttachmentResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAttachmentResponseBody getBody() {
        return this.body;
    }

}
