// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingSendStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDingSendStatisticalDataResponseBody body;

    public static QueryDingSendStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDingSendStatisticalDataResponse self = new QueryDingSendStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDingSendStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDingSendStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDingSendStatisticalDataResponse setBody(QueryDingSendStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDingSendStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
