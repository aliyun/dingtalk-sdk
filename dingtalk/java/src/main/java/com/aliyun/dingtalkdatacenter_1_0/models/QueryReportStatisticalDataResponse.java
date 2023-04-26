// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryReportStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryReportStatisticalDataResponseBody body;

    public static QueryReportStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReportStatisticalDataResponse self = new QueryReportStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryReportStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReportStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryReportStatisticalDataResponse setBody(QueryReportStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReportStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
