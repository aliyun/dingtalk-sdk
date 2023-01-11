// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomRequest extends TeaModel {
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
     * <p>教室id</p>
     */
    @NameInMap("classroomId")
    public Long classroomId;

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
     * <p>操作人id</p>
     */
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
