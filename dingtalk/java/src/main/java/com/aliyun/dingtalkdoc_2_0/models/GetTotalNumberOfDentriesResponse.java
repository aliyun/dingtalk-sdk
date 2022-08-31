// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTotalNumberOfDentriesResponseBody body;

    public static GetTotalNumberOfDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfDentriesResponse self = new GetTotalNumberOfDentriesResponse();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTotalNumberOfDentriesResponse setBody(GetTotalNumberOfDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTotalNumberOfDentriesResponseBody getBody() {
        return this.body;
    }

}
