// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class ListOrgWorkspacesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListOrgWorkspacesResponseBody body;

    public static ListOrgWorkspacesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOrgWorkspacesResponse self = new ListOrgWorkspacesResponse();
        return TeaModel.build(map, self);
    }

    public ListOrgWorkspacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOrgWorkspacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListOrgWorkspacesResponse setBody(ListOrgWorkspacesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOrgWorkspacesResponseBody getBody() {
        return this.body;
    }

}
