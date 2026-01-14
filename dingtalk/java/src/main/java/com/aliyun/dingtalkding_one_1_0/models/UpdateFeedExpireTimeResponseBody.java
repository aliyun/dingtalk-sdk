// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedExpireTimeResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static UpdateFeedExpireTimeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedExpireTimeResponseBody self = new UpdateFeedExpireTimeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFeedExpireTimeResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
