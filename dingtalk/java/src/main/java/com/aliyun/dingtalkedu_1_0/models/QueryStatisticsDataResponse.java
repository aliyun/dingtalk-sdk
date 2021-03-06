// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStatisticsDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryStatisticsDataResponseBody body;

    public static QueryStatisticsDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStatisticsDataResponse self = new QueryStatisticsDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryStatisticsDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStatisticsDataResponse setBody(QueryStatisticsDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStatisticsDataResponseBody getBody() {
        return this.body;
    }

}
