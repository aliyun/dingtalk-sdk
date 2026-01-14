// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeleteFeedRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dd-one-work-eSo869uR9VhWe2sqTw3dDF</p>
     */
    @NameInMap("feedId")
    public String feedId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ntThCP2X44FWclaliPIXPUQiEiE</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFeedRequest self = new DeleteFeedRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFeedRequest setFeedId(String feedId) {
        this.feedId = feedId;
        return this;
    }
    public String getFeedId() {
        return this.feedId;
    }

    public DeleteFeedRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
