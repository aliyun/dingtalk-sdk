// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StopCloudFeedRequest extends TeaModel {
    /**
     * <p>操作者的组织内id（staffId）</p>
     */
    @NameInMap("userId")
    public String userId;

    public static StopCloudFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        StopCloudFeedRequest self = new StopCloudFeedRequest();
        return TeaModel.build(map, self);
    }

    public StopCloudFeedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
