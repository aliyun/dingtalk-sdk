// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidenceRequest extends TeaModel {
    // 家庭管理员用户id
    @NameInMap("managerUserId")
    public String managerUserId;

    // 户名字
    @NameInMap("departmentName")
    public String departmentName;

    // 组id
    @NameInMap("departmentId")
    public Long departmentId;

    // 所属网格
    @NameInMap("grid")
    public String grid;

    // 家庭电话
    @NameInMap("homeTel")
    public String homeTel;

    // 是否是贫困户
    @NameInMap("destitute")
    public Boolean destitute;

    // 组id
    @NameInMap("parentDepartmentId")
    public Long parentDepartmentId;

    public static UpdateResidenceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidenceRequest self = new UpdateResidenceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidenceRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public UpdateResidenceRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public UpdateResidenceRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
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

    public UpdateResidenceRequest setDestitute(Boolean destitute) {
        this.destitute = destitute;
        return this;
    }
    public Boolean getDestitute() {
        return this.destitute;
    }

    public UpdateResidenceRequest setParentDepartmentId(Long parentDepartmentId) {
        this.parentDepartmentId = parentDepartmentId;
        return this;
    }
    public Long getParentDepartmentId() {
        return this.parentDepartmentId;
    }

}
