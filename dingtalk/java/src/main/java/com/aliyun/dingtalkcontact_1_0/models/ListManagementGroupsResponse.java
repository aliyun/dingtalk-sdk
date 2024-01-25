// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListManagementGroupsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListManagementGroupsResponseBody body;

    public static ListManagementGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListManagementGroupsResponse self = new ListManagementGroupsResponse();
        return TeaModel.build(map, self);
    }

    public ListManagementGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListManagementGroupsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListManagementGroupsResponse setBody(ListManagementGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListManagementGroupsResponseBody getBody() {
        return this.body;
    }

}
