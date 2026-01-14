// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySelfBuildGroupUserInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySelfBuildGroupUserInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySelfBuildGroupUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySelfBuildGroupUserInfoResponseBody self = new QuerySelfBuildGroupUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySelfBuildGroupUserInfoResponseBody setResult(QuerySelfBuildGroupUserInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySelfBuildGroupUserInfoResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySelfBuildGroupUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySelfBuildGroupUserInfoResponseBodyResultUserList extends TeaModel {
        @NameInMap("role")
        public String role;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QuerySelfBuildGroupUserInfoResponseBodyResultUserList build(java.util.Map<String, ?> map) throws Exception {
            QuerySelfBuildGroupUserInfoResponseBodyResultUserList self = new QuerySelfBuildGroupUserInfoResponseBodyResultUserList();
            return TeaModel.build(map, self);
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResultUserList setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResultUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResultUserList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

    public static class QuerySelfBuildGroupUserInfoResponseBodyResult extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("requestId")
        public String requestId;

        @NameInMap("userList")
        public java.util.List<QuerySelfBuildGroupUserInfoResponseBodyResultUserList> userList;

        public static QuerySelfBuildGroupUserInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySelfBuildGroupUserInfoResponseBodyResult self = new QuerySelfBuildGroupUserInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public QuerySelfBuildGroupUserInfoResponseBodyResult setUserList(java.util.List<QuerySelfBuildGroupUserInfoResponseBodyResultUserList> userList) {
            this.userList = userList;
            return this;
        }
        public java.util.List<QuerySelfBuildGroupUserInfoResponseBodyResultUserList> getUserList() {
            return this.userList;
        }

    }

}
