// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateRequest extends TeaModel {
    /**
     * <p>补卡规则settingId。</p>
     */
    @NameInMap("adjustmentSettingId")
    public Long adjustmentSettingId;

    /**
     * <p>休息日打卡是否需审批：true：需要false：不需要</p>
     */
    @NameInMap("disableCheckWhenRest")
    public Boolean disableCheckWhenRest;

    /**
     * <p>未排班时是否禁止员工打卡。</p>
     */
    @NameInMap("disableCheckWithoutSchedule")
    public Boolean disableCheckWithoutSchedule;

    /**
     * <p>是否开启拍照打卡。true：开启false：关闭（默认值）</p>
     */
    @NameInMap("enableCameraCheck")
    public Boolean enableCameraCheck;

    /**
     * <p>未排班时是否允许员工选择班次打卡。</p>
     */
    @NameInMap("enableEmpSelectClass")
    public Boolean enableEmpSelectClass;

    /**
     * <p>是否开启人脸检测。true：开启false：关闭（默认值）</p>
     */
    @NameInMap("enableFaceCheck")
    public Boolean enableFaceCheck;

    /**
     * <p>是否开启真人验证。</p>
     */
    @NameInMap("enableFaceStrictMode")
    public Boolean enableFaceStrictMode;

    /**
     * <p>是否允许外勤卡更新内勤卡。</p>
     */
    @NameInMap("enableOutSideUpdateNormalCheck")
    public Boolean enableOutSideUpdateNormalCheck;

    /**
     * <p>外勤打卡是否需要审批。</p>
     */
    @NameInMap("enableOutsideApply")
    public Boolean enableOutsideApply;

    /**
     * <p>是否可以外勤打卡。true：允许（默认值）false：不允许</p>
     */
    @NameInMap("enableOutsideCheck")
    public Boolean enableOutsideCheck;

    /**
     * <p>外勤打卡是否需要拍照备注。</p>
     */
    @NameInMap("enableOutsideRemark")
    public Boolean enableOutsideRemark;

    /**
     * <p>是否允许地点微调距离。</p>
     */
    @NameInMap("enableTrimDistance")
    public Boolean enableTrimDistance;

    /**
     * <p>是否禁止员工隐藏详细地址。</p>
     */
    @NameInMap("forbidHideOutSideAddress")
    public Boolean forbidHideOutSideAddress;

    /**
     * <p>休息日打卡规则。</p>
     */
    @NameInMap("freeCheckSetting")
    public GroupUpdateRequestFreeCheckSetting freeCheckSetting;

    /**
     * <p>休息日打卡方式。0严格打卡模式 1标准打卡模式</p>
     */
    @NameInMap("freeCheckTypeId")
    public Integer freeCheckTypeId;

    /**
     * <p>考勤组ID。</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>考勤组名。</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>考勤组子管理员userid列表。</p>
     */
    @NameInMap("managerList")
    public java.util.List<String> managerList;

    /**
     * <p>考勤范围。</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>是否开启人脸打卡。</p>
     */
    @NameInMap("openFaceCheck")
    public Boolean openFaceCheck;

    /**
     * <p>外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批</p>
     */
    @NameInMap("outsideCheckApproveModeId")
    public Integer outsideCheckApproveModeId;

    /**
     * <p>加班规则settingId。</p>
     */
    @NameInMap("overtimeSettingId")
    public Long overtimeSettingId;

    /**
     * <p>考勤组负责人。</p>
     */
    @NameInMap("owner")
    public String owner;

    /**
     * <p>考勤地点相关设置信息。</p>
     */
    @NameInMap("positions")
    public java.util.List<GroupUpdateRequestPositions> positions;

    /**
     * <p>子管理员权限范围。w：可管理r：可读</p>
     */
    @NameInMap("resourcePermissionMap")
    public java.util.List<GroupUpdateRequestResourcePermissionMap> resourcePermissionMap;

    /**
     * <p>班次相关配置信息。</p>
     */
    @NameInMap("shiftVOList")
    public java.util.List<GroupUpdateRequestShiftVOList> shiftVOList;

    /**
     * <p>是否跳过节假日。true：跳过（默认值）false：不跳过</p>
     */
    @NameInMap("skipHolidays")
    public Boolean skipHolidays;

    /**
     * <p>地点微调范围（单位米）。</p>
     */
    @NameInMap("trimDistance")
    public Integer trimDistance;

    /**
     * <p>周班次列表。说明固定班制必填，0表示休息。数组内的值，从左到右依次代表周日到周六，每日的排班情况。</p>
     */
    @NameInMap("workdayClassList")
    public java.util.List<Long> workdayClassList;

    /**
     * <p>操作人的userid。</p>
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

    public GroupUpdateRequest setResourcePermissionMap(java.util.List<GroupUpdateRequestResourcePermissionMap> resourcePermissionMap) {
        this.resourcePermissionMap = resourcePermissionMap;
        return this;
    }
    public java.util.List<GroupUpdateRequestResourcePermissionMap> getResourcePermissionMap() {
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
         * <p>下班打卡最小打卡间隔（单位分钟）。</p>
         */
        @NameInMap("offOnCheckGapMinutes")
        public Integer offOnCheckGapMinutes;

        /**
         * <p>上班打卡最小打卡间隔（单位分钟）。</p>
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
        /**
         * <p>休息日打卡间隔设置。</p>
         */
        @NameInMap("freeCheckGap")
        public GroupUpdateRequestFreeCheckSettingFreeCheckGap freeCheckGap;

        public static GroupUpdateRequestFreeCheckSetting build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestFreeCheckSetting self = new GroupUpdateRequestFreeCheckSetting();
            return TeaModel.build(map, self);
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
         * <p>考勤地址。</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>纬度。</p>
         */
        @NameInMap("latitude")
        public String latitude;

        /**
         * <p>经度。</p>
         */
        @NameInMap("longitude")
        public String longitude;

        /**
         * <p>考勤范围。</p>
         */
        @NameInMap("offset")
        public Integer offset;

        /**
         * <p>考勤标题。</p>
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

    public static class GroupUpdateRequestResourcePermissionMap extends TeaModel {
        /**
         * <p>设置拍照打卡规则。</p>
         */
        @NameInMap("cameraCheck")
        public String cameraCheck;

        /**
         * <p>设置打卡方式。</p>
         */
        @NameInMap("checkPositionType")
        public String checkPositionType;

        /**
         * <p>设置考勤时间。</p>
         */
        @NameInMap("checkTime")
        public String checkTime;

        /**
         * <p>设置参与考勤人员。</p>
         */
        @NameInMap("groupMember")
        public String groupMember;

        /**
         * <p>设置考勤类型。</p>
         */
        @NameInMap("groupType")
        public String groupType;

        /**
         * <p>设置外勤打卡。</p>
         */
        @NameInMap("outSideCheck")
        public String outSideCheck;

        /**
         * <p>设置加班规则。</p>
         */
        @NameInMap("overTimeRule")
        public String overTimeRule;

        /**
         * <p>员工排班。</p>
         */
        @NameInMap("schedule")
        public String schedule;

        public static GroupUpdateRequestResourcePermissionMap build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateRequestResourcePermissionMap self = new GroupUpdateRequestResourcePermissionMap();
            return TeaModel.build(map, self);
        }

        public GroupUpdateRequestResourcePermissionMap setCameraCheck(String cameraCheck) {
            this.cameraCheck = cameraCheck;
            return this;
        }
        public String getCameraCheck() {
            return this.cameraCheck;
        }

        public GroupUpdateRequestResourcePermissionMap setCheckPositionType(String checkPositionType) {
            this.checkPositionType = checkPositionType;
            return this;
        }
        public String getCheckPositionType() {
            return this.checkPositionType;
        }

        public GroupUpdateRequestResourcePermissionMap setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GroupUpdateRequestResourcePermissionMap setGroupMember(String groupMember) {
            this.groupMember = groupMember;
            return this;
        }
        public String getGroupMember() {
            return this.groupMember;
        }

        public GroupUpdateRequestResourcePermissionMap setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public GroupUpdateRequestResourcePermissionMap setOutSideCheck(String outSideCheck) {
            this.outSideCheck = outSideCheck;
            return this;
        }
        public String getOutSideCheck() {
            return this.outSideCheck;
        }

        public GroupUpdateRequestResourcePermissionMap setOverTimeRule(String overTimeRule) {
            this.overTimeRule = overTimeRule;
            return this;
        }
        public String getOverTimeRule() {
            return this.overTimeRule;
        }

        public GroupUpdateRequestResourcePermissionMap setSchedule(String schedule) {
            this.schedule = schedule;
            return this;
        }
        public String getSchedule() {
            return this.schedule;
        }

    }

    public static class GroupUpdateRequestShiftVOList extends TeaModel {
        /**
         * <p>班次ID，可通过获取班次摘要信息接口获取。</p>
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
