// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class ListGroupStaffMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListGroupStaffMembersResponseBody body;

    public static ListGroupStaffMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListGroupStaffMembersResponse self = new ListGroupStaffMembersResponse();
        return TeaModel.build(map, self);
    }

    public ListGroupStaffMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListGroupStaffMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListGroupStaffMembersResponse setBody(ListGroupStaffMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListGroupStaffMembersResponseBody getBody() {
        return this.body;
    }

}
