// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetLiveReplayUrlRequest extends TeaModel {
    @NameInMap("liveId")
    public String liveId;

    @NameInMap("unionId")
    public String unionId;

    public static GetLiveReplayUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLiveReplayUrlRequest self = new GetLiveReplayUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetLiveReplayUrlRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public GetLiveReplayUrlRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
