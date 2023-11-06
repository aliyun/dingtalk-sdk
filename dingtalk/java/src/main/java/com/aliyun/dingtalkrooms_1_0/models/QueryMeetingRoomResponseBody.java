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

    public static class QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberName")
        public String memberName;

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
        @NameInMap("groupId")
        public Long groupId;

        @NameInMap("groupName")
        public String groupName;

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
        @NameInMap("desc")
        public String desc;

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
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deviceUnionIds")
        public java.util.List<String> deviceUnionIds;

        @NameInMap("enableCycleReservation")
        public Boolean enableCycleReservation;

        @NameInMap("isvRoomId")
        public String isvRoomId;

        @NameInMap("reservationAuthority")
        public QueryMeetingRoomResponseBodyResultReservationAuthority reservationAuthority;

        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        @NameInMap("roomGroup")
        public QueryMeetingRoomResponseBodyResultRoomGroup roomGroup;

        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels;

        @NameInMap("roomLocation")
        public QueryMeetingRoomResponseBodyResultRoomLocation roomLocation;

        @NameInMap("roomName")
        public String roomName;

        @NameInMap("roomPicture")
        public String roomPicture;

        @NameInMap("roomStaffId")
        public String roomStaffId;

        @NameInMap("roomStatus")
        public Integer roomStatus;

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

    }

}
