// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduAssetSpacesRequest extends TeaModel {
    // 标记当前开始读取的位置，置空表示从头开始
    @NameInMap("nextToken")
    public Long nextToken;

    // 本次读取的最大数据记录数量
    @NameInMap("maxResults")
    public Integer maxResults;

    // 业务编码
    @NameInMap("bizCode")
    public String bizCode;

    public static QueryEduAssetSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEduAssetSpacesRequest self = new QueryEduAssetSpacesRequest();
        return TeaModel.build(map, self);
    }

    public QueryEduAssetSpacesRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryEduAssetSpacesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryEduAssetSpacesRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

}
