// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidenceRequest extends TeaModel {
    /**
     * <p>组id</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    /**
     * <p>户名字</p>
     */
    @NameInMap("departmentName")
    public String departmentName;

    /**
     * <p>是否是贫困户</p>
     */
    @NameInMap("destitute")
    public Boolean destitute;

    /**
     * <p>所属网格</p>
     */
    @NameInMap("grid")
    public String grid;

    /**
     * <p>家庭电话</p>
     */
    @NameInMap("homeTel")
    public String homeTel;

    /**
     * <p>家庭管理员用户id</p>
     */
    @NameInMap("managerUserId")
    public String managerUserId;

    /**
     * <p>组id</p>
     */
    @NameInMap("parentDepartmentId")
    public Long parentDepartmentId;

    public static UpdateResidenceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidenceRequest self = new UpdateResidenceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidenceRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public UpdateResidenceRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public UpdateResidenceRequest setDestitute(Boolean destitute) {
        this.destitute = destitute;
        return this;
    }
    public Boolean getDestitute() {
        return this.destitute;
    }

    public UpdateResidenceRequest setGrid(String grid) {
        this.grid = grid;
        return this;
    }
    public String getGrid() {
        return this.grid;
    }

    public UpdateResidenceRequest setHomeTel(String homeTel) {
        this.homeTel = homeTel;
        return this;
    }
    public String getHomeTel() {
        return this.homeTel;
    }

    public UpdateResidenceRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public UpdateResidenceRequest setParentDepartmentId(Long parentDepartmentId) {
        this.parentDepartmentId = parentDepartmentId;
        return this;
    }
    public Long getParentDepartmentId() {
        return this.parentDepartmentId;
    }

}
