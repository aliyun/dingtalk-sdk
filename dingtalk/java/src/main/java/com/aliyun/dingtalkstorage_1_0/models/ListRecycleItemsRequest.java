// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleItemsRequest extends TeaModel {
    // 分页大小, 不保证全量返回
    // 默认值:
    // 	50
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，首次拉取nextToken传空
    @NameInMap("nextToken")
    public String nextToken;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static ListRecycleItemsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleItemsRequest self = new ListRecycleItemsRequest();
        return TeaModel.build(map, self);
    }

    public ListRecycleItemsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListRecycleItemsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecycleItemsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
