// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksRequest extends TeaModel {
    // 职级序列
    @NameInMap("rankCategoryId")
    public String rankCategoryId;

    // 职级编码
    @NameInMap("rankCode")
    public String rankCode;

    // 职级名称
    @NameInMap("rankName")
    public String rankName;

    // 标记当前开始读取的位置
    @NameInMap("nextToken")
    public Integer nextToken;

    // 本次读取的最大数据记录数量
    @NameInMap("maxResults")
    public Integer maxResults;

    public static QueryJobRanksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryJobRanksRequest self = new QueryJobRanksRequest();
        return TeaModel.build(map, self);
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

    public QueryJobRanksRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public QueryJobRanksRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
