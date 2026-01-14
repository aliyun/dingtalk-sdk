// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedExpireTimeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1772177962000</p>
     */
    @NameInMap("expireTime")
    public Long expireTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dd-one-work-eSo869uR9Vhse2sqTw3dDF</p>
     */
    @NameInMap("feedId")
    public String feedId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ntThCP2X44FlskVliPIXPUQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateFeedExpireTimeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedExpireTimeRequest self = new UpdateFeedExpireTimeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFeedExpireTimeRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public UpdateFeedExpireTimeRequest setFeedId(String feedId) {
        this.feedId = feedId;
        return this;
    }
    public String getFeedId() {
        return this.feedId;
    }

    public UpdateFeedExpireTimeRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
