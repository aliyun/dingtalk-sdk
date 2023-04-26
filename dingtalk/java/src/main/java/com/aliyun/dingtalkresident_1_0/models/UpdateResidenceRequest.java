// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidenceRequest extends TeaModel {
    @NameInMap("departmentId")
    public Long departmentId;

    @NameInMap("departmentName")
    public String departmentName;

    @NameInMap("destitute")
    public Boolean destitute;

    @NameInMap("grid")
    public String grid;

    @NameInMap("homeTel")
    public String homeTel;

    @NameInMap("managerUserId")
    public String managerUserId;

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
