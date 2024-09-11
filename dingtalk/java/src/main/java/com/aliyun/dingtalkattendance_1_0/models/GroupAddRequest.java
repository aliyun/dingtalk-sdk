// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupAddRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123L</p>
     */
    @NameInMap("adjustmentSettingId")
    public Long adjustmentSettingId;

    @NameInMap("bleDeviceList")
    public java.util.List<GroupAddRequestBleDeviceList> bleDeviceList;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("checkNeedHealthyCode")
    public Boolean checkNeedHealthyCode;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("defaultClassId")
    public Long defaultClassId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("disableCheckWhenRest")
    public Boolean disableCheckWhenRest;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("disableCheckWithoutSchedule")
    public Boolean disableCheckWithoutSchedule;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableCameraCheck")
    public Boolean enableCameraCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableEmpSelectClass")
    public Boolean enableEmpSelectClass;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableFaceCheck")
    public Boolean enableFaceCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableFaceStrictMode")
    public Boolean enableFaceStrictMode;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableNextDay")
    public Boolean enableNextDay;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutSideUpdateNormalCheck")
    public Boolean enableOutSideUpdateNormalCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutsideApply")
    public Boolean enableOutsideApply;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutsideCameraCheck")
    public Boolean enableOutsideCameraCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutsideCheck")
    public Boolean enableOutsideCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutsideRemark")
    public Boolean enableOutsideRemark;

    @NameInMap("enablePositionBle")
    public Boolean enablePositionBle;

    @NameInMap("enableTrimDistance")
    public Boolean enableTrimDistance;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("forbidHideOutSideAddress")
    public Boolean forbidHideOutSideAddress;

    @NameInMap("freeCheckSetting")
    public GroupAddRequestFreeCheckSetting freeCheckSetting;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("freeCheckTypeId")
    public Integer freeCheckTypeId;

    /**
     * <strong>example:</strong>
     * <p>240</p>
     */
    @NameInMap("freecheckDayStartMinOffset")
    public Integer freecheckDayStartMinOffset;

    @NameInMap("freecheckWorkDays")
    public java.util.List<Integer> freecheckWorkDays;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>白班考勤</p>
     */
    @NameInMap("groupName")
    public String groupName;

    @NameInMap("managerList")
    public java.util.List<String> managerList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<GroupAddRequestMembers> members;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("modifyMember")
    public Boolean modifyMember;

    /**
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("offset")
    public Integer offset;

    @NameInMap("onlyMachineCheck")
    public Boolean onlyMachineCheck;

    @NameInMap("openCameraCheck")
    public Boolean openCameraCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("openFaceCheck")
    public Boolean openFaceCheck;

    /**
     * <strong>example:</strong>
     * <p>-1</p>
     */
    @NameInMap("outsideCheckApproveModeId")
    public Integer outsideCheckApproveModeId;

    /**
     * <strong>example:</strong>
     * <p>123L</p>
     */
    @NameInMap("overtimeSettingId")
    public Long overtimeSettingId;

    /**
     * <strong>example:</strong>
     * <p>123dfdf</p>
     */
    @NameInMap("owner")
    public String owner;

    @NameInMap("positions")
    public java.util.List<GroupAddRequestPositions> positions;

    @NameInMap("resourcePermissionMap")
    public java.util.Map<String, ?> resourcePermissionMap;

    @NameInMap("shiftVOList")
    public java.util.List<GroupAddRequestShiftVOList> shiftVOList;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("skipHolidays")
    public Boolean skipHolidays;

    /**
     * <strong>example:</strong>
     * <p>{&quot;onDuty&quot;:{1400000:123,1400001:123},&quot;offDuty&quot;:[1400000,1400001]}</p>
     */
    @NameInMap("specialDays")
    public String specialDays;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("trimDistance")
    public Integer trimDistance;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>TURN</p>
     */
    @NameInMap("type")
    public String type;

    @NameInMap("wifis")
    public java.util.List<GroupAddRequestWifis> wifis;

    @NameInMap("workdayClassList")
    public java.util.List<Long> workdayClassList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123dfd</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static GroupAddRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupAddRequest self = new GroupAddRequest();
        return TeaModel.build(map, self);
    }

    public GroupAddRequest setAdjustmentSettingId(Long adjustmentSettingId) {
        this.adjustmentSettingId = adjustmentSettingId;
        return this;
    }
    public Long getAdjustmentSettingId() {
        return this.adjustmentSettingId;
    }

    public GroupAddRequest setBleDeviceList(java.util.List<GroupAddRequestBleDeviceList> bleDeviceList) {
        this.bleDeviceList = bleDeviceList;
        return this;
    }
    public java.util.List<GroupAddRequestBleDeviceList> getBleDeviceList() {
        return this.bleDeviceList;
    }

    public GroupAddRequest setCheckNeedHealthyCode(Boolean checkNeedHealthyCode) {
        this.checkNeedHealthyCode = checkNeedHealthyCode;
        return this;
    }
    public Boolean getCheckNeedHealthyCode() {
        return this.checkNeedHealthyCode;
    }

    public GroupAddRequest setDefaultClassId(Long defaultClassId) {
        this.defaultClassId = defaultClassId;
        return this;
    }
    public Long getDefaultClassId() {
        return this.defaultClassId;
    }

    public GroupAddRequest setDisableCheckWhenRest(Boolean disableCheckWhenRest) {
        this.disableCheckWhenRest = disableCheckWhenRest;
        return this;
    }
    public Boolean getDisableCheckWhenRest() {
        return this.disableCheckWhenRest;
    }

    public GroupAddRequest setDisableCheckWithoutSchedule(Boolean disableCheckWithoutSchedule) {
        this.disableCheckWithoutSchedule = disableCheckWithoutSchedule;
        return this;
    }
    public Boolean getDisableCheckWithoutSchedule() {
        return this.disableCheckWithoutSchedule;
    }

    public GroupAddRequest setEnableCameraCheck(Boolean enableCameraCheck) {
        this.enableCameraCheck = enableCameraCheck;
        return this;
    }
    public Boolean getEnableCameraCheck() {
        return this.enableCameraCheck;
    }

    public GroupAddRequest setEnableEmpSelectClass(Boolean enableEmpSelectClass) {
        this.enableEmpSelectClass = enableEmpSelectClass;
        return this;
    }
    public Boolean getEnableEmpSelectClass() {
        return this.enableEmpSelectClass;
    }

    public GroupAddRequest setEnableFaceCheck(Boolean enableFaceCheck) {
        this.enableFaceCheck = enableFaceCheck;
        return this;
    }
    public Boolean getEnableFaceCheck() {
        return this.enableFaceCheck;
    }

    public GroupAddRequest setEnableFaceStrictMode(Boolean enableFaceStrictMode) {
        this.enableFaceStrictMode = enableFaceStrictMode;
        return this;
    }
    public Boolean getEnableFaceStrictMode() {
        return this.enableFaceStrictMode;
    }

    public GroupAddRequest setEnableNextDay(Boolean enableNextDay) {
        this.enableNextDay = enableNextDay;
        return this;
    }
    public Boolean getEnableNextDay() {
        return this.enableNextDay;
    }

    public GroupAddRequest setEnableOutSideUpdateNormalCheck(Boolean enableOutSideUpdateNormalCheck) {
        this.enableOutSideUpdateNormalCheck = enableOutSideUpdateNormalCheck;
        return this;
    }
    public Boolean getEnableOutSideUpdateNormalCheck() {
        return this.enableOutSideUpdateNormalCheck;
    }

    public GroupAddRequest setEnableOutsideApply(Boolean enableOutsideApply) {
        this.enableOutsideApply = enableOutsideApply;
        return this;
    }
    public Boolean getEnableOutsideApply() {
        return this.enableOutsideApply;
    }

    public GroupAddRequest setEnableOutsideCameraCheck(Boolean enableOutsideCameraCheck) {
        this.enableOutsideCameraCheck = enableOutsideCameraCheck;
        return this;
    }
    public Boolean getEnableOutsideCameraCheck() {
        return this.enableOutsideCameraCheck;
    }

    public GroupAddRequest setEnableOutsideCheck(Boolean enableOutsideCheck) {
        this.enableOutsideCheck = enableOutsideCheck;
        return this;
    }
    public Boolean getEnableOutsideCheck() {
        return this.enableOutsideCheck;
    }

    public GroupAddRequest setEnableOutsideRemark(Boolean enableOutsideRemark) {
        this.enableOutsideRemark = enableOutsideRemark;
        return this;
    }
    public Boolean getEnableOutsideRemark() {
        return this.enableOutsideRemark;
    }

    public GroupAddRequest setEnablePositionBle(Boolean enablePositionBle) {
        this.enablePositionBle = enablePositionBle;
        return this;
    }
    public Boolean getEnablePositionBle() {
        return this.enablePositionBle;
    }

    public GroupAddRequest setEnableTrimDistance(Boolean enableTrimDistance) {
        this.enableTrimDistance = enableTrimDistance;
        return this;
    }
    public Boolean getEnableTrimDistance() {
        return this.enableTrimDistance;
    }

    public GroupAddRequest setForbidHideOutSideAddress(Boolean forbidHideOutSideAddress) {
        this.forbidHideOutSideAddress = forbidHideOutSideAddress;
        return this;
    }
    public Boolean getForbidHideOutSideAddress() {
        return this.forbidHideOutSideAddress;
    }

    public GroupAddRequest setFreeCheckSetting(GroupAddRequestFreeCheckSetting freeCheckSetting) {
        this.freeCheckSetting = freeCheckSetting;
        return this;
    }
    public GroupAddRequestFreeCheckSetting getFreeCheckSetting() {
        return this.freeCheckSetting;
    }

    public GroupAddRequest setFreeCheckTypeId(Integer freeCheckTypeId) {
        this.freeCheckTypeId = freeCheckTypeId;
        return this;
    }
    public Integer getFreeCheckTypeId() {
        return this.freeCheckTypeId;
    }

    public GroupAddRequest setFreecheckDayStartMinOffset(Integer freecheckDayStartMinOffset) {
        this.freecheckDayStartMinOffset = freecheckDayStartMinOffset;
        return this;
    }
    public Integer getFreecheckDayStartMinOffset() {
        return this.freecheckDayStartMinOffset;
    }

    public GroupAddRequest setFreecheckWorkDays(java.util.List<Integer> freecheckWorkDays) {
        this.freecheckWorkDays = freecheckWorkDays;
        return this;
    }
    public java.util.List<Integer> getFreecheckWorkDays() {
        return this.freecheckWorkDays;
    }

    public GroupAddRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public GroupAddRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public GroupAddRequest setManagerList(java.util.List<String> managerList) {
        this.managerList = managerList;
        return this;
    }
    public java.util.List<String> getManagerList() {
        return this.managerList;
    }

    public GroupAddRequest setMembers(java.util.List<GroupAddRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<GroupAddRequestMembers> getMembers() {
        return this.members;
    }

    public GroupAddRequest setModifyMember(Boolean modifyMember) {
        this.modifyMember = modifyMember;
        return this;
    }
    public Boolean getModifyMember() {
        return this.modifyMember;
    }

    public GroupAddRequest setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
        return this.offset;
    }

    public GroupAddRequest setOnlyMachineCheck(Boolean onlyMachineCheck) {
        this.onlyMachineCheck = onlyMachineCheck;
        return this;
    }
    public Boolean getOnlyMachineCheck() {
        return this.onlyMachineCheck;
    }

    public GroupAddRequest setOpenCameraCheck(Boolean openCameraCheck) {
        this.openCameraCheck = openCameraCheck;
        return this;
    }
    public Boolean getOpenCameraCheck() {
        return this.openCameraCheck;
    }

    public GroupAddRequest setOpenFaceCheck(Boolean openFaceCheck) {
        this.openFaceCheck = openFaceCheck;
        return this;
    }
    public Boolean getOpenFaceCheck() {
        return this.openFaceCheck;
    }

    public GroupAddRequest setOutsideCheckApproveModeId(Integer outsideCheckApproveModeId) {
        this.outsideCheckApproveModeId = outsideCheckApproveModeId;
        return this;
    }
    public Integer getOutsideCheckApproveModeId() {
        return this.outsideCheckApproveModeId;
    }

    public GroupAddRequest setOvertimeSettingId(Long overtimeSettingId) {
        this.overtimeSettingId = overtimeSettingId;
        return this;
    }
    public Long getOvertimeSettingId() {
        return this.overtimeSettingId;
    }

    public GroupAddRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public GroupAddRequest setPositions(java.util.List<GroupAddRequestPositions> positions) {
        this.positions = positions;
        return this;
    }
    public java.util.List<GroupAddRequestPositions> getPositions() {
        return this.positions;
    }

    public GroupAddRequest setResourcePermissionMap(java.util.Map<String, ?> resourcePermissionMap) {
        this.resourcePermissionMap = resourcePermissionMap;
        return this;
    }
    public java.util.Map<String, ?> getResourcePermissionMap() {
        return this.resourcePermissionMap;
    }

    public GroupAddRequest setShiftVOList(java.util.List<GroupAddRequestShiftVOList> shiftVOList) {
        this.shiftVOList = shiftVOList;
        return this;
    }
    public java.util.List<GroupAddRequestShiftVOList> getShiftVOList() {
        return this.shiftVOList;
    }

    public GroupAddRequest setSkipHolidays(Boolean skipHolidays) {
        this.skipHolidays = skipHolidays;
        return this;
    }
    public Boolean getSkipHolidays() {
        return this.skipHolidays;
    }

    public GroupAddRequest setSpecialDays(String specialDays) {
        this.specialDays = specialDays;
        return this;
    }
    public String getSpecialDays() {
        return this.specialDays;
    }

    public GroupAddRequest setTrimDistance(Integer trimDistance) {
        this.trimDistance = trimDistance;
        return this;
    }
    public Integer getTrimDistance() {
        return this.trimDistance;
    }

    public GroupAddRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public GroupAddRequest setWifis(java.util.List<GroupAddRequestWifis> wifis) {
        this.wifis = wifis;
        return this;
    }
    public java.util.List<GroupAddRequestWifis> getWifis() {
        return this.wifis;
    }

    public GroupAddRequest setWorkdayClassList(java.util.List<Long> workdayClassList) {
        this.workdayClassList = workdayClassList;
        return this;
    }
    public java.util.List<Long> getWorkdayClassList() {
        return this.workdayClassList;
    }

    public GroupAddRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class GroupAddRequestBleDeviceList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1311089987</p>
         */
        @NameInMap("deviceId")
        public Long deviceId;

        public static GroupAddRequestBleDeviceList build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestBleDeviceList self = new GroupAddRequestBleDeviceList();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestBleDeviceList setDeviceId(Long deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public Long getDeviceId() {
            return this.deviceId;
        }

    }

    public static class GroupAddRequestFreeCheckSettingFreeCheckGap extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("offOnCheckGapMinutes")
        public Integer offOnCheckGapMinutes;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("onOffCheckGapMinutes")
        public Integer onOffCheckGapMinutes;

        public static GroupAddRequestFreeCheckSettingFreeCheckGap build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestFreeCheckSettingFreeCheckGap self = new GroupAddRequestFreeCheckSettingFreeCheckGap();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestFreeCheckSettingFreeCheckGap setOffOnCheckGapMinutes(Integer offOnCheckGapMinutes) {
            this.offOnCheckGapMinutes = offOnCheckGapMinutes;
            return this;
        }
        public Integer getOffOnCheckGapMinutes() {
            return this.offOnCheckGapMinutes;
        }

        public GroupAddRequestFreeCheckSettingFreeCheckGap setOnOffCheckGapMinutes(Integer onOffCheckGapMinutes) {
            this.onOffCheckGapMinutes = onOffCheckGapMinutes;
            return this;
        }
        public Integer getOnOffCheckGapMinutes() {
            return this.onOffCheckGapMinutes;
        }

    }

    public static class GroupAddRequestFreeCheckSetting extends TeaModel {
        @NameInMap("delimitOffsetMinutesBetweenDays")
        public Integer delimitOffsetMinutesBetweenDays;

        @NameInMap("freeCheckGap")
        public GroupAddRequestFreeCheckSettingFreeCheckGap freeCheckGap;

        public static GroupAddRequestFreeCheckSetting build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestFreeCheckSetting self = new GroupAddRequestFreeCheckSetting();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestFreeCheckSetting setDelimitOffsetMinutesBetweenDays(Integer delimitOffsetMinutesBetweenDays) {
            this.delimitOffsetMinutesBetweenDays = delimitOffsetMinutesBetweenDays;
            return this;
        }
        public Integer getDelimitOffsetMinutesBetweenDays() {
            return this.delimitOffsetMinutesBetweenDays;
        }

        public GroupAddRequestFreeCheckSetting setFreeCheckGap(GroupAddRequestFreeCheckSettingFreeCheckGap freeCheckGap) {
            this.freeCheckGap = freeCheckGap;
            return this;
        }
        public GroupAddRequestFreeCheckSettingFreeCheckGap getFreeCheckGap() {
            return this.freeCheckGap;
        }

    }

    public static class GroupAddRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>Attendance</p>
         */
        @NameInMap("role")
        public String role;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>StaffMember</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1212jfkd</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GroupAddRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestMembers self = new GroupAddRequestMembers();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestMembers setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public GroupAddRequestMembers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GroupAddRequestMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GroupAddRequestPositions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>生物科技产业园区经二路21号</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <strong>example:</strong>
         * <p>36.687495</p>
         */
        @NameInMap("latitude")
        public String latitude;

        /**
         * <strong>example:</strong>
         * <p>101.750329</p>
         */
        @NameInMap("longitude")
        public String longitude;

        /**
         * <strong>example:</strong>
         * <p>500</p>
         */
        @NameInMap("offset")
        public Integer offset;

        /**
         * <strong>example:</strong>
         * <p>青藏高原自然博物馆</p>
         */
        @NameInMap("title")
        public String title;

        public static GroupAddRequestPositions build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestPositions self = new GroupAddRequestPositions();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestPositions setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public GroupAddRequestPositions setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public GroupAddRequestPositions setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public GroupAddRequestPositions setOffset(Integer offset) {
            this.offset = offset;
            return this;
        }
        public Integer getOffset() {
            return this.offset;
        }

        public GroupAddRequestPositions setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GroupAddRequestShiftVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("shiftId")
        public Long shiftId;

        public static GroupAddRequestShiftVOList build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestShiftVOList self = new GroupAddRequestShiftVOList();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestShiftVOList setShiftId(Long shiftId) {
            this.shiftId = shiftId;
            return this;
        }
        public Long getShiftId() {
            return this.shiftId;
        }

    }

    public static class GroupAddRequestWifis extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>C0:E0:D0:E0:C0:0F</p>
         */
        @NameInMap("macAddr")
        public String macAddr;

        /**
         * <strong>example:</strong>
         * <p>OFFICE-WiFi</p>
         */
        @NameInMap("ssid")
        public String ssid;

        public static GroupAddRequestWifis build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestWifis self = new GroupAddRequestWifis();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestWifis setMacAddr(String macAddr) {
            this.macAddr = macAddr;
            return this;
        }
        public String getMacAddr() {
            return this.macAddr;
        }

        public GroupAddRequestWifis setSsid(String ssid) {
            this.ssid = ssid;
            return this;
        }
        public String getSsid() {
            return this.ssid;
        }

    }

}
