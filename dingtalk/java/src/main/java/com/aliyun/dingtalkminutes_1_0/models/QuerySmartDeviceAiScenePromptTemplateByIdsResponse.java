// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiScenePromptTemplateByIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody body;

    public static QuerySmartDeviceAiScenePromptTemplateByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiScenePromptTemplateByIdsResponse self = new QuerySmartDeviceAiScenePromptTemplateByIdsResponse();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsResponse setBody(QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody getBody() {
        return this.body;
    }

}
