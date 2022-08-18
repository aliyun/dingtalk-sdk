// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupAddRequest extends TeaModel {
    // 补卡规则settingId。
    @NameInMap("adjustmentSettingId")
    public Long adjustmentSettingId;

    // 蓝牙打卡相关配置信息。
    @NameInMap("bleDeviceList")
    public java.util.List<GroupAddRequestBleDeviceList> bleDeviceList;

    // 打卡是否需要健康码：
    // 
    // true：开启
    // 
    // false：关闭（默认值）
    @NameInMap("checkNeedHealthyCode")
    public Boolean checkNeedHealthyCode;

    // 默认班次ID。
    // 
    // 说明 固定班制必填，可通过获取班次摘要信息接口获取
    @NameInMap("defaultClassId")
    public Long defaultClassId;

    // 休息日打卡是否需审批：
    // 
    // true：需要
    // 
    // false：不需要
    @NameInMap("disableCheckWhenRest")
    public Boolean disableCheckWhenRest;

    // 未排班时是否禁止员工打卡。
    @NameInMap("disableCheckWithoutSchedule")
    public Boolean disableCheckWithoutSchedule;

    // 是否开启拍照打卡。
    // 
    // true：开启
    // 
    // false：关闭（默认值）
    @NameInMap("enableCameraCheck")
    public Boolean enableCameraCheck;

    // 未排班时是否允许员工选择班次打卡。
    @NameInMap("enableEmpSelectClass")
    public Boolean enableEmpSelectClass;

    // 是否开启人脸检测。
    // 
    // true：开启
    // 
    // false：关闭（默认值）
    @NameInMap("enableFaceCheck")
    public Boolean enableFaceCheck;

    // 是否开启真人验证。
    @NameInMap("enableFaceStrictMode")
    public Boolean enableFaceStrictMode;

    // 是否第二天生效。
    // true：是
    // false：否
    @NameInMap("enableNextDay")
    public Boolean enableNextDay;

    // 是否允许外勤卡更新内勤卡。
    @NameInMap("enableOutSideUpdateNormalCheck")
    public Boolean enableOutSideUpdateNormalCheck;

    // 外勤打卡是否需要审批。
    @NameInMap("enableOutsideApply")
    public Boolean enableOutsideApply;

    // 是否开启外勤打卡必须拍照。
    // 
    // true：开启
    // 
    // false：关闭（默认值）
    @NameInMap("enableOutsideCameraCheck")
    public Boolean enableOutsideCameraCheck;

    // 是否可以外勤打卡。
    // 
    // true：允许（默认值）
    // 
    // false：不允许
    @NameInMap("enableOutsideCheck")
    public Boolean enableOutsideCheck;

    // 外勤打卡是否需要拍照备注。
    @NameInMap("enableOutsideRemark")
    public Boolean enableOutsideRemark;

    // 是否启用蓝牙定位。
    @NameInMap("enablePositionBle")
    public Boolean enablePositionBle;

    // 是否允许地点微调距离。
    @NameInMap("enableTrimDistance")
    public Boolean enableTrimDistance;

    // 是否禁止员工隐藏详细地址。
    @NameInMap("forbidHideOutSideAddress")
    public Boolean forbidHideOutSideAddress;

    // 休息日打卡规则。
    @NameInMap("freeCheckSetting")
    public GroupAddRequestFreeCheckSetting freeCheckSetting;

    // 休息日打卡方式。
    // 0严格打卡模式 
    // 1标准打卡模式
    @NameInMap("freeCheckTypeId")
    public Integer freeCheckTypeId;

    // 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
    // 
    // 例如：540表示9:00
    @NameInMap("freecheckDayStartMinOffset")
    public Integer freecheckDayStartMinOffset;

    // 自由工时考勤组工作日。
    // 说明
    // 0表示休息。
    // 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
    @NameInMap("freecheckWorkDays")
    public java.util.List<Long> freecheckWorkDays;

    // 考勤组ID。
    @NameInMap("groupId")
    public Long groupId;

    // 考勤组名。
    @NameInMap("groupName")
    public String groupName;

    // 考勤组子管理员userid列表。
    @NameInMap("managerList")
    public java.util.List<String> managerList;

    // 考勤组成员相关设置信息。
    @NameInMap("members")
    public java.util.List<GroupAddRequestMembers> members;

    // 是否有修改考勤组成员相关信息。
    @NameInMap("modifyMember")
    public Boolean modifyMember;

    // 考勤范围。
    @NameInMap("offset")
    public Integer offset;

    // 是否开启人脸打卡。
    @NameInMap("openFaceCheck")
    public Boolean openFaceCheck;

    // 外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批
    @NameInMap("outsideCheckApproveModeId")
    public Integer outsideCheckApproveModeId;

    // 加班规则settingId。
    @NameInMap("overtimeSettingId")
    public Long overtimeSettingId;

    // 考勤组负责人。
    @NameInMap("owner")
    public String owner;

    // 考勤地点相关设置信息。
    @NameInMap("positions")
    public java.util.List<GroupAddRequestPositions> positions;

    // 子管理员权限范围。
    // 
    // w：可管理
    // 
    // r：可读
    @NameInMap("resourcePermissionMap")
    public java.util.List<GroupAddRequestResourcePermissionMap> resourcePermissionMap;

    // 班次相关配置信息。
    @NameInMap("shiftVOList")
    public java.util.List<GroupAddRequestShiftVOList> shiftVOList;

    // 是否跳过节假日。
    // 
    // true：跳过（默认值）
    // 
    // false：不跳过
    @NameInMap("skipHolidays")
    public Boolean skipHolidays;

    // 特殊日期配置。
    @NameInMap("specialDays")
    public String specialDays;

    // 地点微调范围（单位米）。
    @NameInMap("trimDistance")
    public Integer trimDistance;

    // 考勤组类型：
    // 
    // FIXED：固定班制考勤组
    // 
    // TURN：排班制考勤组
    // 
    // NONE：自由工时考勤组
    @NameInMap("type")
    public String type;

    // 考勤wifi打卡相关配置信息。
    @NameInMap("wifis")
    public java.util.List<GroupAddRequestWifis> wifis;

    // 周班次列表。
    // 说明
    // 固定班制必填，0表示休息。
    // 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
    @NameInMap("workdayClassList")
    public java.util.List<Long> workdayClassList;

    // 操作人的userid。
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

    public GroupAddRequest setFreecheckWorkDays(java.util.List<Long> freecheckWorkDays) {
        this.freecheckWorkDays = freecheckWorkDays;
        return this;
    }
    public java.util.List<Long> getFreecheckWorkDays() {
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

    public GroupAddRequest setResourcePermissionMap(java.util.List<GroupAddRequestResourcePermissionMap> resourcePermissionMap) {
        this.resourcePermissionMap = resourcePermissionMap;
        return this;
    }
    public java.util.List<GroupAddRequestResourcePermissionMap> getResourcePermissionMap() {
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
        // 设备ID，调用查询员工智能考勤机列表获取。
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
        // 下班打卡最小打卡间隔（单位分钟）。
        @NameInMap("offOnCheckGapMinutes")
        public Integer offOnCheckGapMinutes;

        // 上班打卡最小打卡间隔（单位分钟）。
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
        // 休息日打卡间隔设置。
        @NameInMap("freeCheckGap")
        public GroupAddRequestFreeCheckSettingFreeCheckGap freeCheckGap;

        public static GroupAddRequestFreeCheckSetting build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestFreeCheckSetting self = new GroupAddRequestFreeCheckSetting();
            return TeaModel.build(map, self);
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
        // 角色，固定值Attendance。
        @NameInMap("role")
        public String role;

        // 类型，固定值StaffMember。
        @NameInMap("type")
        public String type;

        // 用户userid。
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
        // 考勤地址。
        @NameInMap("address")
        public String address;

        // 纬度。
        @NameInMap("latitude")
        public String latitude;

        // 经度。
        @NameInMap("longitude")
        public String longitude;

        // 考勤范围。
        @NameInMap("offset")
        public Integer offset;

        // 考勤标题。
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

    public static class GroupAddRequestResourcePermissionMap extends TeaModel {
        // 设置拍照打卡规则。
        @NameInMap("cameraCheck")
        public String cameraCheck;

        // 设置打卡方式。
        @NameInMap("checkPositionType")
        public String checkPositionType;

        // 设置考勤时间。
        @NameInMap("checkTime")
        public String checkTime;

        // 设置参与考勤人员。
        @NameInMap("groupMember")
        public String groupMember;

        // 设置考勤类型。
        @NameInMap("groupType")
        public String groupType;

        // 设置外勤打卡。
        @NameInMap("outSideCheck")
        public String outSideCheck;

        // 设置加班规则。
        @NameInMap("overTimeRule")
        public String overTimeRule;

        // 员工排班。
        @NameInMap("schedule")
        public String schedule;

        public static GroupAddRequestResourcePermissionMap build(java.util.Map<String, ?> map) throws Exception {
            GroupAddRequestResourcePermissionMap self = new GroupAddRequestResourcePermissionMap();
            return TeaModel.build(map, self);
        }

        public GroupAddRequestResourcePermissionMap setCameraCheck(String cameraCheck) {
            this.cameraCheck = cameraCheck;
            return this;
        }
        public String getCameraCheck() {
            return this.cameraCheck;
        }

        public GroupAddRequestResourcePermissionMap setCheckPositionType(String checkPositionType) {
            this.checkPositionType = checkPositionType;
            return this;
        }
        public String getCheckPositionType() {
            return this.checkPositionType;
        }

        public GroupAddRequestResourcePermissionMap setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GroupAddRequestResourcePermissionMap setGroupMember(String groupMember) {
            this.groupMember = groupMember;
            return this;
        }
        public String getGroupMember() {
            return this.groupMember;
        }

        public GroupAddRequestResourcePermissionMap setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public GroupAddRequestResourcePermissionMap setOutSideCheck(String outSideCheck) {
            this.outSideCheck = outSideCheck;
            return this;
        }
        public String getOutSideCheck() {
            return this.outSideCheck;
        }

        public GroupAddRequestResourcePermissionMap setOverTimeRule(String overTimeRule) {
            this.overTimeRule = overTimeRule;
            return this;
        }
        public String getOverTimeRule() {
            return this.overTimeRule;
        }

        public GroupAddRequestResourcePermissionMap setSchedule(String schedule) {
            this.schedule = schedule;
            return this;
        }
        public String getSchedule() {
            return this.schedule;
        }

    }

    public static class GroupAddRequestShiftVOList extends TeaModel {
        // 班次ID，可通过获取班次摘要信息接口获取。
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
        // mac地址。
        @NameInMap("macAddr")
        public String macAddr;

        // wifi的ssid。
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
