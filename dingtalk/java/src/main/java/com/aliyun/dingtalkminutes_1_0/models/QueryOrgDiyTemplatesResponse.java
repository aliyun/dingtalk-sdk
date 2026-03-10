// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgDiyTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgDiyTemplatesResponseBody body;

    public static QueryOrgDiyTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgDiyTemplatesResponse self = new QueryOrgDiyTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgDiyTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgDiyTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgDiyTemplatesResponse setBody(QueryOrgDiyTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgDiyTemplatesResponseBody getBody() {
        return this.body;
    }

}
