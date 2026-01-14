// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class QueryInstalledCoolAppsInConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInstalledCoolAppsInConversationResponseBody body;

    public static QueryInstalledCoolAppsInConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInstalledCoolAppsInConversationResponse self = new QueryInstalledCoolAppsInConversationResponse();
        return TeaModel.build(map, self);
    }

    public QueryInstalledCoolAppsInConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInstalledCoolAppsInConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInstalledCoolAppsInConversationResponse setBody(QueryInstalledCoolAppsInConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInstalledCoolAppsInConversationResponseBody getBody() {
        return this.body;
    }

}
