// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineManagerUpdateRequest extends TeaModel {
    // 设备id。
    @NameInMap("deviceId")
    public Long deviceId;

    // 设备管理员的userId。
    @NameInMap("userId")
    public String userId;

    // 权限范围：可管理的部门id列表，-1表示全公司
    @NameInMap("scopeDeptIds")
    public java.util.List<Long> scopeDeptIds;

    // 设备管理员权限点。
    @NameInMap("atmManagerRightMap")
    public MachineManagerUpdateRequestAtmManagerRightMap atmManagerRightMap;

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

    public MachineManagerUpdateRequest setAtmManagerRightMap(MachineManagerUpdateRequestAtmManagerRightMap atmManagerRightMap) {
        this.atmManagerRightMap = atmManagerRightMap;
        return this;
    }
    public MachineManagerUpdateRequestAtmManagerRightMap getAtmManagerRightMap() {
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

    public static class MachineManagerUpdateRequestAtmManagerRightMap extends TeaModel {
        // 添加/删除考勤人员。
        @NameInMap("attendancePersonManage")
        public Boolean attendancePersonManage;

        // 指纹打卡管理。
        @NameInMap("fingerPunchManage")
        public Boolean fingerPunchManage;

        // 人脸打卡管理。
        @NameInMap("facePunchManage")
        public Boolean facePunchManage;

        // 蓝牙打卡管理。
        @NameInMap("bluetoothPunchManage")
        public Boolean bluetoothPunchManage;

        // 设备设置。
        @NameInMap("deviceSettings")
        public Boolean deviceSettings;

        // 设备解绑并重置。
        @NameInMap("deviceReset")
        public Boolean deviceReset;

        public static MachineManagerUpdateRequestAtmManagerRightMap build(java.util.Map<String, ?> map) throws Exception {
            MachineManagerUpdateRequestAtmManagerRightMap self = new MachineManagerUpdateRequestAtmManagerRightMap();
            return TeaModel.build(map, self);
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setAttendancePersonManage(Boolean attendancePersonManage) {
            this.attendancePersonManage = attendancePersonManage;
            return this;
        }
        public Boolean getAttendancePersonManage() {
            return this.attendancePersonManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setFingerPunchManage(Boolean fingerPunchManage) {
            this.fingerPunchManage = fingerPunchManage;
            return this;
        }
        public Boolean getFingerPunchManage() {
            return this.fingerPunchManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setFacePunchManage(Boolean facePunchManage) {
            this.facePunchManage = facePunchManage;
            return this;
        }
        public Boolean getFacePunchManage() {
            return this.facePunchManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setBluetoothPunchManage(Boolean bluetoothPunchManage) {
            this.bluetoothPunchManage = bluetoothPunchManage;
            return this;
        }
        public Boolean getBluetoothPunchManage() {
            return this.bluetoothPunchManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setDeviceSettings(Boolean deviceSettings) {
            this.deviceSettings = deviceSettings;
            return this;
        }
        public Boolean getDeviceSettings() {
            return this.deviceSettings;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setDeviceReset(Boolean deviceReset) {
            this.deviceReset = deviceReset;
            return this;
        }
        public Boolean getDeviceReset() {
            return this.deviceReset;
        }

    }

}
