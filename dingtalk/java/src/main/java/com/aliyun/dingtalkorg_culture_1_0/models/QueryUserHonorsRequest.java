// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryUserHonorsRequest extends TeaModel {
    /**
     * <p>查询数据的条数，默认查询20条，最大可传100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页查询的标记，查询第一页时传0，非第一页时传入上次调用本接口返回值中的nextToken</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static QueryUserHonorsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserHonorsRequest self = new QueryUserHonorsRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserHonorsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryUserHonorsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
