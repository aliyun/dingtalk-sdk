// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryAcrossCloudStroageConfigsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAcrossCloudStroageConfigsResponseBody body;

    public static QueryAcrossCloudStroageConfigsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAcrossCloudStroageConfigsResponse self = new QueryAcrossCloudStroageConfigsResponse();
        return TeaModel.build(map, self);
    }

    public QueryAcrossCloudStroageConfigsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAcrossCloudStroageConfigsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAcrossCloudStroageConfigsResponse setBody(QueryAcrossCloudStroageConfigsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAcrossCloudStroageConfigsResponseBody getBody() {
        return this.body;
    }

}
