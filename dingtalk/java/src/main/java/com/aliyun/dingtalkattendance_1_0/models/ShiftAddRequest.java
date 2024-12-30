// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ShiftAddRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>白班</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>user01</p>
     */
    @NameInMap("owner")
    public String owner;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sections")
    public java.util.List<ShiftAddRequestSections> sections;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("serviceId")
    public Long serviceId;

    @NameInMap("setting")
    public ShiftAddRequestSetting setting;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("shiftId")
    public Long shiftId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user01</p>
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
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("across")
        public Integer across;

        /**
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("beginMin")
        public Integer beginMin;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1714298274613</p>
         */
        @NameInMap("checkTime")
        public Long checkTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>OnDuty</p>
         */
        @NameInMap("checkType")
        public String checkType;

        /**
         * <strong>example:</strong>
         * <p>-1</p>
         */
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

    public static class ShiftAddRequestSettingLateBackSettingSections extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>120</p>
         */
        @NameInMap("extra")
        public Integer extra;

        /**
         * <strong>example:</strong>
         * <p>60</p>
         */
        @NameInMap("late")
        public Integer late;

        public static ShiftAddRequestSettingLateBackSettingSections build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSettingLateBackSettingSections self = new ShiftAddRequestSettingLateBackSettingSections();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSettingLateBackSettingSections setExtra(Integer extra) {
            this.extra = extra;
            return this;
        }
        public Integer getExtra() {
            return this.extra;
        }

        public ShiftAddRequestSettingLateBackSettingSections setLate(Integer late) {
            this.late = late;
            return this;
        }
        public Integer getLate() {
            return this.late;
        }

    }

    public static class ShiftAddRequestSettingLateBackSetting extends TeaModel {
        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("sections")
        public java.util.List<ShiftAddRequestSettingLateBackSettingSections> sections;

        public static ShiftAddRequestSettingLateBackSetting build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddRequestSettingLateBackSetting self = new ShiftAddRequestSettingLateBackSetting();
            return TeaModel.build(map, self);
        }

        public ShiftAddRequestSettingLateBackSetting setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public ShiftAddRequestSettingLateBackSetting setSections(java.util.List<ShiftAddRequestSettingLateBackSettingSections> sections) {
            this.sections = sections;
            return this;
        }
        public java.util.List<ShiftAddRequestSettingLateBackSettingSections> getSections() {
            return this.sections;
        }

    }

    public static class ShiftAddRequestSettingTopRestTimeList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("across")
        public Integer across;

        /**
         * <strong>example:</strong>
         * <p>1714298002940</p>
         */
        @NameInMap("checkTime")
        public Long checkTime;

        /**
         * <strong>example:</strong>
         * <p>OnDuty</p>
         */
        @NameInMap("checkType")
        public String checkType;

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

        public ShiftAddRequestSettingTopRestTimeList setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

    }

    public static class ShiftAddRequestSetting extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>60</p>
         */
        @NameInMap("absenteeismLateMinutes")
        public Integer absenteeismLateMinutes;

        /**
         * <strong>example:</strong>
         * <p>0.8</p>
         */
        @NameInMap("attendDays")
        public Double attendDays;

        /**
         * <strong>example:</strong>
         * <p>480</p>
         */
        @NameInMap("demandWorkTimeMinutes")
        public Integer demandWorkTimeMinutes;

        @NameInMap("enableOutsideLateBack")
        public Boolean enableOutsideLateBack;

        @NameInMap("extras")
        public java.util.Map<String, ?> extras;

        @NameInMap("isFlexible")
        public Boolean isFlexible;

        @NameInMap("lateBackSetting")
        public ShiftAddRequestSettingLateBackSetting lateBackSetting;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("referenceClassId")
        public Long referenceClassId;

        /**
         * <strong>example:</strong>
         * <p>31</p>
         */
        @NameInMap("seriousLateMinutes")
        public Integer seriousLateMinutes;

        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         * 
         * <strong>if can be null:</strong>
         * <p>false</p>
         */
        @NameInMap("shiftType")
        public String shiftType;

        /**
         * <strong>example:</strong>
         * <p>temp:schedule:isv</p>
         */
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

        public ShiftAddRequestSetting setDemandWorkTimeMinutes(Integer demandWorkTimeMinutes) {
            this.demandWorkTimeMinutes = demandWorkTimeMinutes;
            return this;
        }
        public Integer getDemandWorkTimeMinutes() {
            return this.demandWorkTimeMinutes;
        }

        public ShiftAddRequestSetting setEnableOutsideLateBack(Boolean enableOutsideLateBack) {
            this.enableOutsideLateBack = enableOutsideLateBack;
            return this;
        }
        public Boolean getEnableOutsideLateBack() {
            return this.enableOutsideLateBack;
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

        public ShiftAddRequestSetting setLateBackSetting(ShiftAddRequestSettingLateBackSetting lateBackSetting) {
            this.lateBackSetting = lateBackSetting;
            return this;
        }
        public ShiftAddRequestSettingLateBackSetting getLateBackSetting() {
            return this.lateBackSetting;
        }

        public ShiftAddRequestSetting setReferenceClassId(Long referenceClassId) {
            this.referenceClassId = referenceClassId;
            return this;
        }
        public Long getReferenceClassId() {
            return this.referenceClassId;
        }

        public ShiftAddRequestSetting setSeriousLateMinutes(Integer seriousLateMinutes) {
            this.seriousLateMinutes = seriousLateMinutes;
            return this;
        }
        public Integer getSeriousLateMinutes() {
            return this.seriousLateMinutes;
        }

        public ShiftAddRequestSetting setShiftType(String shiftType) {
            this.shiftType = shiftType;
            return this;
        }
        public String getShiftType() {
            return this.shiftType;
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
