// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySingleGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1745****8777</p>
     */
    @NameInMap("groupMembers")
    public java.util.List<QuerySingleGroupRequestGroupMembers> groupMembers;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>14da****2760</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1107****2120</p>
         */
        @NameInMap("appUserId")
        public String appUserId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1745****8778</p>
         */
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
