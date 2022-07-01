// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListResponseBody extends TeaModel {
    // 是否还有更多数据。
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 分页游标。
    @NameInMap("nextToken")
    public String nextToken;

    // 子节点列表。
    @NameInMap("recentList")
    public java.util.List<QueryRecentListResponseBodyRecentList> recentList;

    public static QueryRecentListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentListResponseBody self = new QueryRecentListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRecentListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryRecentListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRecentListResponseBody setRecentList(java.util.List<QueryRecentListResponseBodyRecentList> recentList) {
        this.recentList = recentList;
        return this;
    }
    public java.util.List<QueryRecentListResponseBodyRecentList> getRecentList() {
        return this.recentList;
    }

    public static class QueryRecentListResponseBodyRecentList extends TeaModel {
        // 是否被删除。
        @NameInMap("deleted")
        public Boolean deleted;

        // 节点信息。
        @NameInMap("dentry")
        public DentryOpenVO dentry;

        // 如果查询的是访问，那么这里是访问时间；否则就是编辑时间。
        @NameInMap("recentTime")
        public Long recentTime;

        public static QueryRecentListResponseBodyRecentList build(java.util.Map<String, ?> map) throws Exception {
            QueryRecentListResponseBodyRecentList self = new QueryRecentListResponseBodyRecentList();
            return TeaModel.build(map, self);
        }

        public QueryRecentListResponseBodyRecentList setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public QueryRecentListResponseBodyRecentList setDentry(DentryOpenVO dentry) {
            this.dentry = dentry;
            return this;
        }
        public DentryOpenVO getDentry() {
            return this.dentry;
        }

        public QueryRecentListResponseBodyRecentList setRecentTime(Long recentTime) {
            this.recentTime = recentTime;
            return this;
        }
        public Long getRecentTime() {
            return this.recentTime;
        }

    }

}
