// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1a353547-040d-4095-bb93-404bc5d47920</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DC7wZGOSueEEIGOf3WKwWgiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryLiveWatchDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchDetailRequest self = new QueryLiveWatchDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchDetailRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public QueryLiveWatchDetailRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
