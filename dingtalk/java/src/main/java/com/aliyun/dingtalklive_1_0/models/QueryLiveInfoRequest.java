// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveInfoRequest extends TeaModel {
    @NameInMap("liveId")
    public String liveId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryLiveInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveInfoRequest self = new QueryLiveInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryLiveInfoRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public QueryLiveInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
