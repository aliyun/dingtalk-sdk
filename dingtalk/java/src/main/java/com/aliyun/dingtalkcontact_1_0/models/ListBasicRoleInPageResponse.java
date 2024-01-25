// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListBasicRoleInPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListBasicRoleInPageResponseBody body;

    public static ListBasicRoleInPageResponse build(java.util.Map<String, ?> map) throws Exception {
        ListBasicRoleInPageResponse self = new ListBasicRoleInPageResponse();
        return TeaModel.build(map, self);
    }

    public ListBasicRoleInPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListBasicRoleInPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListBasicRoleInPageResponse setBody(ListBasicRoleInPageResponseBody body) {
        this.body = body;
        return this;
    }
    public ListBasicRoleInPageResponseBody getBody() {
        return this.body;
    }

}
