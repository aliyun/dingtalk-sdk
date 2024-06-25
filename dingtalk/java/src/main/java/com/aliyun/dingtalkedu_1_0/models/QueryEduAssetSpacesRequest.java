// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduAssetSpacesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>soke</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20110</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryEduAssetSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEduAssetSpacesRequest self = new QueryEduAssetSpacesRequest();
        return TeaModel.build(map, self);
    }

    public QueryEduAssetSpacesRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public QueryEduAssetSpacesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryEduAssetSpacesRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
