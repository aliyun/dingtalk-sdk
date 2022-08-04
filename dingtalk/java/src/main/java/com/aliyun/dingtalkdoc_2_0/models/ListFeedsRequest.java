// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListFeedsRequest extends TeaModel {
    // 是否排除文件。
    @NameInMap("excludeFile")
    public Boolean excludeFile;

    // 每页最大条目数，最大值50。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，第一页可不传。
    @NameInMap("nextToken")
    public String nextToken;

    // 操作用户unionId。
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
