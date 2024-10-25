// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgAccountMobileVisiblePermissonResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrgAccountMobileVisiblePermissonResponseBody body;

    public static OrgAccountMobileVisiblePermissonResponse build(java.util.Map<String, ?> map) throws Exception {
        OrgAccountMobileVisiblePermissonResponse self = new OrgAccountMobileVisiblePermissonResponse();
        return TeaModel.build(map, self);
    }

    public OrgAccountMobileVisiblePermissonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrgAccountMobileVisiblePermissonResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrgAccountMobileVisiblePermissonResponse setBody(OrgAccountMobileVisiblePermissonResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgAccountMobileVisiblePermissonResponseBody getBody() {
        return this.body;
    }

}
