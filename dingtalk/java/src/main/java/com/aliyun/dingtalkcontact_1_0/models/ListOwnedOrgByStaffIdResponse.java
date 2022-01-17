// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListOwnedOrgByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListOwnedOrgByStaffIdResponse setBody(ListOwnedOrgByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOwnedOrgByStaffIdResponseBody getBody() {
        return this.body;
    }

}
