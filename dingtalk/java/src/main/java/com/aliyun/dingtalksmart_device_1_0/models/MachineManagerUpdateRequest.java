// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineManagerUpdateRequest extends TeaModel {
    // 设备id
    @NameInMap("deviceId")
    public Long deviceId;

    // 设备管理员的userId
    @NameInMap("userId")
    public String userId;

    // 权限范围：可管理的部门id列表
    @NameInMap("scopeDeptIds")
    public java.util.List<Long> scopeDeptIds;

    // 设备管理员权限点
    @NameInMap("atmManagerRightMap")
    public java.util.Map<String, Boolean> atmManagerRightMap;

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

    public static MachineManagerUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        MachineManagerUpdateRequest self = new MachineManagerUpdateRequest();
        return TeaModel.build(map, self);
    }

    public MachineManagerUpdateRequest setDeviceId(Long deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public Long getDeviceId() {
        return this.deviceId;
    }

    public MachineManagerUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public MachineManagerUpdateRequest setScopeDeptIds(java.util.List<Long> scopeDeptIds) {
        this.scopeDeptIds = scopeDeptIds;
        return this;
    }
    public java.util.List<Long> getScopeDeptIds() {
        return this.scopeDeptIds;
    }

    public MachineManagerUpdateRequest setAtmManagerRightMap(java.util.Map<String, Boolean> atmManagerRightMap) {
        this.atmManagerRightMap = atmManagerRightMap;
        return this;
    }
    public java.util.Map<String, Boolean> getAtmManagerRightMap() {
        return this.atmManagerRightMap;
    }

    public MachineManagerUpdateRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public MachineManagerUpdateRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public MachineManagerUpdateRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public MachineManagerUpdateRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public MachineManagerUpdateRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
