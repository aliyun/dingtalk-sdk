// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListSeniorSettingsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListSeniorSettingsResponseBody body;

    public static ListSeniorSettingsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSeniorSettingsResponse self = new ListSeniorSettingsResponse();
        return TeaModel.build(map, self);
    }

    public ListSeniorSettingsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSeniorSettingsResponse setBody(ListSeniorSettingsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSeniorSettingsResponseBody getBody() {
        return this.body;
    }

}
