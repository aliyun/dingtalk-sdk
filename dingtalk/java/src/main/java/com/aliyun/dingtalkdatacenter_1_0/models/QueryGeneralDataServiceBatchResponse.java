// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceBatchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGeneralDataServiceBatchResponseBody body;

    public static QueryGeneralDataServiceBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceBatchResponse self = new QueryGeneralDataServiceBatchResponse();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGeneralDataServiceBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGeneralDataServiceBatchResponse setBody(QueryGeneralDataServiceBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGeneralDataServiceBatchResponseBody getBody() {
        return this.body;
    }

}
