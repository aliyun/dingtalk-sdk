// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserInfoRequest extends TeaModel {
    /**
     * <p>按月标记。不填默认当月。填0为次月。</p>
     */
    @NameInMap("monthMark")
    public String monthMark;

    public static QueryUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserInfoRequest self = new QueryUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserInfoRequest setMonthMark(String monthMark) {
        this.monthMark = monthMark;
        return this;
    }
    public String getMonthMark() {
        return this.monthMark;
    }

}
