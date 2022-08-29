// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetExclusiveAccountAllOrgListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetExclusiveAccountAllOrgListResponseBody body;

    public static GetExclusiveAccountAllOrgListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetExclusiveAccountAllOrgListResponse self = new GetExclusiveAccountAllOrgListResponse();
        return TeaModel.build(map, self);
    }

    public GetExclusiveAccountAllOrgListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetExclusiveAccountAllOrgListResponse setBody(GetExclusiveAccountAllOrgListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetExclusiveAccountAllOrgListResponseBody getBody() {
        return this.body;
    }

}
