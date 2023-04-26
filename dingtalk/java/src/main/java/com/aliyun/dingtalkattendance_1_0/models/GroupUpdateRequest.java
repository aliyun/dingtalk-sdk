// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateRequest extends TeaModel {
    @NameInMap("adjustmentSettingId")
    public Long adjustmentSettingId;

    @NameInMap("disableCheckWhenRest")
    public Boolean disableCheckWhenRest;

    @NameInMap("disableCheckWithoutSchedule")
    public Boolean disableCheckWithoutSchedule;

    @NameInMap("enableCameraCheck")
    public Boolean enableCameraCheck;

    @NameInMap("enableEmpSelectClass")
    public Boolean enableEmpSelectClass;

    @NameInMap("enableFaceCheck")
    public Boolean enableFaceCheck;

    @NameInMap("enableFaceStrictMode")
    public Boolean enableFaceStrictMode;

    @NameInMap("enableOutSideUpdateNormalCheck")
    public Boolean enableOutSideUpdateNormalCheck;

    @NameInMap("enableOutsideApply")
    public Boolean enableOutsideApply;

    @NameInMap("enableOutsideCheck")
    public Boolean enableOutsideCheck;

    @NameInMap("enableOutsideRemark")
    public Boolean enableOutsideRemark;

    @NameInMap("enableTrimDistance")
    public Boolean enableTrimDistance;

    @NameInMap("forbidHideOutSideAddress")
    public Boolean forbidHideOutSideAddress;

    @NameInMap("freeCheckSetting")
    public GroupUpdateRequestFreeCheckSetting freeCheckSetting;

    @NameInMap("freeCheckTypeId")
    public Integer freeCheckTypeId;

    @NameInMap("groupId")
    public Long groupId;

    @NameInMap("groupName")
    public String groupName;

    @NameInMap("managerList")
    public java.util.List<String> managerList;

    @NameInMap("offset")
    public Integer offset;

    @NameInMap("openFaceCheck")
    public Boolean openFaceCheck;

    @NameInMap("outsideCheckApproveModeId")
    public Integer outsideCheckApproveModeId;

    @NameInMap("overtimeSettingId")
    public Long overtimeSettingId;

    @NameInMap("owner")
    public String owner;

    @NameInMap("positions")
    public java.util.List<GroupUpdateRequestPositions> positions;

    @NameInMap("resourcePermissionMap")
    public java.util.Map<String, ?> resourcePermissionMap;

    @NameInMap("shiftVOList")
    public java.util.List<GroupUpdateRequestShiftVOList> shiftVOList;

    @NameInMap("skipHolidays")
    public Boolean skipHolidays;

    @NameInMap("trimDistance")
    public Integer trimDistance;

    @NameInMap("workdayClassList")
    public java.util.List<Long> workdayClassList;

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
        @NameInMap("offOnCheckGapMinutes")
        public Integer offOnCheckGapMinutes;

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
        @NameInMap("address")
        public String address;

        @NameInMap("latitude")
        public String latitude;

        @NameInMap("longitude")
        public String longitude;

        @NameInMap("offset")
        public Integer offset;

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
