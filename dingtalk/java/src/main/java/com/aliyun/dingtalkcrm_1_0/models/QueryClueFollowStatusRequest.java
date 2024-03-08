// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryClueFollowStatusRequest extends TeaModel {
    @NameInMap("clueId")
    public String clueId;

    public static QueryClueFollowStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClueFollowStatusRequest self = new QueryClueFollowStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryClueFollowStatusRequest setClueId(String clueId) {
        this.clueId = clueId;
        return this;
    }
    public String getClueId() {
        return this.clueId;
    }

}
