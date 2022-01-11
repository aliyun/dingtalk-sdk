// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsRequest extends TeaModel {
    // 搜索关键字
    @NameInMap("keyword")
    public String keyword;

    // 搜索数量
    @NameInMap("maxResults")
    public Integer maxResults;

    // 翻页Id
    @NameInMap("nextToken")
    public String nextToken;

    // 发起操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 团队空间Id
    @NameInMap("workspaceId")
    public String workspaceId;

    public static SearchWorkspaceDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspaceDocsRequest self = new SearchWorkspaceDocsRequest();
        return TeaModel.build(map, self);
    }

    public SearchWorkspaceDocsRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchWorkspaceDocsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchWorkspaceDocsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchWorkspaceDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SearchWorkspaceDocsRequest setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

}
