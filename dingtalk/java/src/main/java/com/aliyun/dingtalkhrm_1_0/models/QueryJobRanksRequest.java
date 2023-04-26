// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Integer nextToken;

    @NameInMap("rankCategoryId")
    public String rankCategoryId;

    @NameInMap("rankCode")
    public String rankCode;

    @NameInMap("rankName")
    public String rankName;

    public static QueryJobRanksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryJobRanksRequest self = new QueryJobRanksRequest();
        return TeaModel.build(map, self);
    }

    public QueryJobRanksRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryJobRanksRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public QueryJobRanksRequest setRankCategoryId(String rankCategoryId) {
        this.rankCategoryId = rankCategoryId;
        return this;
    }
    public String getRankCategoryId() {
        return this.rankCategoryId;
    }

    public QueryJobRanksRequest setRankCode(String rankCode) {
        this.rankCode = rankCode;
        return this;
    }
    public String getRankCode() {
        return this.rankCode;
    }

    public QueryJobRanksRequest setRankName(String rankName) {
        this.rankName = rankName;
        return this;
    }
    public String getRankName() {
        return this.rankName;
    }

}
