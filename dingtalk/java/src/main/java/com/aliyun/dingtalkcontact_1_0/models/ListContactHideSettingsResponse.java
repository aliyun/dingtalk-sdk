// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactHideSettingsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListContactHideSettingsResponse setBody(ListContactHideSettingsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListContactHideSettingsResponseBody getBody() {
        return this.body;
    }

}
