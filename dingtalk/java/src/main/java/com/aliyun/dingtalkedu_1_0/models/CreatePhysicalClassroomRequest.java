// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomRequest extends TeaModel {
    /**
     * <p>教室教学楼</p>
     */
    @NameInMap("classroomBuilding")
    public String classroomBuilding;

    /**
     * <p>教室校区</p>
     */
    @NameInMap("classroomCampus")
    public String classroomCampus;

    /**
     * <p>教室楼层</p>
     */
    @NameInMap("classroomFloor")
    public String classroomFloor;

    /**
     * <p>教室名称</p>
     */
    @NameInMap("classroomName")
    public String classroomName;

    /**
     * <p>教室房间号</p>
     */
    @NameInMap("classroomNumber")
    public String classroomNumber;

    /**
     * <p>是否支持直播</p>
     */
    @NameInMap("directBroadcast")
    public String directBroadcast;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>opUserId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static CreatePhysicalClassroomRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePhysicalClassroomRequest self = new CreatePhysicalClassroomRequest();
        return TeaModel.build(map, self);
    }

    public CreatePhysicalClassroomRequest setClassroomBuilding(String classroomBuilding) {
        this.classroomBuilding = classroomBuilding;
        return this;
    }
    public String getClassroomBuilding() {
        return this.classroomBuilding;
    }

    public CreatePhysicalClassroomRequest setClassroomCampus(String classroomCampus) {
        this.classroomCampus = classroomCampus;
        return this;
    }
    public String getClassroomCampus() {
        return this.classroomCampus;
    }

    public CreatePhysicalClassroomRequest setClassroomFloor(String classroomFloor) {
        this.classroomFloor = classroomFloor;
        return this;
    }
    public String getClassroomFloor() {
        return this.classroomFloor;
    }

    public CreatePhysicalClassroomRequest setClassroomName(String classroomName) {
        this.classroomName = classroomName;
        return this;
    }
    public String getClassroomName() {
        return this.classroomName;
    }

    public CreatePhysicalClassroomRequest setClassroomNumber(String classroomNumber) {
        this.classroomNumber = classroomNumber;
        return this;
    }
    public String getClassroomNumber() {
        return this.classroomNumber;
    }

    public CreatePhysicalClassroomRequest setDirectBroadcast(String directBroadcast) {
        this.directBroadcast = directBroadcast;
        return this;
    }
    public String getDirectBroadcast() {
        return this.directBroadcast;
    }

    public CreatePhysicalClassroomRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreatePhysicalClassroomRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
