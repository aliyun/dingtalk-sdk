// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RelatedSpacesResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据。</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("items")
    public java.util.List<SpaceModel> items;

    /**
     * <p>分页游标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static RelatedSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RelatedSpacesResponseBody self = new RelatedSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public RelatedSpacesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public RelatedSpacesResponseBody setItems(java.util.List<SpaceModel> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SpaceModel> getItems() {
        return this.items;
    }

    public RelatedSpacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
