// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QuerySingleMessageStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySingleMessageStatisticalDataResponseBody body;

    public static QuerySingleMessageStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySingleMessageStatisticalDataResponse self = new QuerySingleMessageStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QuerySingleMessageStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySingleMessageStatisticalDataResponse setBody(QuerySingleMessageStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySingleMessageStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
