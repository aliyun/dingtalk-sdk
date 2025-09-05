// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SearchFlowResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<String> list;

    @NameInMap("nextCursor")
    public String nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchFlowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFlowResponseBody self = new SearchFlowResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFlowResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchFlowResponseBody setList(java.util.List<String> list) {
        this.list = list;
        return this;
    }
    public java.util.List<String> getList() {
        return this.list;
    }

    public SearchFlowResponseBody setNextCursor(String nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public String getNextCursor() {
        return this.nextCursor;
    }

    public SearchFlowResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
