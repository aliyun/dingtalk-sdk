// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class QueryHtmlBundleBuildResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryHtmlBundleBuildResponseBody body;

    public static QueryHtmlBundleBuildResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHtmlBundleBuildResponse self = new QueryHtmlBundleBuildResponse();
        return TeaModel.build(map, self);
    }

    public QueryHtmlBundleBuildResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHtmlBundleBuildResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHtmlBundleBuildResponse setBody(QueryHtmlBundleBuildResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHtmlBundleBuildResponseBody getBody() {
        return this.body;
    }

}
