// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMeetingRoomResponseBodyResult result;

    public static QueryMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomResponseBody self = new QueryMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomResponseBody setResult(QueryMeetingRoomResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMeetingRoomResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>09:00</p>
         */
        @NameInMap("advanceBookTimeFormat")
        public String advanceBookTimeFormat;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("advanceReservationTime")
        public Integer advanceReservationTime;

        /**
         * <strong>example:</strong>
         * <p>days</p>
         */
        @NameInMap("advanceReservationTimeUnit")
        public String advanceReservationTimeUnit;

        public static QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation self = new QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation setAdvanceBookTimeFormat(String advanceBookTimeFormat) {
            this.advanceBookTimeFormat = advanceBookTimeFormat;
            return this;
        }
        public String getAdvanceBookTimeFormat() {
            return this.advanceBookTimeFormat;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation setAdvanceReservationTime(Integer advanceReservationTime) {
            this.advanceReservationTime = advanceReservationTime;
            return this;
        }
        public Integer getAdvanceReservationTime() {
            return this.advanceReservationTime;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation setAdvanceReservationTimeUnit(String advanceReservationTimeUnit) {
            this.advanceReservationTimeUnit = advanceReservationTimeUnit;
            return this;
        }
        public String getAdvanceReservationTimeUnit() {
            return this.advanceReservationTimeUnit;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>因为装修临时关闭预定</p>
         */
        @NameInMap("closeReason")
        public String closeReason;

        /**
         * <strong>example:</strong>
         * <p>nick</p>
         */
        @NameInMap("contactNick")
        public String contactNick;

        /**
         * <strong>example:</strong>
         * <p>2iPOLbpxxxxuwggiiqiPwiEiF</p>
         */
        @NameInMap("contactUnionId")
        public String contactUnionId;

        @NameInMap("sendNotify")
        public Boolean sendNotify;

        /**
         * <strong>example:</strong>
         * <p>1740045030000</p>
         */
        @NameInMap("taskEndTime")
        public Long taskEndTime;

        /**
         * <strong>example:</strong>
         * <p>1740463800000</p>
         */
        @NameInMap("taskStartTime")
        public Long taskStartTime;

        public static QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail self = new QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setCloseReason(String closeReason) {
            this.closeReason = closeReason;
            return this;
        }
        public String getCloseReason() {
            return this.closeReason;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setContactNick(String contactNick) {
            this.contactNick = contactNick;
            return this;
        }
        public String getContactNick() {
            return this.contactNick;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setContactUnionId(String contactUnionId) {
            this.contactUnionId = contactUnionId;
            return this;
        }
        public String getContactUnionId() {
            return this.contactUnionId;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setSendNotify(Boolean sendNotify) {
            this.sendNotify = sendNotify;
            return this;
        }
        public Boolean getSendNotify() {
            return this.sendNotify;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setTaskEndTime(Long taskEndTime) {
            this.taskEndTime = taskEndTime;
            return this;
        }
        public Long getTaskEndTime() {
            return this.taskEndTime;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail setTaskStartTime(Long taskStartTime) {
            this.taskStartTime = taskStartTime;
            return this;
        }
        public Long getTaskStartTime() {
            return this.taskStartTime;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultExtensionConfig extends TeaModel {
        @NameInMap("advanceReservation")
        public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation advanceReservation;

        @NameInMap("approvalSwitch")
        public Boolean approvalSwitch;

        @NameInMap("approvalType")
        public Integer approvalType;

        /**
         * <strong>example:</strong>
         * <p>60</p>
         */
        @NameInMap("maxReservationTimeInterval")
        public Integer maxReservationTimeInterval;

        /**
         * <strong>example:</strong>
         * <p>15</p>
         */
        @NameInMap("minReservationTimeInterval")
        public Integer minReservationTimeInterval;

        @NameInMap("openReservation")
        public Boolean openReservation;

        @NameInMap("reservationCloseDetail")
        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail reservationCloseDetail;

        public static QueryMeetingRoomResponseBodyResultExtensionConfig build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultExtensionConfig self = new QueryMeetingRoomResponseBodyResultExtensionConfig();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setAdvanceReservation(QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation advanceReservation) {
            this.advanceReservation = advanceReservation;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation getAdvanceReservation() {
            return this.advanceReservation;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setApprovalSwitch(Boolean approvalSwitch) {
            this.approvalSwitch = approvalSwitch;
            return this;
        }
        public Boolean getApprovalSwitch() {
            return this.approvalSwitch;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setApprovalType(Integer approvalType) {
            this.approvalType = approvalType;
            return this;
        }
        public Integer getApprovalType() {
            return this.approvalType;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setMaxReservationTimeInterval(Integer maxReservationTimeInterval) {
            this.maxReservationTimeInterval = maxReservationTimeInterval;
            return this;
        }
        public Integer getMaxReservationTimeInterval() {
            return this.maxReservationTimeInterval;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setMinReservationTimeInterval(Integer minReservationTimeInterval) {
            this.minReservationTimeInterval = minReservationTimeInterval;
            return this;
        }
        public Integer getMinReservationTimeInterval() {
            return this.minReservationTimeInterval;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setOpenReservation(Boolean openReservation) {
            this.openReservation = openReservation;
            return this;
        }
        public Boolean getOpenReservation() {
            return this.openReservation;
        }

        public QueryMeetingRoomResponseBodyResultExtensionConfig setReservationCloseDetail(QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail reservationCloseDetail) {
            this.reservationCloseDetail = reservationCloseDetail;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail getReservationCloseDetail() {
            return this.reservationCloseDetail;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>lPHhSZDLXXXXXXpBlC9lxLwiEiE</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("memberName")
        public String memberName;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("memberType")
        public String memberType;

        public static QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers self = new QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultReservationAuthority extends TeaModel {
        @NameInMap("authorizedMembers")
        public java.util.List<QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers> authorizedMembers;

        public static QueryMeetingRoomResponseBodyResultReservationAuthority build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultReservationAuthority self = new QueryMeetingRoomResponseBodyResultReservationAuthority();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultReservationAuthority setAuthorizedMembers(java.util.List<QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers> authorizedMembers) {
            this.authorizedMembers = authorizedMembers;
            return this;
        }
        public java.util.List<QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers> getAuthorizedMembers() {
            return this.authorizedMembers;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultRoomGroup extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("groupId")
        public Long groupId;

        /**
         * <strong>example:</strong>
         * <p>测试分组</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("parentId")
        public Long parentId;

        public static QueryMeetingRoomResponseBodyResultRoomGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomGroup self = new QueryMeetingRoomResponseBodyResultRoomGroup();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultRoomLabels extends TeaModel {
        @NameInMap("labelId")
        public Long labelId;

        @NameInMap("labelName")
        public String labelName;

        public static QueryMeetingRoomResponseBodyResultRoomLabels build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomLabels self = new QueryMeetingRoomResponseBodyResultRoomLabels();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomLabels setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public QueryMeetingRoomResponseBodyResultRoomLabels setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultRoomLocation extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xx市xx区xx街道xx号</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>xxx公司</p>
         */
        @NameInMap("title")
        public String title;

        public static QueryMeetingRoomResponseBodyResultRoomLocation build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomLocation self = new QueryMeetingRoomResponseBodyResultRoomLocation();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomLocation setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryMeetingRoomResponseBodyResultRoomLocation setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryMeetingRoomResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding994a046bca84545935c2f4657eb6378f</p>
         */
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deviceUnionIds")
        public java.util.List<String> deviceUnionIds;

        @NameInMap("enableCycleReservation")
        public Boolean enableCycleReservation;

        @NameInMap("extensionConfig")
        public QueryMeetingRoomResponseBodyResultExtensionConfig extensionConfig;

        /**
         * <strong>example:</strong>
         * <p>xxxIsvRoomId</p>
         */
        @NameInMap("isvRoomId")
        public String isvRoomId;

        @NameInMap("reservationAuthority")
        public QueryMeetingRoomResponseBodyResultReservationAuthority reservationAuthority;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        @NameInMap("roomGroup")
        public QueryMeetingRoomResponseBodyResultRoomGroup roomGroup;

        /**
         * <strong>example:</strong>
         * <p>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</p>
         */
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels;

        @NameInMap("roomLocation")
        public QueryMeetingRoomResponseBodyResultRoomLocation roomLocation;

        /**
         * <strong>example:</strong>
         * <p>测试会议室</p>
         */
        @NameInMap("roomName")
        public String roomName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg">https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg</a></p>
         */
        @NameInMap("roomPicture")
        public String roomPicture;

        /**
         * <strong>example:</strong>
         * <p>01224148194623278976</p>
         */
        @NameInMap("roomStaffId")
        public String roomStaffId;

        /**
         * <strong>example:</strong>
         * <p>0.全员可用 1.仅管理员可用</p>
         */
        @NameInMap("roomStatus")
        public Integer roomStatus;

        /**
         * <strong>example:</strong>
         * <p>DtB8VDzXXXXXX41rgiE</p>
         */
        @NameInMap("roomUnionId")
        public String roomUnionId;

        public static QueryMeetingRoomResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResult self = new QueryMeetingRoomResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomResponseBodyResult setDeviceUnionIds(java.util.List<String> deviceUnionIds) {
            this.deviceUnionIds = deviceUnionIds;
            return this;
        }
        public java.util.List<String> getDeviceUnionIds() {
            return this.deviceUnionIds;
        }

        public QueryMeetingRoomResponseBodyResult setEnableCycleReservation(Boolean enableCycleReservation) {
            this.enableCycleReservation = enableCycleReservation;
            return this;
        }
        public Boolean getEnableCycleReservation() {
            return this.enableCycleReservation;
        }

        public QueryMeetingRoomResponseBodyResult setExtensionConfig(QueryMeetingRoomResponseBodyResultExtensionConfig extensionConfig) {
            this.extensionConfig = extensionConfig;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultExtensionConfig getExtensionConfig() {
            return this.extensionConfig;
        }

        public QueryMeetingRoomResponseBodyResult setIsvRoomId(String isvRoomId) {
            this.isvRoomId = isvRoomId;
            return this;
        }
        public String getIsvRoomId() {
            return this.isvRoomId;
        }

        public QueryMeetingRoomResponseBodyResult setReservationAuthority(QueryMeetingRoomResponseBodyResultReservationAuthority reservationAuthority) {
            this.reservationAuthority = reservationAuthority;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultReservationAuthority getReservationAuthority() {
            return this.reservationAuthority;
        }

        public QueryMeetingRoomResponseBodyResult setRoomCapacity(Integer roomCapacity) {
            this.roomCapacity = roomCapacity;
            return this;
        }
        public Integer getRoomCapacity() {
            return this.roomCapacity;
        }

        public QueryMeetingRoomResponseBodyResult setRoomGroup(QueryMeetingRoomResponseBodyResultRoomGroup roomGroup) {
            this.roomGroup = roomGroup;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultRoomGroup getRoomGroup() {
            return this.roomGroup;
        }

        public QueryMeetingRoomResponseBodyResult setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

        public QueryMeetingRoomResponseBodyResult setRoomLabels(java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels) {
            this.roomLabels = roomLabels;
            return this;
        }
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> getRoomLabels() {
            return this.roomLabels;
        }

        public QueryMeetingRoomResponseBodyResult setRoomLocation(QueryMeetingRoomResponseBodyResultRoomLocation roomLocation) {
            this.roomLocation = roomLocation;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultRoomLocation getRoomLocation() {
            return this.roomLocation;
        }

        public QueryMeetingRoomResponseBodyResult setRoomName(String roomName) {
            this.roomName = roomName;
            return this;
        }
        public String getRoomName() {
            return this.roomName;
        }

        public QueryMeetingRoomResponseBodyResult setRoomPicture(String roomPicture) {
            this.roomPicture = roomPicture;
            return this;
        }
        public String getRoomPicture() {
            return this.roomPicture;
        }

        public QueryMeetingRoomResponseBodyResult setRoomStaffId(String roomStaffId) {
            this.roomStaffId = roomStaffId;
            return this;
        }
        public String getRoomStaffId() {
            return this.roomStaffId;
        }

        public QueryMeetingRoomResponseBodyResult setRoomStatus(Integer roomStatus) {
            this.roomStatus = roomStatus;
            return this;
        }
        public Integer getRoomStatus() {
            return this.roomStatus;
        }

        public QueryMeetingRoomResponseBodyResult setRoomUnionId(String roomUnionId) {
            this.roomUnionId = roomUnionId;
            return this;
        }
        public String getRoomUnionId() {
            return this.roomUnionId;
        }

    }

}
