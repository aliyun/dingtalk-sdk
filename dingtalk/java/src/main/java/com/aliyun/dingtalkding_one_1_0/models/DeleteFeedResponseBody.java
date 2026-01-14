// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeleteFeedResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DeleteFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFeedResponseBody self = new DeleteFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFeedResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
