// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListIndustryRoleUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListIndustryRoleUsersResponseBody body;

    public static ListIndustryRoleUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListIndustryRoleUsersResponse self = new ListIndustryRoleUsersResponse();
        return TeaModel.build(map, self);
    }

    public ListIndustryRoleUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListIndustryRoleUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListIndustryRoleUsersResponse setBody(ListIndustryRoleUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListIndustryRoleUsersResponseBody getBody() {
        return this.body;
    }

}
