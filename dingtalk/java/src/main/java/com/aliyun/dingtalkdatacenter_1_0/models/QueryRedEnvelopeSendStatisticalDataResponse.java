// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeSendStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryRedEnvelopeSendStatisticalDataResponseBody body;

    public static QueryRedEnvelopeSendStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeSendStatisticalDataResponse self = new QueryRedEnvelopeSendStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeSendStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRedEnvelopeSendStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRedEnvelopeSendStatisticalDataResponse setBody(QueryRedEnvelopeSendStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRedEnvelopeSendStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
