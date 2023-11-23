// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleGroupsResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSimpleGroupsResponseBodyResult result;

    public static GetSimpleGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleGroupsResponseBody self = new GetSimpleGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSimpleGroupsResponseBody setResult(GetSimpleGroupsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSimpleGroupsResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public String checkTime;

        @NameInMap("checkType")
        public String checkType;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections extends TeaModel {
        @NameInMap("times")
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes> times;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections setTimes(java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes> times) {
            this.times = times;
            return this;
        }
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes> getTimes() {
            return this.times;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public String checkTime;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public String checkTime;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList extends TeaModel {
        @NameInMap("begin")
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin begin;

        @NameInMap("end")
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd end;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList setBegin(GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin begin) {
            this.begin = begin;
            return this;
        }
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin getBegin() {
            return this.begin;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList setEnd(GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd end) {
            this.end = end;
            return this;
        }
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd getEnd() {
            return this.end;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting extends TeaModel {
        @NameInMap("absenteeismLateMinutes")
        public Integer absenteeismLateMinutes;

        @NameInMap("classSettingId")
        public Long classSettingId;

        @NameInMap("isOffDutyFreeCheck")
        public String isOffDutyFreeCheck;

        @NameInMap("permitLateMinutes")
        public Integer permitLateMinutes;

        @NameInMap("restTimeList")
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList> restTimeList;

        @NameInMap("seriousLateMinutes")
        public Integer seriousLateMinutes;

        @NameInMap("workTimeMinutes")
        public Integer workTimeMinutes;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setAbsenteeismLateMinutes(Integer absenteeismLateMinutes) {
            this.absenteeismLateMinutes = absenteeismLateMinutes;
            return this;
        }
        public Integer getAbsenteeismLateMinutes() {
            return this.absenteeismLateMinutes;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setClassSettingId(Long classSettingId) {
            this.classSettingId = classSettingId;
            return this;
        }
        public Long getClassSettingId() {
            return this.classSettingId;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setIsOffDutyFreeCheck(String isOffDutyFreeCheck) {
            this.isOffDutyFreeCheck = isOffDutyFreeCheck;
            return this;
        }
        public String getIsOffDutyFreeCheck() {
            return this.isOffDutyFreeCheck;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setPermitLateMinutes(Integer permitLateMinutes) {
            this.permitLateMinutes = permitLateMinutes;
            return this;
        }
        public Integer getPermitLateMinutes() {
            return this.permitLateMinutes;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setRestTimeList(java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList> restTimeList) {
            this.restTimeList = restTimeList;
            return this;
        }
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList> getRestTimeList() {
            return this.restTimeList;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setSeriousLateMinutes(Integer seriousLateMinutes) {
            this.seriousLateMinutes = seriousLateMinutes;
            return this;
        }
        public Integer getSeriousLateMinutes() {
            return this.seriousLateMinutes;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setWorkTimeMinutes(Integer workTimeMinutes) {
            this.workTimeMinutes = workTimeMinutes;
            return this;
        }
        public Integer getWorkTimeMinutes() {
            return this.workTimeMinutes;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroupsSelectedClass extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("className")
        public String className;

        @NameInMap("sections")
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections> sections;

        @NameInMap("setting")
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setting;

        public static GetSimpleGroupsResponseBodyResultGroupsSelectedClass build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroupsSelectedClass self = new GetSimpleGroupsResponseBodyResultGroupsSelectedClass();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClass setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClass setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClass setSections(java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections> sections) {
            this.sections = sections;
            return this;
        }
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections> getSections() {
            return this.sections;
        }

        public GetSimpleGroupsResponseBodyResultGroupsSelectedClass setSetting(GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting setting) {
            this.setting = setting;
            return this;
        }
        public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting getSetting() {
            return this.setting;
        }

    }

    public static class GetSimpleGroupsResponseBodyResultGroups extends TeaModel {
        @NameInMap("classesList")
        public java.util.List<String> classesList;

        @NameInMap("defaultClassId")
        public Long defaultClassId;

        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("deptNameList")
        public java.util.List<String> deptNameList;

        @NameInMap("disableCheckWhenRest")
        public Boolean disableCheckWhenRest;

        @NameInMap("disableCheckWithoutSchedule")
        public Boolean disableCheckWithoutSchedule;

        @NameInMap("enableEmpSelectClass")
        public Boolean enableEmpSelectClass;

        @NameInMap("freeCheckDayStartMinOffset")
        public Integer freeCheckDayStartMinOffset;

        @NameInMap("freecheckWorkDays")
        public java.util.List<Integer> freecheckWorkDays;

        @NameInMap("groupId")
        public Long groupId;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("isDefault")
        public Boolean isDefault;

        @NameInMap("managerList")
        public java.util.List<String> managerList;

        @NameInMap("memberCount")
        public Integer memberCount;

        @NameInMap("ownerUserId")
        public String ownerUserId;

        @NameInMap("selectedClass")
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClass> selectedClass;

        @NameInMap("type")
        public String type;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        @NameInMap("workDayList")
        public java.util.List<String> workDayList;

        public static GetSimpleGroupsResponseBodyResultGroups build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResultGroups self = new GetSimpleGroupsResponseBodyResultGroups();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResultGroups setClassesList(java.util.List<String> classesList) {
            this.classesList = classesList;
            return this;
        }
        public java.util.List<String> getClassesList() {
            return this.classesList;
        }

        public GetSimpleGroupsResponseBodyResultGroups setDefaultClassId(Long defaultClassId) {
            this.defaultClassId = defaultClassId;
            return this;
        }
        public Long getDefaultClassId() {
            return this.defaultClassId;
        }

        public GetSimpleGroupsResponseBodyResultGroups setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public GetSimpleGroupsResponseBodyResultGroups setDeptNameList(java.util.List<String> deptNameList) {
            this.deptNameList = deptNameList;
            return this;
        }
        public java.util.List<String> getDeptNameList() {
            return this.deptNameList;
        }

        public GetSimpleGroupsResponseBodyResultGroups setDisableCheckWhenRest(Boolean disableCheckWhenRest) {
            this.disableCheckWhenRest = disableCheckWhenRest;
            return this;
        }
        public Boolean getDisableCheckWhenRest() {
            return this.disableCheckWhenRest;
        }

        public GetSimpleGroupsResponseBodyResultGroups setDisableCheckWithoutSchedule(Boolean disableCheckWithoutSchedule) {
            this.disableCheckWithoutSchedule = disableCheckWithoutSchedule;
            return this;
        }
        public Boolean getDisableCheckWithoutSchedule() {
            return this.disableCheckWithoutSchedule;
        }

        public GetSimpleGroupsResponseBodyResultGroups setEnableEmpSelectClass(Boolean enableEmpSelectClass) {
            this.enableEmpSelectClass = enableEmpSelectClass;
            return this;
        }
        public Boolean getEnableEmpSelectClass() {
            return this.enableEmpSelectClass;
        }

        public GetSimpleGroupsResponseBodyResultGroups setFreeCheckDayStartMinOffset(Integer freeCheckDayStartMinOffset) {
            this.freeCheckDayStartMinOffset = freeCheckDayStartMinOffset;
            return this;
        }
        public Integer getFreeCheckDayStartMinOffset() {
            return this.freeCheckDayStartMinOffset;
        }

        public GetSimpleGroupsResponseBodyResultGroups setFreecheckWorkDays(java.util.List<Integer> freecheckWorkDays) {
            this.freecheckWorkDays = freecheckWorkDays;
            return this;
        }
        public java.util.List<Integer> getFreecheckWorkDays() {
            return this.freecheckWorkDays;
        }

        public GetSimpleGroupsResponseBodyResultGroups setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public GetSimpleGroupsResponseBodyResultGroups setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetSimpleGroupsResponseBodyResultGroups setIsDefault(Boolean isDefault) {
            this.isDefault = isDefault;
            return this;
        }
        public Boolean getIsDefault() {
            return this.isDefault;
        }

        public GetSimpleGroupsResponseBodyResultGroups setManagerList(java.util.List<String> managerList) {
            this.managerList = managerList;
            return this;
        }
        public java.util.List<String> getManagerList() {
            return this.managerList;
        }

        public GetSimpleGroupsResponseBodyResultGroups setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public GetSimpleGroupsResponseBodyResultGroups setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public GetSimpleGroupsResponseBodyResultGroups setSelectedClass(java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClass> selectedClass) {
            this.selectedClass = selectedClass;
            return this;
        }
        public java.util.List<GetSimpleGroupsResponseBodyResultGroupsSelectedClass> getSelectedClass() {
            return this.selectedClass;
        }

        public GetSimpleGroupsResponseBodyResultGroups setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetSimpleGroupsResponseBodyResultGroups setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

        public GetSimpleGroupsResponseBodyResultGroups setWorkDayList(java.util.List<String> workDayList) {
            this.workDayList = workDayList;
            return this;
        }
        public java.util.List<String> getWorkDayList() {
            return this.workDayList;
        }

    }

    public static class GetSimpleGroupsResponseBodyResult extends TeaModel {
        @NameInMap("groups")
        public java.util.List<GetSimpleGroupsResponseBodyResultGroups> groups;

        @NameInMap("hasMore")
        public Boolean hasMore;

        public static GetSimpleGroupsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleGroupsResponseBodyResult self = new GetSimpleGroupsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSimpleGroupsResponseBodyResult setGroups(java.util.List<GetSimpleGroupsResponseBodyResultGroups> groups) {
            this.groups = groups;
            return this;
        }
        public java.util.List<GetSimpleGroupsResponseBodyResultGroups> getGroups() {
            return this.groups;
        }

        public GetSimpleGroupsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

    }

}
