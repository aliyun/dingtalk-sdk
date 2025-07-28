// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEduUnionAuthServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEduUnionAuthServiceResponseBody body;

    public static QueryEduUnionAuthServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEduUnionAuthServiceResponse self = new QueryEduUnionAuthServiceResponse();
        return TeaModel.build(map, self);
    }

    public QueryEduUnionAuthServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEduUnionAuthServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEduUnionAuthServiceResponse setBody(QueryEduUnionAuthServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEduUnionAuthServiceResponseBody getBody() {
        return this.body;
    }

}
