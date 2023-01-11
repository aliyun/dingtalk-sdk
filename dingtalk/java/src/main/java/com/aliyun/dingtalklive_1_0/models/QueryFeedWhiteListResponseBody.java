// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryFeedWhiteListResponseBody extends TeaModel {
    /**
     * <p>是否在白名单内</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static QueryFeedWhiteListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFeedWhiteListResponseBody self = new QueryFeedWhiteListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFeedWhiteListResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
