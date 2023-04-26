// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGeneralDataServiceResponseBody body;

    public static QueryGeneralDataServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceResponse self = new QueryGeneralDataServiceResponse();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGeneralDataServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGeneralDataServiceResponse setBody(QueryGeneralDataServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGeneralDataServiceResponseBody getBody() {
        return this.body;
    }

}
