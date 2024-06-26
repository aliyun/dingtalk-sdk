// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataUpdateDateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGeneralDataUpdateDateResponseBody body;

    public static QueryGeneralDataUpdateDateResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataUpdateDateResponse self = new QueryGeneralDataUpdateDateResponse();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataUpdateDateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGeneralDataUpdateDateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGeneralDataUpdateDateResponse setBody(QueryGeneralDataUpdateDateResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGeneralDataUpdateDateResponseBody getBody() {
        return this.body;
    }

}
