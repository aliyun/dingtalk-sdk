// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryAppActiveUsersRequest extends TeaModel {
    // 本次读取的最大数据记录数量
    @NameInMap("maxResults")
    public Long maxResults;

    // 是否需要返回位置信息
    @NameInMap("needPositionInfo")
    public Boolean needPositionInfo;

    // 标记当前开始读取的位置，置空表示从头开始
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryAppActiveUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAppActiveUsersRequest self = new QueryAppActiveUsersRequest();
        return TeaModel.build(map, self);
    }

    public QueryAppActiveUsersRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryAppActiveUsersRequest setNeedPositionInfo(Boolean needPositionInfo) {
        this.needPositionInfo = needPositionInfo;
        return this;
    }
    public Boolean getNeedPositionInfo() {
        return this.needPositionInfo;
    }

    public QueryAppActiveUsersRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
