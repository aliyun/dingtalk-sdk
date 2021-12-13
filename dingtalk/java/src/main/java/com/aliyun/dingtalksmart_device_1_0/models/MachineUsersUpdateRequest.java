// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineUsersUpdateRequest extends TeaModel {
    // 移除的员工id列表
    @NameInMap("delUserIds")
    public java.util.List<String> delUserIds;

    // 设备唯一标识id列表，字符串数组
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    // 新增的员工id列表
    @NameInMap("addUserIds")
    public java.util.List<String> addUserIds;

    // 设备唯一标识id列表，Long数组
    @NameInMap("devIds")
    public java.util.List<Long> devIds;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static MachineUsersUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        MachineUsersUpdateRequest self = new MachineUsersUpdateRequest();
        return TeaModel.build(map, self);
    }

    public MachineUsersUpdateRequest setDelUserIds(java.util.List<String> delUserIds) {
        this.delUserIds = delUserIds;
        return this;
    }
    public java.util.List<String> getDelUserIds() {
        return this.delUserIds;
    }

    public MachineUsersUpdateRequest setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

    public MachineUsersUpdateRequest setAddUserIds(java.util.List<String> addUserIds) {
        this.addUserIds = addUserIds;
        return this;
    }
    public java.util.List<String> getAddUserIds() {
        return this.addUserIds;
    }

    public MachineUsersUpdateRequest setDevIds(java.util.List<Long> devIds) {
        this.devIds = devIds;
        return this;
    }
    public java.util.List<Long> getDevIds() {
        return this.devIds;
    }

    public MachineUsersUpdateRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public MachineUsersUpdateRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public MachineUsersUpdateRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public MachineUsersUpdateRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public MachineUsersUpdateRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
