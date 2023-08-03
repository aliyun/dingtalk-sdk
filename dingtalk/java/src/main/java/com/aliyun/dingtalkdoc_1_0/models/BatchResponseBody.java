// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchResponseBody extends TeaModel {
    @NameInMap("responses")
    public java.util.List<?> responses;

    public static BatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchResponseBody self = new BatchResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchResponseBody setResponses(java.util.List<?> responses) {
        this.responses = responses;
        return this;
    }
    public java.util.List<?> getResponses() {
        return this.responses;
    }

}
