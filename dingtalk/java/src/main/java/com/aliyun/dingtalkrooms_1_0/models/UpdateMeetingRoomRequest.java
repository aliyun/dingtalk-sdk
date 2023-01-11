// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomRequest extends TeaModel {
    /**
     * <p>会议室所属分组id</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>isv外部会议室id</p>
     */
    @NameInMap("isvRoomId")
    public String isvRoomId;

    /**
     * <p>会议室容量</p>
     */
    @NameInMap("roomCapacity")
    public Integer roomCapacity;

    /**
     * <p>会议室id</p>
     */
    @NameInMap("roomId")
    public String roomId;

    /**
     * <p>会议室标签</p>
     */
    @NameInMap("roomLabelIds")
    public java.util.List<Long> roomLabelIds;

    /**
     * <p>会议室位置</p>
     */
    @NameInMap("roomLocation")
    public UpdateMeetingRoomRequestRoomLocation roomLocation;

    /**
     * <p>会议室名称</p>
     */
    @NameInMap("roomName")
    public String roomName;

    /**
     * <p>会议室图片</p>
     */
    @NameInMap("roomPicture")
    public String roomPicture;

    /**
     * <p>会议室状态</p>
     */
    @NameInMap("roomStatus")
    public Integer roomStatus;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomRequest self = new UpdateMeetingRoomRequest();
        return TeaModel.build(map, self);
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

    public static class UpdateMeetingRoomRequestRoomLocation extends TeaModel {
        /**
         * <p>位置详细信息</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <p>位置标题</p>
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
