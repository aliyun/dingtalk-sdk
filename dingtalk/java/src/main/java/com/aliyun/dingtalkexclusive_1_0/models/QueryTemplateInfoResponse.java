// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryTemplateInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTemplateInfoResponseBody body;

    public static QueryTemplateInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTemplateInfoResponse self = new QueryTemplateInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryTemplateInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTemplateInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTemplateInfoResponse setBody(QueryTemplateInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTemplateInfoResponseBody getBody() {
        return this.body;
    }

}
