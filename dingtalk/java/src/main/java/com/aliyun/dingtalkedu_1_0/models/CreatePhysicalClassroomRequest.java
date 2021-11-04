// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomRequest extends TeaModel {
    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    // 教室楼层
    @NameInMap("classroomFloor")
    public String classroomFloor;

    // 扩展信息
    @NameInMap("ext")
    public String ext;

    // 教室教学楼
    @NameInMap("classroomBuilding")
    public String classroomBuilding;

    // 是否支持直播
    @NameInMap("directBroadcast")
    public String directBroadcast;

    // 教室名称
    @NameInMap("classroomName")
    public String classroomName;

    // 教室校区
    @NameInMap("classroomCampus")
    public String classroomCampus;

    // 教室房间号
    @NameInMap("classroomNumber")
    public String classroomNumber;

    public static CreatePhysicalClassroomRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePhysicalClassroomRequest self = new CreatePhysicalClassroomRequest();
        return TeaModel.build(map, self);
    }

    public CreatePhysicalClassroomRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreatePhysicalClassroomRequest setClassroomFloor(String classroomFloor) {
        this.classroomFloor = classroomFloor;
        return this;
    }
    public String getClassroomFloor() {
        return this.classroomFloor;
    }

    public CreatePhysicalClassroomRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreatePhysicalClassroomRequest setClassroomBuilding(String classroomBuilding) {
        this.classroomBuilding = classroomBuilding;
        return this;
    }
    public String getClassroomBuilding() {
        return this.classroomBuilding;
    }

    public CreatePhysicalClassroomRequest setDirectBroadcast(String directBroadcast) {
        this.directBroadcast = directBroadcast;
        return this;
    }
    public String getDirectBroadcast() {
        return this.directBroadcast;
    }

    public CreatePhysicalClassroomRequest setClassroomName(String classroomName) {
        this.classroomName = classroomName;
        return this;
    }
    public String getClassroomName() {
        return this.classroomName;
    }

    public CreatePhysicalClassroomRequest setClassroomCampus(String classroomCampus) {
        this.classroomCampus = classroomCampus;
        return this;
    }
    public String getClassroomCampus() {
        return this.classroomCampus;
    }

    public CreatePhysicalClassroomRequest setClassroomNumber(String classroomNumber) {
        this.classroomNumber = classroomNumber;
        return this;
    }
    public String getClassroomNumber() {
        return this.classroomNumber;
    }

}
