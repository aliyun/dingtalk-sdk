// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SearchInnerGroupsRequest extends TeaModel {
    /**
     * <p>查询最大数量。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>关键词。</p>
     */
    @NameInMap("searchKey")
    public String searchKey;

    /**
     * <p>用户userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SearchInnerGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchInnerGroupsRequest self = new SearchInnerGroupsRequest();
        return TeaModel.build(map, self);
    }

    public SearchInnerGroupsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchInnerGroupsRequest setSearchKey(String searchKey) {
        this.searchKey = searchKey;
        return this;
    }
    public String getSearchKey() {
        return this.searchKey;
    }

    public SearchInnerGroupsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
