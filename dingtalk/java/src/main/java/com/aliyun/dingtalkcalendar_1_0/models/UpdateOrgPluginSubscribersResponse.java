// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrgPluginSubscribersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateOrgPluginSubscribersResponseBody body;

    public static UpdateOrgPluginSubscribersResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrgPluginSubscribersResponse self = new UpdateOrgPluginSubscribersResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrgPluginSubscribersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrgPluginSubscribersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrgPluginSubscribersResponse setBody(UpdateOrgPluginSubscribersResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrgPluginSubscribersResponseBody getBody() {
        return this.body;
    }

}
