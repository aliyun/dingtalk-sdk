// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123L</p>
     */
    @NameInMap("adjustmentSettingId")
    public Long adjustmentSettingId;

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
    @NameInMap("enableOutSideUpdateNormalCheck")
    public Boolean enableOutSideUpdateNormalCheck;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableOutsideApply")
    public Boolean enableOutsideApply;

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

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enableTrimDistance")
    public Boolean enableTrimDistance;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("forbidHideOutSideAddress")
    public Boolean forbidHideOutSideAddress;

    @NameInMap("freeCheckSetting")
    public GroupUpdateRequestFreeCheckSetting freeCheckSetting;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("freeCheckTypeId")
    public Integer freeCheckTypeId;

    @NameInMap("freecheckDayStartMinOffset")
    public Integer freecheckDayStartMinOffset;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <strong>example:</strong>
     * <p>白班考勤</p>
     */
    @NameInMap("groupName")
    public String groupName;

    @NameInMap("managerList")
    public java.util.List<String> managerList;

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
    public java.util.List<GroupUpdateRequestPositions> positions;

    @NameInMap("resourcePermissionMap")
    public java.util.Map<String, ?> resourcePermissionMap;

    @NameInMap("shiftVOList")
    public java.util.List<GroupUpdateRequestShiftVOList> shiftVOList;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("skipHolidays")
    public Boolean skipHolidays;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("trimDistance")
    public Integer trimDistance;

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

    public static GroupUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupUpdateRequest self = new GroupUpdateRequest();
        return TeaModel.build(map, self);
    }

    public GroupUpdateRequest setAdjustmentSettingId(Long adjustmentSettingId) {
        this.adjustmentSettingId = adjustmentSettingId;
        return this;
    }
    public Long getAdjustmentSettingId() {
        return this.adjustmentSettingId;
    }

    public GroupUpdateRequest setDefaultClassId(Long defaultClassId) {
        this.defaultClassId = defaultClassId;
        return this;
    }
    public Long getDefaultClassId() {
        return this.defaultClassId;
    }

    public GroupUpdateRequest setDisableCheckWhenRest(Boolean disableCheckWhenRest) {
        this.disableCheckWhenRest = disableCheckWhenRest;
        return this;
    }
    public Boolean getDisableCheckWhenRest() {
        return this.disableCheckWhenRest;
    }

    public GroupUpdateRequest setDisableCheckWithoutSchedule(Boolean disableCheckWithoutSchedule) {
        this.disableCheckWithoutSchedule = disableCheckWithoutSchedule;
        return this;
    }
    public Boolean getDisableCheckWithoutSchedule() {
        return this.disableCheckWithoutSchedule;
    }

    public GroupUpdateRequest setEnableCameraCheck(Boolean enableCameraCheck) {
        this.enableCameraCheck = enableCameraCheck;
        return this;
    }
    public Boolean getEnableCameraCheck() {
        return this.enableCameraCheck;
    }

    public GroupUpdateRequest setEnableEmpSelectClass(Boolean enableEmpSelectClass) {
        this.enableEmpSelectClass = enableEmpSelectClass;
        return this;
    }
    public Boolean getEnableEmpSelectClass() {
        return this.enableEmpSelectClass;
    }

    public GroupUpdateRequest setEnableFaceCheck(Boolean enableFaceCheck) {
        this.enableFaceCheck = enableFaceCheck;
        return this;
    }
    public Boolean getEnableFaceCheck() {
        return this.enableFaceCheck;
    }

    public GroupUpdateRequest setEnableFaceStrictMode(Boolean enableFaceStrictMode) {
        this.enableFaceStrictMode = enableFaceStrictMode;
        return this;
    }
    public Boolean getEnableFaceStrictMode() {
        return this.enableFaceStrictMode;
    }

    public GroupUpdateRequest setEnableOutSideUpdateNormalCheck(Boolean enableOutSideUpdateNormalCheck) {
        this.enableOutSideUpdateNormalCheck = enableOutSideUpdateNormalCheck;
        return this;
    }
    public Boolean getEnableOutSideUpdateNormalCheck() {
        return this.enableOutSideUpdateNormalCheck;
    }

    public GroupUpdateRequest setEnableOutsideApply(Boolean enableOutsideApply) {
        this.enableOutsideApply = enableOutsideApply;
        return this;
    }
    public Boolean getEnableOutsideApply() {
        return this.enableOutsideApply;
    }

    public GroupUpdateRequest setEnableOutsideCameraCheck(Boolean enableOutsideCameraCheck) {
        this.enableOutsideCameraCheck = enableOutsideCameraCheck;
        return this;
    }
    public Boolean getEnableOutsideCameraCheck() {
        return this.enableOutsideCameraCheck;
    }

    public GroupUpdateRequest setEnableOutsideCheck(Boolean enableOutsideCheck) {
        this.enableOutsideCheck = enableOutsideCheck;
        return this;
    }
    public Boolean getEnableOutsideCheck() {
        return this.enableOutsideCheck;
    }

    public GroupUpdateRequest setEnableOutsideRemark(Boolean enableOutsideRemark) {
        this.enableOutsideRemark = enableOutsideRemark;
        return this;
    }
    public Boolean getEnableOutsideRemark() {
        return this.enableOutsideRemark;
    }

    public GroupUpdateRequest setEnableTrimDistance(Boolean enableTrimDistance) {
        this.enableTrimDistance = enableTrimDistance;
        return this;
    }
    public Boolean getEnableTrimDistance() {
        return this.enableTrimDistance;
    }

    public GroupUpdateRequest setForbidHideOutSideAddress(Boolean forbidHideOutSideAddress) {
        this.forbidHideOutSideAddress = forbidHideOutSideAddress;
        return this;
    }
    public Boolean getForbidHideOutSideAddress() {
        return this.forbidHideOutSideAddress;
    }

    public GroupUpdateRequest setFreeCheckSetting(GroupUpdateRequestFreeCheckSetting freeCheckSetting) {
        this.freeCheckSetting = freeCheckSetting;
        return this;
    }
    public GroupUpdateRequestFreeCheckSetting getFreeCheckSetting() {
        return this.freeCheckSetting;
    }

    public GroupUpdateRequest setFreeCheckTypeId(Integer freeCheckTypeId) {
        this.freeCheckTypeId = freeCheckTypeId;
        return this;
    }
    public Integer getFreeCheckTypeId() {
        return this.freeCheckTypeId;
    }

    public GroupUpdateRequest setFreecheckDayStartMinOffset(Integer freecheckDayStartMinOffset) {
        this.freecheckDayStartMinOffset = freecheckDayStartMinOffset;
        return this;
    }
    public Integer getFreecheckDayStartMinOffset() {
        return this.freecheckDayStartMinOffset;
    }

    public GroupUpdateRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public GroupUpdateRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public GroupUpdateRequest setManagerList(java.util.List<String> managerList) {
        this.managerList = managerList;
        return this;
    }
    public java.util.List<String> getManagerList() {
        return this.managerList;
    }

    public GroupUpdateRequest setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
        return this.offset;
    }

    public GroupUpdateRequest setOnlyMachineCheck(Boolean onlyMachineCheck) {
        this.onlyMachineCheck = onlyMachineCheck;
        return this;
    }
    public Boolean getOnlyMachineCheck() {
        return this.onlyMachineCheck;
    }

    public GroupUpdateRequest setOpenCameraCheck(Boolean openCameraCheck) {
        this.openCameraCheck = openCameraCheck;
        return this;
    }
    public Boolean getOpenCameraCheck() {
        return this.openCameraCheck;
    }

    public GroupUpdateRequest setOpenFaceCheck(Boolean openFaceCheck) {
        this.openFaceCheck = openFaceCheck;
        return this;
    }
    public Boolean getOpenFaceCheck() {
        return this.openFaceCheck;
    }

    public GroupUpdateRequest setOutsideCheckApproveModeId(Integer outsideCheckApproveModeId) {
        this.outsideCheckApproveModeId = outsideCheckApproveModeId;
        return this;
    }
    public Integer getOutsideCheckApproveModeId() {
        return this.outsideCheckApproveModeId;
    }

    public GroupUpdateRequest setOvertimeSettingId(Long overtimeSettingId) {
        this.overtimeSettingId = overtimeSettingId;
        return this;
    }
    public Long getOvertimeSettingId() {
        return this.overtimeSettingId;
    }

    public GroupUpdateRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public GroupUpdateRequest setPositions(java.util.List<GroupUpdateRequestPositions> positions) {
        this.positions = positions;
        return this;
    }
    public java.util.List<GroupUpdateRequestPositions> getPositions() {
        return this.positions;
    }

    public GroupUpdateRequest setResourcePermissionMap(java.util.Map<String, ?> resourcePermissionMap) {
        this.resourcePermissionMap = resourcePermissionMap;
        return this;
    }
    public java.util.Map<String, ?> getResourcePermissionMap() {
        return this.resourcePermissionMap;
    }

    public GroupUpdateRequest setShiftVOList(java.util.List<GroupUpdateRequestShiftVOList> shiftVOList) {
        this.shiftVOList = shiftVOList;
        return this;
    }
    public java.util.List<GroupUpdateRequestShiftVOList> getShiftVOList() {
        return this.shiftVOList;
    }

    public GroupUpdateRequest setSkipHolidays(Boolean skipHolidays) {
        this.skipHolidays = skipHolidays;
        return this;
    }
    public Boolean getSkipHolidays() {
        return this.skipHolidays;
    }

    public GroupUpdateRequest setTrimDistance(Integer trimDistance) {
        this.trimDistance = trimDistance;
        return this;
    }
    public Integer getTrimDistance() {
        return this.trimDistance;
    }

    public GroupUpdateRequest setWorkdayClassList(java.util.List<Long> workdayClassList) {
        this.workdayClassList = workdayClassList;
        return this;
    }
    public java.util.List<Long> getWorkdayClassList() {
        return this.workdayClassList;
    }

    public GroupUpdateRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class GroupUpdateRequestFreeCheckSettingFreeCheckGap extends TeaModel {
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

        public static GroupUpdateRequestFreeCheckSettingFreeCheckGap build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestFreeCheckSettingFreeCheckGap self = new GroupUpdateRequestFreeCheckSettingFreeCheckGap();
            return TeaModel.build(map, self);
        }

        public GroupUpdateRequestFreeCheckSettingFreeCheckGap setOffOnCheckGapMinutes(Integer offOnCheckGapMinutes) {
            this.offOnCheckGapMinutes = offOnCheckGapMinutes;
            return this;
        }
        public Integer getOffOnCheckGapMinutes() {
            return this.offOnCheckGapMinutes;
        }

        public GroupUpdateRequestFreeCheckSettingFreeCheckGap setOnOffCheckGapMinutes(Integer onOffCheckGapMinutes) {
            this.onOffCheckGapMinutes = onOffCheckGapMinutes;
            return this;
        }
        public Integer getOnOffCheckGapMinutes() {
            return this.onOffCheckGapMinutes;
        }

    }

    public static class GroupUpdateRequestFreeCheckSetting extends TeaModel {
        @NameInMap("delimitOffsetMinutesBetweenDays")
        public Integer delimitOffsetMinutesBetweenDays;

        @NameInMap("freeCheckGap")
        public GroupUpdateRequestFreeCheckSettingFreeCheckGap freeCheckGap;

        public static GroupUpdateRequestFreeCheckSetting build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestFreeCheckSetting self = new GroupUpdateRequestFreeCheckSetting();
            return TeaModel.build(map, self);
        }

        public GroupUpdateRequestFreeCheckSetting setDelimitOffsetMinutesBetweenDays(Integer delimitOffsetMinutesBetweenDays) {
            this.delimitOffsetMinutesBetweenDays = delimitOffsetMinutesBetweenDays;
            return this;
        }
        public Integer getDelimitOffsetMinutesBetweenDays() {
            return this.delimitOffsetMinutesBetweenDays;
        }

        public GroupUpdateRequestFreeCheckSetting setFreeCheckGap(GroupUpdateRequestFreeCheckSettingFreeCheckGap freeCheckGap) {
            this.freeCheckGap = freeCheckGap;
            return this;
        }
        public GroupUpdateRequestFreeCheckSettingFreeCheckGap getFreeCheckGap() {
            return this.freeCheckGap;
        }

    }

    public static class GroupUpdateRequestPositions extends TeaModel {
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

        public static GroupUpdateRequestPositions build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestPositions self = new GroupUpdateRequestPositions();
            return TeaModel.build(map, self);
        }

        public GroupUpdateRequestPositions setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public GroupUpdateRequestPositions setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public GroupUpdateRequestPositions setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public GroupUpdateRequestPositions setOffset(Integer offset) {
            this.offset = offset;
            return this;
        }
        public Integer getOffset() {
            return this.offset;
        }

        public GroupUpdateRequestPositions setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GroupUpdateRequestShiftVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("shiftId")
        public Long shiftId;

        public static GroupUpdateRequestShiftVOList build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestShiftVOList self = new GroupUpdateRequestShiftVOList();
            return TeaModel.build(map, self);
        }

        public GroupUpdateRequestShiftVOList setShiftId(Long shiftId) {
            this.shiftId = shiftId;
            return this;
        }
        public Long getShiftId() {
            return this.shiftId;
        }

    }

}
