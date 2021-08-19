// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeReciveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryRedEnvelopeReciveStatisticalDataResponse setBody(QueryRedEnvelopeReciveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRedEnvelopeReciveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
