// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryDismissionStaffIdListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static QueryDismissionStaffIdListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDismissionStaffIdListResponseBody self = new QueryDismissionStaffIdListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDismissionStaffIdListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryDismissionStaffIdListResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryDismissionStaffIdListResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
