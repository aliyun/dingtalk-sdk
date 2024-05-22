// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryInnerGroupMemberListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryInnerGroupMemberListResponseBodyList> list;

    @NameInMap("nextToken")
    public Integer nextToken;

    @NameInMap("success")
    public Boolean success;

    public static QueryInnerGroupMemberListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInnerGroupMemberListResponseBody self = new QueryInnerGroupMemberListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInnerGroupMemberListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryInnerGroupMemberListResponseBody setList(java.util.List<QueryInnerGroupMemberListResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryInnerGroupMemberListResponseBodyList> getList() {
        return this.list;
    }

    public QueryInnerGroupMemberListResponseBody setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public QueryInnerGroupMemberListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryInnerGroupMemberListResponseBodyList extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("name")
        public String name;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("userId")
        public String userId;

        public static QueryInnerGroupMemberListResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryInnerGroupMemberListResponseBodyList self = new QueryInnerGroupMemberListResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryInnerGroupMemberListResponseBodyList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryInnerGroupMemberListResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryInnerGroupMemberListResponseBodyList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryInnerGroupMemberListResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
