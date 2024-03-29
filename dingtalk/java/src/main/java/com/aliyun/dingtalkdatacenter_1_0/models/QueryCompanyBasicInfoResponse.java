// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCompanyBasicInfoResponseBody body;

    public static QueryCompanyBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyBasicInfoResponse self = new QueryCompanyBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryCompanyBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCompanyBasicInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCompanyBasicInfoResponse setBody(QueryCompanyBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCompanyBasicInfoResponseBody getBody() {
        return this.body;
    }

}
