// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserWatchLiveListRequest extends TeaModel {
    /**
     * <p>过滤类型，0：不过滤， 1：过滤已经看完的</p>
     */
    @NameInMap("filterType")
    public Integer filterType;

    /**
     * <p>单次拉去上限，默认40个</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标 第一次可不填， 后面填回包的值</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>用户uid</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetUserWatchLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserWatchLiveListRequest self = new GetUserWatchLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserWatchLiveListRequest setFilterType(Integer filterType) {
        this.filterType = filterType;
        return this;
    }
    public Integer getFilterType() {
        return this.filterType;
    }

    public GetUserWatchLiveListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetUserWatchLiveListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserWatchLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
