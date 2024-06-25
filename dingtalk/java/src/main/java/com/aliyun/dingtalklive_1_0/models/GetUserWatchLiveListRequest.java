// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserWatchLiveListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("filterType")
    public Integer filterType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>30</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>preOrStartTime_desc_1658804913000</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6crtQT2XOgPHviiPvXhhiP6gdhiE</p>
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
