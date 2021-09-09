// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryCompanyBasicInfoResponse setBody(QueryCompanyBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCompanyBasicInfoResponseBody getBody() {
        return this.body;
    }

}
