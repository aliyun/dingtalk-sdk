// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public QueryGeneralDataServiceResponse setBody(QueryGeneralDataServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGeneralDataServiceResponseBody getBody() {
        return this.body;
    }

}
