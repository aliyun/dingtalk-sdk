// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineManagerUpdateRequest extends TeaModel {
    /**
     * <p>设备管理员权限点。</p>
     */
    @NameInMap("atmManagerRightMap")
    public MachineManagerUpdateRequestAtmManagerRightMap atmManagerRightMap;

    /**
     * <p>设备id。</p>
     */
    @NameInMap("deviceId")
    public Long deviceId;

    /**
     * <p>权限范围：可管理的部门id列表，-1表示全公司</p>
     */
    @NameInMap("scopeDeptIds")
    public java.util.List<Long> scopeDeptIds;

    /**
     * <p>设备管理员的userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static MachineManagerUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        MachineManagerUpdateRequest self = new MachineManagerUpdateRequest();
        return TeaModel.build(map, self);
    }

    public MachineManagerUpdateRequest setAtmManagerRightMap(MachineManagerUpdateRequestAtmManagerRightMap atmManagerRightMap) {
        this.atmManagerRightMap = atmManagerRightMap;
        return this;
    }
    public MachineManagerUpdateRequestAtmManagerRightMap getAtmManagerRightMap() {
        return this.atmManagerRightMap;
    }

    public MachineManagerUpdateRequest setDeviceId(Long deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public Long getDeviceId() {
        return this.deviceId;
    }

    public MachineManagerUpdateRequest setScopeDeptIds(java.util.List<Long> scopeDeptIds) {
        this.scopeDeptIds = scopeDeptIds;
        return this;
    }
    public java.util.List<Long> getScopeDeptIds() {
        return this.scopeDeptIds;
    }

    public MachineManagerUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class MachineManagerUpdateRequestAtmManagerRightMap extends TeaModel {
        /**
         * <p>添加/删除考勤人员。</p>
         */
        @NameInMap("attendancePersonManage")
        public Boolean attendancePersonManage;

        /**
         * <p>蓝牙打卡管理。</p>
         */
        @NameInMap("bluetoothPunchManage")
        public Boolean bluetoothPunchManage;

        /**
         * <p>设备解绑并重置。</p>
         */
        @NameInMap("deviceReset")
        public Boolean deviceReset;

        /**
         * <p>设备设置。</p>
         */
        @NameInMap("deviceSettings")
        public Boolean deviceSettings;

        /**
         * <p>人脸打卡管理。</p>
         */
        @NameInMap("facePunchManage")
        public Boolean facePunchManage;

        /**
         * <p>指纹打卡管理。</p>
         */
        @NameInMap("fingerPunchManage")
        public Boolean fingerPunchManage;

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

        public MachineManagerUpdateRequestAtmManagerRightMap setBluetoothPunchManage(Boolean bluetoothPunchManage) {
            this.bluetoothPunchManage = bluetoothPunchManage;
            return this;
        }
        public Boolean getBluetoothPunchManage() {
            return this.bluetoothPunchManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setDeviceReset(Boolean deviceReset) {
            this.deviceReset = deviceReset;
            return this;
        }
        public Boolean getDeviceReset() {
            return this.deviceReset;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setDeviceSettings(Boolean deviceSettings) {
            this.deviceSettings = deviceSettings;
            return this;
        }
        public Boolean getDeviceSettings() {
            return this.deviceSettings;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setFacePunchManage(Boolean facePunchManage) {
            this.facePunchManage = facePunchManage;
            return this;
        }
        public Boolean getFacePunchManage() {
            return this.facePunchManage;
        }

        public MachineManagerUpdateRequestAtmManagerRightMap setFingerPunchManage(Boolean fingerPunchManage) {
            this.fingerPunchManage = fingerPunchManage;
            return this;
        }
        public Boolean getFingerPunchManage() {
            return this.fingerPunchManage;
        }

    }

}
