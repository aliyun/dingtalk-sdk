// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripProcessTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTripProcessTemplatesResponseBody body;

    public static QueryTripProcessTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTripProcessTemplatesResponse self = new QueryTripProcessTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public QueryTripProcessTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTripProcessTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTripProcessTemplatesResponse setBody(QueryTripProcessTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTripProcessTemplatesResponseBody getBody() {
        return this.body;
    }

}
