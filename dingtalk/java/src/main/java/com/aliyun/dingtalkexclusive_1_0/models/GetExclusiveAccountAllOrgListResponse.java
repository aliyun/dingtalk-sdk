// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetExclusiveAccountAllOrgListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetExclusiveAccountAllOrgListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetExclusiveAccountAllOrgListResponse setBody(GetExclusiveAccountAllOrgListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetExclusiveAccountAllOrgListResponseBody getBody() {
        return this.body;
    }

}
