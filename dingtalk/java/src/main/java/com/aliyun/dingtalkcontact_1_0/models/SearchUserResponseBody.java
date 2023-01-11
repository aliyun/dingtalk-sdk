// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchUserResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<String> list;

    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchUserResponseBody self = new SearchUserResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchUserResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchUserResponseBody setList(java.util.List<String> list) {
        this.list = list;
        return this;
    }
    public java.util.List<String> getList() {
        return this.list;
    }

    public SearchUserResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
