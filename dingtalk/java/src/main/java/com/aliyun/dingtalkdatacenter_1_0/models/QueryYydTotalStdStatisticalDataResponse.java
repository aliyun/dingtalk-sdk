// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalStdStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydTotalStdStatisticalDataResponseBody body;

    public static QueryYydTotalStdStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalStdStatisticalDataResponse self = new QueryYydTotalStdStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalStdStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalStdStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydTotalStdStatisticalDataResponse setBody(QueryYydTotalStdStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalStdStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
