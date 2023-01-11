// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgHonorsRequest extends TeaModel {
    /**
     * <p>分页获取数据时，数据的数量，默认为20，最大可传入100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页获取数据的标记，第一页调用时传0，非第一页传入上次调用本接口返回值中的nextToken</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static QueryOrgHonorsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgHonorsRequest self = new QueryOrgHonorsRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgHonorsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryOrgHonorsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
