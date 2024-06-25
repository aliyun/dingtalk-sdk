// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomRequest extends TeaModel {
    @NameInMap("enableCycleReservation")
    public Boolean enableCycleReservation;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <strong>example:</strong>
     * <p>xxxIsvRoomId</p>
     */
    @NameInMap("isvRoomId")
    public String isvRoomId;

    @NameInMap("reservationAuthority")
    public UpdateMeetingRoomRequestReservationAuthority reservationAuthority;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("roomCapacity")
    public Integer roomCapacity;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</p>
     */
    @NameInMap("roomId")
    public String roomId;

    @NameInMap("roomLabelIds")
    public java.util.List<Long> roomLabelIds;

    @NameInMap("roomLocation")
    public UpdateMeetingRoomRequestRoomLocation roomLocation;

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
     * <p>0.全员可用 1.仅管理员可用</p>
     */
    @NameInMap("roomStatus")
    public Integer roomStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomRequest self = new UpdateMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMeetingRoomRequest setEnableCycleReservation(Boolean enableCycleReservation) {
        this.enableCycleReservation = enableCycleReservation;
        return this;
    }
    public Boolean getEnableCycleReservation() {
        return this.enableCycleReservation;
    }

    public UpdateMeetingRoomRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public UpdateMeetingRoomRequest setIsvRoomId(String isvRoomId) {
        this.isvRoomId = isvRoomId;
        return this;
    }
    public String getIsvRoomId() {
        return this.isvRoomId;
    }

    public UpdateMeetingRoomRequest setReservationAuthority(UpdateMeetingRoomRequestReservationAuthority reservationAuthority) {
        this.reservationAuthority = reservationAuthority;
        return this;
    }
    public UpdateMeetingRoomRequestReservationAuthority getReservationAuthority() {
        return this.reservationAuthority;
    }

    public UpdateMeetingRoomRequest setRoomCapacity(Integer roomCapacity) {
        this.roomCapacity = roomCapacity;
        return this;
    }
    public Integer getRoomCapacity() {
        return this.roomCapacity;
    }

    public UpdateMeetingRoomRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public UpdateMeetingRoomRequest setRoomLabelIds(java.util.List<Long> roomLabelIds) {
        this.roomLabelIds = roomLabelIds;
        return this;
    }
    public java.util.List<Long> getRoomLabelIds() {
        return this.roomLabelIds;
    }

    public UpdateMeetingRoomRequest setRoomLocation(UpdateMeetingRoomRequestRoomLocation roomLocation) {
        this.roomLocation = roomLocation;
        return this;
    }
    public UpdateMeetingRoomRequestRoomLocation getRoomLocation() {
        return this.roomLocation;
    }

    public UpdateMeetingRoomRequest setRoomName(String roomName) {
        this.roomName = roomName;
        return this;
    }
    public String getRoomName() {
        return this.roomName;
    }

    public UpdateMeetingRoomRequest setRoomPicture(String roomPicture) {
        this.roomPicture = roomPicture;
        return this;
    }
    public String getRoomPicture() {
        return this.roomPicture;
    }

    public UpdateMeetingRoomRequest setRoomStatus(Integer roomStatus) {
        this.roomStatus = roomStatus;
        return this;
    }
    public Integer getRoomStatus() {
        return this.roomStatus;
    }

    public UpdateMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers extends TeaModel {
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

        public static UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers self = new UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers();
            return TeaModel.build(map, self);
        }

        public UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class UpdateMeetingRoomRequestReservationAuthority extends TeaModel {
        @NameInMap("authorizedMembers")
        public java.util.List<UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers> authorizedMembers;

        public static UpdateMeetingRoomRequestReservationAuthority build(java.util.Map<String, ?> map) throws Exception {
            UpdateMeetingRoomRequestReservationAuthority self = new UpdateMeetingRoomRequestReservationAuthority();
            return TeaModel.build(map, self);
        }

        public UpdateMeetingRoomRequestReservationAuthority setAuthorizedMembers(java.util.List<UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers> authorizedMembers) {
            this.authorizedMembers = authorizedMembers;
            return this;
        }
        public java.util.List<UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers> getAuthorizedMembers() {
            return this.authorizedMembers;
        }

    }

    public static class UpdateMeetingRoomRequestRoomLocation extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xx市xx区xx路xx号</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>xxx公司</p>
         */
        @NameInMap("title")
        public String title;

        public static UpdateMeetingRoomRequestRoomLocation build(java.util.Map<String, ?> map) throws Exception {
            UpdateMeetingRoomRequestRoomLocation self = new UpdateMeetingRoomRequestRoomLocation();
            return TeaModel.build(map, self);
        }

        public UpdateMeetingRoomRequestRoomLocation setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public UpdateMeetingRoomRequestRoomLocation setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
