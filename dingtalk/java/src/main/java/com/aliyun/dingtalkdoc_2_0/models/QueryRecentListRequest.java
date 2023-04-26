// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListRequest extends TeaModel {
    @NameInMap("creatorType")
    public Integer creatorType;

    @NameInMap("fileType")
    public Integer fileType;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("recentType")
    public Integer recentType;

    public static QueryRecentListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentListRequest self = new QueryRecentListRequest();
        return TeaModel.build(map, self);
    }

    public QueryRecentListRequest setCreatorType(Integer creatorType) {
        this.creatorType = creatorType;
        return this;
    }
    public Integer getCreatorType() {
        return this.creatorType;
    }

    public QueryRecentListRequest setFileType(Integer fileType) {
        this.fileType = fileType;
        return this;
    }
    public Integer getFileType() {
        return this.fileType;
    }

    public QueryRecentListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryRecentListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRecentListRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryRecentListRequest setRecentType(Integer recentType) {
        this.recentType = recentType;
        return this;
    }
    public Integer getRecentType() {
        return this.recentType;
    }

}
