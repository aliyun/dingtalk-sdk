// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUserIndustryRolesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserIndustryRolesResponseBody body;

    public static ListUserIndustryRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserIndustryRolesResponse self = new ListUserIndustryRolesResponse();
        return TeaModel.build(map, self);
    }

    public ListUserIndustryRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUserIndustryRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListUserIndustryRolesResponse setBody(ListUserIndustryRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUserIndustryRolesResponseBody getBody() {
        return this.body;
    }

}
