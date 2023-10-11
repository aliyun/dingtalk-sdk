// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleMemberByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryRoleMemberByPageResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryRoleMemberByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRoleMemberByPageResponseBody self = new QueryRoleMemberByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRoleMemberByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryRoleMemberByPageResponseBody setList(java.util.List<QueryRoleMemberByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryRoleMemberByPageResponseBodyList> getList() {
        return this.list;
    }

    public QueryRoleMemberByPageResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryRoleMemberByPageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryRoleMemberByPageResponseBodyList extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("nick")
        public String nick;

        @NameInMap("userId")
        public String userId;

        public static QueryRoleMemberByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryRoleMemberByPageResponseBodyList self = new QueryRoleMemberByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryRoleMemberByPageResponseBodyList setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryRoleMemberByPageResponseBodyList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryRoleMemberByPageResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
