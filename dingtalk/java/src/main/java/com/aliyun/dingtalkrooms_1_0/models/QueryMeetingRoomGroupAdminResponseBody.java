// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupAdminResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMeetingRoomGroupAdminResponseBodyResult result;

    public static QueryMeetingRoomGroupAdminResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupAdminResponseBody self = new QueryMeetingRoomGroupAdminResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupAdminResponseBody setResult(QueryMeetingRoomGroupAdminResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMeetingRoomGroupAdminResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberName")
        public String memberName;

        public static QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins self = new QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

    }

    public static class QueryMeetingRoomGroupAdminResponseBodyResult extends TeaModel {
        @NameInMap("groupAdmins")
        public java.util.List<QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins> groupAdmins;

        /**
         * <strong>example:</strong>
         * <p>172</p>
         */
        @NameInMap("groupId")
        public Long groupId;

        @NameInMap("groupName")
        public String groupName;

        public static QueryMeetingRoomGroupAdminResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomGroupAdminResponseBodyResult self = new QueryMeetingRoomGroupAdminResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomGroupAdminResponseBodyResult setGroupAdmins(java.util.List<QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins> groupAdmins) {
            this.groupAdmins = groupAdmins;
            return this;
        }
        public java.util.List<QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins> getGroupAdmins() {
            return this.groupAdmins;
        }

        public QueryMeetingRoomGroupAdminResponseBodyResult setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public QueryMeetingRoomGroupAdminResponseBodyResult setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
