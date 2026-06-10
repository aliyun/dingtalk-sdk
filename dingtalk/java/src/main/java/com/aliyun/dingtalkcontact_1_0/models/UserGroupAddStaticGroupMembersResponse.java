// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupAddStaticGroupMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UserGroupAddStaticGroupMembersResponseBody body;

    public static UserGroupAddStaticGroupMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        UserGroupAddStaticGroupMembersResponse self = new UserGroupAddStaticGroupMembersResponse();
        return TeaModel.build(map, self);
    }

    public UserGroupAddStaticGroupMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserGroupAddStaticGroupMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UserGroupAddStaticGroupMembersResponse setBody(UserGroupAddStaticGroupMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public UserGroupAddStaticGroupMembersResponseBody getBody() {
        return this.body;
    }

}
