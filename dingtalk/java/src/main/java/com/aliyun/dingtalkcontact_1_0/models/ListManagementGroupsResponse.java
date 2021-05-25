// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListManagementGroupsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListManagementGroupsResponse setBody(ListManagementGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListManagementGroupsResponseBody getBody() {
        return this.body;
    }

}
