// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMessageStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupMessageStatisticalDataResponseBody body;

    public static QueryGroupMessageStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMessageStatisticalDataResponse self = new QueryGroupMessageStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMessageStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMessageStatisticalDataResponse setBody(QueryGroupMessageStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMessageStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
