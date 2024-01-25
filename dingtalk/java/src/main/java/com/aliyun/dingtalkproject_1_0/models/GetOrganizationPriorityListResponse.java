// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationPriorityListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrganizationPriorityListResponseBody body;

    public static GetOrganizationPriorityListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationPriorityListResponse self = new GetOrganizationPriorityListResponse();
        return TeaModel.build(map, self);
    }

    public GetOrganizationPriorityListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrganizationPriorityListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrganizationPriorityListResponse setBody(GetOrganizationPriorityListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationPriorityListResponseBody getBody() {
        return this.body;
    }

}
