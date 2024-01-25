// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppStdStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydAppStdStatisticalDataResponseBody body;

    public static QueryYydAppStdStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppStdStatisticalDataResponse self = new QueryYydAppStdStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppStdStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppStdStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydAppStdStatisticalDataResponse setBody(QueryYydAppStdStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppStdStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
