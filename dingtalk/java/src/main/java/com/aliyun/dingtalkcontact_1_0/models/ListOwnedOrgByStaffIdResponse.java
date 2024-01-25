// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListOwnedOrgByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListOwnedOrgByStaffIdResponseBody body;

    public static ListOwnedOrgByStaffIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOwnedOrgByStaffIdResponse self = new ListOwnedOrgByStaffIdResponse();
        return TeaModel.build(map, self);
    }

    public ListOwnedOrgByStaffIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOwnedOrgByStaffIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListOwnedOrgByStaffIdResponse setBody(ListOwnedOrgByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOwnedOrgByStaffIdResponseBody getBody() {
        return this.body;
    }

}
