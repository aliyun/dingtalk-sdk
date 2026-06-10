// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupRemoveStaticGroupMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UserGroupRemoveStaticGroupMembersResponseBody body;

    public static UserGroupRemoveStaticGroupMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        UserGroupRemoveStaticGroupMembersResponse self = new UserGroupRemoveStaticGroupMembersResponse();
        return TeaModel.build(map, self);
    }

    public UserGroupRemoveStaticGroupMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserGroupRemoveStaticGroupMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UserGroupRemoveStaticGroupMembersResponse setBody(UserGroupRemoveStaticGroupMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public UserGroupRemoveStaticGroupMembersResponseBody getBody() {
        return this.body;
    }

}
