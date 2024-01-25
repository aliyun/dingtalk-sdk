// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchBindingGroupBizIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchBindingGroupBizIdsResponseBody body;

    public static BatchBindingGroupBizIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchBindingGroupBizIdsResponse self = new BatchBindingGroupBizIdsResponse();
        return TeaModel.build(map, self);
    }

    public BatchBindingGroupBizIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchBindingGroupBizIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchBindingGroupBizIdsResponse setBody(BatchBindingGroupBizIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchBindingGroupBizIdsResponseBody getBody() {
        return this.body;
    }

}
