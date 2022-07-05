// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetSpaceDirectoriesResponseBody extends TeaModel {
    // 子节点列表。
    @NameInMap("children")
    public java.util.List<DentryModel> children;

    // 是否还有后续可查询子节点。
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 分页token。
    @NameInMap("nextToken")
    public String nextToken;

    public static GetSpaceDirectoriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceDirectoriesResponseBody self = new GetSpaceDirectoriesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceDirectoriesResponseBody setChildren(java.util.List<DentryModel> children) {
        this.children = children;
        return this;
    }
    public java.util.List<DentryModel> getChildren() {
        return this.children;
    }

    public GetSpaceDirectoriesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetSpaceDirectoriesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
