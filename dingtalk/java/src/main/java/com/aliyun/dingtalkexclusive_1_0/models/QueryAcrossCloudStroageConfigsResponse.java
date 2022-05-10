// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryAcrossCloudStroageConfigsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public QueryAcrossCloudStroageConfigsResponse setBody(QueryAcrossCloudStroageConfigsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAcrossCloudStroageConfigsResponseBody getBody() {
        return this.body;
    }

}
