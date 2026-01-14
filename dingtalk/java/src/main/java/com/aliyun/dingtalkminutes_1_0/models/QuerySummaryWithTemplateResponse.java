// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySummaryWithTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySummaryWithTemplateResponseBody body;

    public static QuerySummaryWithTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySummaryWithTemplateResponse self = new QuerySummaryWithTemplateResponse();
        return TeaModel.build(map, self);
    }

    public QuerySummaryWithTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySummaryWithTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySummaryWithTemplateResponse setBody(QuerySummaryWithTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySummaryWithTemplateResponseBody getBody() {
        return this.body;
    }

}
