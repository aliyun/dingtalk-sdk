// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchDepartmentResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<Long> list;

    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchDepartmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchDepartmentResponseBody self = new SearchDepartmentResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchDepartmentResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchDepartmentResponseBody setList(java.util.List<Long> list) {
        this.list = list;
        return this;
    }
    public java.util.List<Long> getList() {
        return this.list;
    }

    public SearchDepartmentResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
