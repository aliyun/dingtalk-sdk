// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedTeamsResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据。</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>小组列表。</p>
     */
    @NameInMap("items")
    public java.util.List<TeamModel> items;

    /**
     * <p>分页游标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static ListRelatedTeamsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedTeamsResponseBody self = new ListRelatedTeamsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRelatedTeamsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListRelatedTeamsResponseBody setItems(java.util.List<TeamModel> items) {
        this.items = items;
        return this;
    }
    public java.util.List<TeamModel> getItems() {
        return this.items;
    }

    public ListRelatedTeamsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
