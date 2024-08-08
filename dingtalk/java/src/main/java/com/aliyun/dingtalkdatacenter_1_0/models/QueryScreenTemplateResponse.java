// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryScreenTemplateResponseBody body;

    public static QueryScreenTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenTemplateResponse self = new QueryScreenTemplateResponse();
        return TeaModel.build(map, self);
    }

    public QueryScreenTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryScreenTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryScreenTemplateResponse setBody(QueryScreenTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryScreenTemplateResponseBody getBody() {
        return this.body;
    }

}
