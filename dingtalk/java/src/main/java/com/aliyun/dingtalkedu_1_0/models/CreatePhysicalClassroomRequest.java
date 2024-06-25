// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>主楼</p>
     */
    @NameInMap("classroomBuilding")
    public String classroomBuilding;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>主校区</p>
     */
    @NameInMap("classroomCampus")
    public String classroomCampus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2层</p>
     */
    @NameInMap("classroomFloor")
    public String classroomFloor;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>实验室</p>
     */
    @NameInMap("classroomName")
    public String classroomName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>201</p>
     */
    @NameInMap("classroomNumber")
    public String classroomNumber;

    /**
     * <p>This parameter is required.</p>
     * 
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manger1234</p>
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
