// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactHideSettingsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListContactHideSettingsResponseBody body;

    public static ListContactHideSettingsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListContactHideSettingsResponse self = new ListContactHideSettingsResponse();
        return TeaModel.build(map, self);
    }

    public ListContactHideSettingsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListContactHideSettingsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListContactHideSettingsResponse setBody(ListContactHideSettingsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListContactHideSettingsResponseBody getBody() {
        return this.body;
    }

}
