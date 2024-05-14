// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ShiftAddRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("owner")
    public String owner;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sections")
    public java.util.List<ShiftAddRequestSections> sections;

    @NameInMap("serviceId")
    public Long serviceId;

    @NameInMap("setting")
    public ShiftAddRequestSetting setting;

    @NameInMap("shiftId")
    public Long shiftId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static ShiftAddRequest build(java.util.Map<String, ?> map) throws Exception {
        ShiftAddRequest self = new ShiftAddRequest();
        return TeaModel.build(map, self);
    }

    public ShiftAddRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ShiftAddRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public ShiftAddRequest setSections(java.util.List<ShiftAddRequestSections> sections) {
        this.sections = sections;
        return this;
    }
    public java.util.List<ShiftAddRequestSections> getSections() {
        return this.sections;
    }

    public ShiftAddRequest setServiceId(Long serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public Long getServiceId() {
        return this.serviceId;
    }

    public ShiftAddRequest setSetting(ShiftAddRequestSetting setting) {
        this.setting = setting;
        return this;
    }
    public ShiftAddRequestSetting getSetting() {
        return this.setting;
    }

    public ShiftAddRequest setShiftId(Long shiftId) {
        this.shiftId = shiftId;
        return this;
    }
    public Long getShiftId() {
        return this.shiftId;
    }

    public ShiftAddRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class ShiftAddRequestSectionsTimes extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("across")
        public Integer across;

        @NameInMap("beginMin")
        public Integer beginMin;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("checkTime")
        public Long checkTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("checkType")
        public String checkType;

        @NameInMap("endMin")
        public Integer endMin;

        @NameInMap("flexMinutes")
        public java.util.List<Integer> flexMinutes;

        @NameInMap("freeCheck")
        public Boolean freeCheck;

        public static ShiftAddRequestSectionsTimes build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSectionsTimes self = new ShiftAddRequestSectionsTimes();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSectionsTimes setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public ShiftAddRequestSectionsTimes setBeginMin(Integer beginMin) {
            this.beginMin = beginMin;
            return this;
        }
        public Integer getBeginMin() {
            return this.beginMin;
        }

        public ShiftAddRequestSectionsTimes setCheckTime(Long checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public Long getCheckTime() {
            return this.checkTime;
        }

        public ShiftAddRequestSectionsTimes setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

        public ShiftAddRequestSectionsTimes setEndMin(Integer endMin) {
            this.endMin = endMin;
            return this;
        }
        public Integer getEndMin() {
            return this.endMin;
        }

        public ShiftAddRequestSectionsTimes setFlexMinutes(java.util.List<Integer> flexMinutes) {
            this.flexMinutes = flexMinutes;
            return this;
        }
        public java.util.List<Integer> getFlexMinutes() {
            return this.flexMinutes;
        }

        public ShiftAddRequestSectionsTimes setFreeCheck(Boolean freeCheck) {
            this.freeCheck = freeCheck;
            return this;
        }
        public Boolean getFreeCheck() {
            return this.freeCheck;
        }

    }

    public static class ShiftAddRequestSections extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("times")
        public java.util.List<ShiftAddRequestSectionsTimes> times;

        public static ShiftAddRequestSections build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSections self = new ShiftAddRequestSections();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSections setTimes(java.util.List<ShiftAddRequestSectionsTimes> times) {
            this.times = times;
            return this;
        }
        public java.util.List<ShiftAddRequestSectionsTimes> getTimes() {
            return this.times;
        }

    }

    public static class ShiftAddRequestSettingTopRestTimeList extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public Long checkTime;

        public static ShiftAddRequestSettingTopRestTimeList build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSettingTopRestTimeList self = new ShiftAddRequestSettingTopRestTimeList();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSettingTopRestTimeList setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public ShiftAddRequestSettingTopRestTimeList setCheckTime(Long checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public Long getCheckTime() {
            return this.checkTime;
        }

    }

    public static class ShiftAddRequestSetting extends TeaModel {
        @NameInMap("absenteeismLateMinutes")
        public Integer absenteeismLateMinutes;

        @NameInMap("attendDays")
        public Double attendDays;

        @NameInMap("extras")
        public java.util.Map<String, ?> extras;

        @NameInMap("isFlexible")
        public Boolean isFlexible;

        @NameInMap("seriousLateMinutes")
        public Integer seriousLateMinutes;

        @NameInMap("tags")
        public String tags;

        @NameInMap("topRestTimeList")
        public java.util.List<ShiftAddRequestSettingTopRestTimeList> topRestTimeList;

        public static ShiftAddRequestSetting build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSetting self = new ShiftAddRequestSetting();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSetting setAbsenteeismLateMinutes(Integer absenteeismLateMinutes) {
            this.absenteeismLateMinutes = absenteeismLateMinutes;
            return this;
        }
        public Integer getAbsenteeismLateMinutes() {
            return this.absenteeismLateMinutes;
        }

        public ShiftAddRequestSetting setAttendDays(Double attendDays) {
            this.attendDays = attendDays;
            return this;
        }
        public Double getAttendDays() {
            return this.attendDays;
        }

        public ShiftAddRequestSetting setExtras(java.util.Map<String, ?> extras) {
            this.extras = extras;
            return this;
        }
        public java.util.Map<String, ?> getExtras() {
            return this.extras;
        }

        public ShiftAddRequestSetting setIsFlexible(Boolean isFlexible) {
            this.isFlexible = isFlexible;
            return this;
        }
        public Boolean getIsFlexible() {
            return this.isFlexible;
        }

        public ShiftAddRequestSetting setSeriousLateMinutes(Integer seriousLateMinutes) {
            this.seriousLateMinutes = seriousLateMinutes;
            return this;
        }
        public Integer getSeriousLateMinutes() {
            return this.seriousLateMinutes;
        }

        public ShiftAddRequestSetting setTags(String tags) {
            this.tags = tags;
            return this;
        }
        public String getTags() {
            return this.tags;
        }

        public ShiftAddRequestSetting setTopRestTimeList(java.util.List<ShiftAddRequestSettingTopRestTimeList> topRestTimeList) {
            this.topRestTimeList = topRestTimeList;
            return this;
        }
        public java.util.List<ShiftAddRequestSettingTopRestTimeList> getTopRestTimeList() {
            return this.topRestTimeList;
        }

    }

}
