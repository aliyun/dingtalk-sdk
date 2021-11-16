// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsRequest extends TeaModel {
    // 发起操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 搜索关键字
    @NameInMap("keyword")
    public String keyword;

    // 搜索数量
    @NameInMap("size")
    public Integer size;

    // 翻页Id
    @NameInMap("loadMoreId")
    public String loadMoreId;

    public static SearchWorkspaceDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspaceDocsRequest self = new SearchWorkspaceDocsRequest();
        return TeaModel.build(map, self);
    }

    public SearchWorkspaceDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SearchWorkspaceDocsRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchWorkspaceDocsRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public SearchWorkspaceDocsRequest setLoadMoreId(String loadMoreId) {
        this.loadMoreId = loadMoreId;
        return this;
    }
    public String getLoadMoreId() {
        return this.loadMoreId;
    }

}
