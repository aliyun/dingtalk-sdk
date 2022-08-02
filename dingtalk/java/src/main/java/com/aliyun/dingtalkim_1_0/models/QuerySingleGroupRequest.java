// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySingleGroupRequest extends TeaModel {
    // 群成员列表。
    @NameInMap("groupMembers")
    public java.util.List<QuerySingleGroupRequestGroupMembers> groupMembers;

    // 群模版Id。
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    public static QuerySingleGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySingleGroupRequest self = new QuerySingleGroupRequest();
        return TeaModel.build(map, self);
    }

    public QuerySingleGroupRequest setGroupMembers(java.util.List<QuerySingleGroupRequestGroupMembers> groupMembers) {
        this.groupMembers = groupMembers;
        return this;
    }
    public java.util.List<QuerySingleGroupRequestGroupMembers> getGroupMembers() {
        return this.groupMembers;
    }

    public QuerySingleGroupRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public static class QuerySingleGroupRequestGroupMembers extends TeaModel {
        // 钉外用户在业务系统内的唯一标识。
        @NameInMap("appUserId")
        public String appUserId;

        // 钉内用户userId。
        @NameInMap("userId")
        public String userId;

        public static QuerySingleGroupRequestGroupMembers build(java.util.Map<String, ?> map) throws Exception {
            QuerySingleGroupRequestGroupMembers self = new QuerySingleGroupRequestGroupMembers();
            return TeaModel.build(map, self);
        }

        public QuerySingleGroupRequestGroupMembers setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public QuerySingleGroupRequestGroupMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
