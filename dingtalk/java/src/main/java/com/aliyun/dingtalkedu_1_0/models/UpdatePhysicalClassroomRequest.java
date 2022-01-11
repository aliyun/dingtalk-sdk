// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomRequest extends TeaModel {
    // 教室教学楼
    @NameInMap("classroomBuilding")
    public String classroomBuilding;

    // 教室校区
    @NameInMap("classroomCampus")
    public String classroomCampus;

    // 教室楼层
    @NameInMap("classroomFloor")
    public String classroomFloor;

    // 教室id
    @NameInMap("classroomId")
    public Long classroomId;

    // 教室名称
    @NameInMap("classroomName")
    public String classroomName;

    // 教室房间号
    @NameInMap("classroomNumber")
    public String classroomNumber;

    // 是否支持直播
    @NameInMap("directBroadcast")
    public String directBroadcast;

    // 扩展信息
    @NameInMap("ext")
    public String ext;

    // 操作人id
    @NameInMap("opUserId")
    public String opUserId;

    public static UpdatePhysicalClassroomRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePhysicalClassroomRequest self = new UpdatePhysicalClassroomRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePhysicalClassroomRequest setClassroomBuilding(String classroomBuilding) {
        this.classroomBuilding = classroomBuilding;
        return this;
    }
    public String getClassroomBuilding() {
        return this.classroomBuilding;
    }

    public UpdatePhysicalClassroomRequest setClassroomCampus(String classroomCampus) {
        this.classroomCampus = classroomCampus;
        return this;
    }
    public String getClassroomCampus() {
        return this.classroomCampus;
    }

    public UpdatePhysicalClassroomRequest setClassroomFloor(String classroomFloor) {
        this.classroomFloor = classroomFloor;
        return this;
    }
    public String getClassroomFloor() {
        return this.classroomFloor;
    }

    public UpdatePhysicalClassroomRequest setClassroomId(Long classroomId) {
        this.classroomId = classroomId;
        return this;
    }
    public Long getClassroomId() {
        return this.classroomId;
    }

    public UpdatePhysicalClassroomRequest setClassroomName(String classroomName) {
        this.classroomName = classroomName;
        return this;
    }
    public String getClassroomName() {
        return this.classroomName;
    }

    public UpdatePhysicalClassroomRequest setClassroomNumber(String classroomNumber) {
        this.classroomNumber = classroomNumber;
        return this;
    }
    public String getClassroomNumber() {
        return this.classroomNumber;
    }

    public UpdatePhysicalClassroomRequest setDirectBroadcast(String directBroadcast) {
        this.directBroadcast = directBroadcast;
        return this;
    }
    public String getDirectBroadcast() {
        return this.directBroadcast;
    }

    public UpdatePhysicalClassroomRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public UpdatePhysicalClassroomRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
