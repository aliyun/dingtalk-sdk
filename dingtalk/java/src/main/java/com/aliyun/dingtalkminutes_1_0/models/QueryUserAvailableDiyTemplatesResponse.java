// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAvailableDiyTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserAvailableDiyTemplatesResponseBody body;

    public static QueryUserAvailableDiyTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAvailableDiyTemplatesResponse self = new QueryUserAvailableDiyTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserAvailableDiyTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserAvailableDiyTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserAvailableDiyTemplatesResponse setBody(QueryUserAvailableDiyTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserAvailableDiyTemplatesResponseBody getBody() {
        return this.body;
    }

}
