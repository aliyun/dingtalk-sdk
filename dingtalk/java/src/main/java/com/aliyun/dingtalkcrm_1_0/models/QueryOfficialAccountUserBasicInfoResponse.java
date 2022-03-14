// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialAccountUserBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOfficialAccountUserBasicInfoResponseBody body;

    public static QueryOfficialAccountUserBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialAccountUserBasicInfoResponse self = new QueryOfficialAccountUserBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialAccountUserBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialAccountUserBasicInfoResponse setBody(QueryOfficialAccountUserBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialAccountUserBasicInfoResponseBody getBody() {
        return this.body;
    }

}
