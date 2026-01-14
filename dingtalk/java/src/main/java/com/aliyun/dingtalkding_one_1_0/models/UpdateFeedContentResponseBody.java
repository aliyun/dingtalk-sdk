// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedContentResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static UpdateFeedContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedContentResponseBody self = new UpdateFeedContentResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFeedContentResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
