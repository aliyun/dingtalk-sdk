// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListFeedsRequest extends TeaModel {
    @NameInMap("excludeFile")
    public Boolean excludeFile;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("operatorId")
    public String operatorId;

    public static ListFeedsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFeedsRequest self = new ListFeedsRequest();
        return TeaModel.build(map, self);
    }

    public ListFeedsRequest setExcludeFile(Boolean excludeFile) {
        this.excludeFile = excludeFile;
        return this;
    }
    public Boolean getExcludeFile() {
        return this.excludeFile;
    }

    public ListFeedsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFeedsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListFeedsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
