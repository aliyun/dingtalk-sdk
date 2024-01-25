// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeReciveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRedEnvelopeReciveStatisticalDataResponseBody body;

    public static QueryRedEnvelopeReciveStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeReciveStatisticalDataResponse self = new QueryRedEnvelopeReciveStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRedEnvelopeReciveStatisticalDataResponse setBody(QueryRedEnvelopeReciveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRedEnvelopeReciveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
