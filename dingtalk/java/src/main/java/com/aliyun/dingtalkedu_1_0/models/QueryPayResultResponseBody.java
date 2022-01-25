// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultResponseBody extends TeaModel {
    // 状态
    @NameInMap("status")
    public Integer status;

    public static QueryPayResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPayResultResponseBody self = new QueryPayResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPayResultResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
