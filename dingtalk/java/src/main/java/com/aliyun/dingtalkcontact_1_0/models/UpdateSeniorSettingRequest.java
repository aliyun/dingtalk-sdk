// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateSeniorSettingRequest extends TeaModel {
    @NameInMap("seniorStaffId")
    public String seniorStaffId;

    @NameInMap("open")
    public Boolean open;

    @NameInMap("permitStaffIds")
    public java.util.List<String> permitStaffIds;

    @NameInMap("permitDeptIds")
    public java.util.List<Long> permitDeptIds;

    @NameInMap("permitTagIds")
    public java.util.List<Long> permitTagIds;

    @NameInMap("protectScenes")
    public java.util.List<String> protectScenes;

    public static UpdateSeniorSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSeniorSettingRequest self = new UpdateSeniorSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSeniorSettingRequest setSeniorStaffId(String seniorStaffId) {
        this.seniorStaffId = seniorStaffId;
        return this;
    }
    public String getSeniorStaffId() {
        return this.seniorStaffId;
    }

    public UpdateSeniorSettingRequest setOpen(Boolean open) {
        this.open = open;
        return this;
    }
    public Boolean getOpen() {
        return this.open;
    }

    public UpdateSeniorSettingRequest setPermitStaffIds(java.util.List<String> permitStaffIds) {
        this.permitStaffIds = permitStaffIds;
        return this;
    }
    public java.util.List<String> getPermitStaffIds() {
        return this.permitStaffIds;
    }

    public UpdateSeniorSettingRequest setPermitDeptIds(java.util.List<Long> permitDeptIds) {
        this.permitDeptIds = permitDeptIds;
        return this;
    }
    public java.util.List<Long> getPermitDeptIds() {
        return this.permitDeptIds;
    }

    public UpdateSeniorSettingRequest setPermitTagIds(java.util.List<Long> permitTagIds) {
        this.permitTagIds = permitTagIds;
        return this;
    }
    public java.util.List<Long> getPermitTagIds() {
        return this.permitTagIds;
    }

    public UpdateSeniorSettingRequest setProtectScenes(java.util.List<String> protectScenes) {
        this.protectScenes = protectScenes;
        return this;
    }
    public java.util.List<String> getProtectScenes() {
        return this.protectScenes;
    }

}
