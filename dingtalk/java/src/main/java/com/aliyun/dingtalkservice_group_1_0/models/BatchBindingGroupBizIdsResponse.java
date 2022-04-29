// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchBindingGroupBizIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchBindingGroupBizIdsResponse setBody(BatchBindingGroupBizIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchBindingGroupBizIdsResponseBody getBody() {
        return this.body;
    }

}
