// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryDismissionStaffIdListRequest extends TeaModel {
    /**
     * <p>单页查询最大条目数， 最大50</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页查询的游标， 首次查询时传入0， 后续查询使用上一次接口返回的nextToken</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryDismissionStaffIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDismissionStaffIdListRequest self = new QueryDismissionStaffIdListRequest();
        return TeaModel.build(map, self);
    }

    public QueryDismissionStaffIdListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryDismissionStaffIdListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
