// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUsersResponseBody extends TeaModel {
    @NameInMap("activeUserInfos")
    public java.util.List<QueryActiveUsersResponseBodyActiveUserInfos> activeUserInfos;

    public static QueryActiveUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUsersResponseBody self = new QueryActiveUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryActiveUsersResponseBody setActiveUserInfos(java.util.List<QueryActiveUsersResponseBodyActiveUserInfos> activeUserInfos) {
        this.activeUserInfos = activeUserInfos;
        return this;
    }
    public java.util.List<QueryActiveUsersResponseBodyActiveUserInfos> getActiveUserInfos() {
        return this.activeUserInfos;
    }

    public static class QueryActiveUsersResponseBodyActiveUserInfos extends TeaModel {
        @NameInMap("actionIndexL14d")
        public Double actionIndexL14d;

        @NameInMap("actionIndexL30d")
        public Double actionIndexL30d;

        @NameInMap("actionIndexL7d")
        public Double actionIndexL7d;

        @NameInMap("activeScore")
        public Double activeScore;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("ranking")
        public Long ranking;

        @NameInMap("unionId")
        public String unionId;

        public static QueryActiveUsersResponseBodyActiveUserInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryActiveUsersResponseBodyActiveUserInfos self = new QueryActiveUsersResponseBodyActiveUserInfos();
            return TeaModel.build(map, self);
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setActionIndexL14d(Double actionIndexL14d) {
            this.actionIndexL14d = actionIndexL14d;
            return this;
        }
        public Double getActionIndexL14d() {
            return this.actionIndexL14d;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setActionIndexL30d(Double actionIndexL30d) {
            this.actionIndexL30d = actionIndexL30d;
            return this;
        }
        public Double getActionIndexL30d() {
            return this.actionIndexL30d;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setActionIndexL7d(Double actionIndexL7d) {
            this.actionIndexL7d = actionIndexL7d;
            return this;
        }
        public Double getActionIndexL7d() {
            return this.actionIndexL7d;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setActiveScore(Double activeScore) {
            this.activeScore = activeScore;
            return this;
        }
        public Double getActiveScore() {
            return this.activeScore;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setRanking(Long ranking) {
            this.ranking = ranking;
            return this;
        }
        public Long getRanking() {
            return this.ranking;
        }

        public QueryActiveUsersResponseBodyActiveUserInfos setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
