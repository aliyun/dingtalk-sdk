// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetChildOrgListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetChildOrgListResponseBody body;

    public static GetChildOrgListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetChildOrgListResponse self = new GetChildOrgListResponse();
        return TeaModel.build(map, self);
    }

    public GetChildOrgListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetChildOrgListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetChildOrgListResponse setBody(GetChildOrgListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetChildOrgListResponseBody getBody() {
        return this.body;
    }

}
