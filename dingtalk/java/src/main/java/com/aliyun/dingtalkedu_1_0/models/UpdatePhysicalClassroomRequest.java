// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>主楼</p>
     */
    @NameInMap("classroomBuilding")
    public String classroomBuilding;

    /**
     * <strong>example:</strong>
     * <p>主校区</p>
     */
    @NameInMap("classroomCampus")
    public String classroomCampus;

    /**
     * <strong>example:</strong>
     * <p>3层</p>
     */
    @NameInMap("classroomFloor")
    public String classroomFloor;

    /**
     * <strong>example:</strong>
     * <p>10001</p>
     */
    @NameInMap("classroomId")
    public Long classroomId;

    /**
     * <strong>example:</strong>
     * <p>实验室</p>
     */
    @NameInMap("classroomName")
    public String classroomName;

    /**
     * <strong>example:</strong>
     * <p>301</p>
     */
    @NameInMap("classroomNumber")
    public String classroomNumber;

    /**
     * <strong>example:</strong>
     * <p>Y</p>
     */
    @NameInMap("directBroadcast")
    public String directBroadcast;

    /**
     * <strong>example:</strong>
     * <p>{}</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <strong>example:</strong>
     * <p>manger1234</p>
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
