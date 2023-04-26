// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

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

    public static class QueryRecentListResponseBodyRecentListTeam extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static QueryRecentListResponseBodyRecentListTeam build(java.util.Map<String, ?> map) throws Exception {
            QueryRecentListResponseBodyRecentListTeam self = new QueryRecentListResponseBodyRecentListTeam();
            return TeaModel.build(map, self);
        }

        public QueryRecentListResponseBodyRecentListTeam setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryRecentListResponseBodyRecentListTeam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryRecentListResponseBodyRecentList extends TeaModel {
        @NameInMap("deleted")
        public Boolean deleted;

        @NameInMap("dentry")
        public DentryModel dentry;

        @NameInMap("recentTime")
        public Long recentTime;

        @NameInMap("team")
        public QueryRecentListResponseBodyRecentListTeam team;

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

        public QueryRecentListResponseBodyRecentList setDentry(DentryModel dentry) {
            this.dentry = dentry;
            return this;
        }
        public DentryModel getDentry() {
            return this.dentry;
        }

        public QueryRecentListResponseBodyRecentList setRecentTime(Long recentTime) {
            this.recentTime = recentTime;
            return this;
        }
        public Long getRecentTime() {
            return this.recentTime;
        }

        public QueryRecentListResponseBodyRecentList setTeam(QueryRecentListResponseBodyRecentListTeam team) {
            this.team = team;
            return this;
        }
        public QueryRecentListResponseBodyRecentListTeam getTeam() {
            return this.team;
        }

    }

}
