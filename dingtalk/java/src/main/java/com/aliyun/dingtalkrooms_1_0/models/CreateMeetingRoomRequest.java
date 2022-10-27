// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomRequest extends TeaModel {
    // 分组id
    @NameInMap("groupId")
    public Long groupId;

    // isv外部会议室id
    @NameInMap("isvRoomId")
    public String isvRoomId;

    // 会议室容量
    @NameInMap("roomCapacity")
    public Integer roomCapacity;

    // 会议室标签
    @NameInMap("roomLabelIds")
    public java.util.List<Long> roomLabelIds;

    // 会议室位置
    @NameInMap("roomLocation")
    public CreateMeetingRoomRequestRoomLocation roomLocation;

    // 会议室名称
    @NameInMap("roomName")
    public String roomName;

    // 会议室图片
    @NameInMap("roomPicture")
    public String roomPicture;

    // 会议室状态
    @NameInMap("roomStatus")
    public Integer roomStatus;

    // 操作人unionId
    @NameInMap("unionId")
    public String unionId;

    public static CreateMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomRequest self = new CreateMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public CreateMeetingRoomRequest setIsvRoomId(String isvRoomId) {
        this.isvRoomId = isvRoomId;
        return this;
    }
    public String getIsvRoomId() {
        return this.isvRoomId;
    }

    public CreateMeetingRoomRequest setRoomCapacity(Integer roomCapacity) {
        this.roomCapacity = roomCapacity;
        return this;
    }
    public Integer getRoomCapacity() {
        return this.roomCapacity;
    }

    public CreateMeetingRoomRequest setRoomLabelIds(java.util.List<Long> roomLabelIds) {
        this.roomLabelIds = roomLabelIds;
        return this;
    }
    public java.util.List<Long> getRoomLabelIds() {
        return this.roomLabelIds;
    }

    public CreateMeetingRoomRequest setRoomLocation(CreateMeetingRoomRequestRoomLocation roomLocation) {
        this.roomLocation = roomLocation;
        return this;
    }
    public CreateMeetingRoomRequestRoomLocation getRoomLocation() {
        return this.roomLocation;
    }

    public CreateMeetingRoomRequest setRoomName(String roomName) {
        this.roomName = roomName;
        return this;
    }
    public String getRoomName() {
        return this.roomName;
    }

    public CreateMeetingRoomRequest setRoomPicture(String roomPicture) {
        this.roomPicture = roomPicture;
        return this;
    }
    public String getRoomPicture() {
        return this.roomPicture;
    }

    public CreateMeetingRoomRequest setRoomStatus(Integer roomStatus) {
        this.roomStatus = roomStatus;
        return this;
    }
    public Integer getRoomStatus() {
        return this.roomStatus;
    }

    public CreateMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateMeetingRoomRequestRoomLocation extends TeaModel {
        // 位置详细信息
        @NameInMap("desc")
        public String desc;

        // 纬度
        @NameInMap("latitude")
        public String latitude;

        // 经度
        @NameInMap("longitude")
        public String longitude;

        // 位置标题
        @NameInMap("title")
        public String title;

        public static CreateMeetingRoomRequestRoomLocation build(java.util.Map<String, ?> map) throws Exception {
            CreateMeetingRoomRequestRoomLocation self = new CreateMeetingRoomRequestRoomLocation();
            return TeaModel.build(map, self);
        }

        public CreateMeetingRoomRequestRoomLocation setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public CreateMeetingRoomRequestRoomLocation setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public CreateMeetingRoomRequestRoomLocation setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public CreateMeetingRoomRequestRoomLocation setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
