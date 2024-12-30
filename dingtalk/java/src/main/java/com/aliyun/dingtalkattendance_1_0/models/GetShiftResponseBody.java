// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetShiftResponseBody extends TeaModel {
    @NameInMap("result")
    public GetShiftResponseBodyResult result;

    public static GetShiftResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShiftResponseBody self = new GetShiftResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShiftResponseBody setResult(GetShiftResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetShiftResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs extends TeaModel {
        @NameInMap("extra")
        public Long extra;

        @NameInMap("late")
        public Long late;

        public static GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs self = new GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs setExtra(Long extra) {
            this.extra = extra;
            return this;
        }
        public Long getExtra() {
            return this.extra;
        }

        public GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs setLate(Long late) {
            this.late = late;
            return this;
        }
        public Long getLate() {
            return this.late;
        }

    }

    public static class GetShiftResponseBodyResultSectionsPunchesLateBackSetting extends TeaModel {
        @NameInMap("lateBackPairs")
        public java.util.List<GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs> lateBackPairs;

        public static GetShiftResponseBodyResultSectionsPunchesLateBackSetting build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultSectionsPunchesLateBackSetting self = new GetShiftResponseBodyResultSectionsPunchesLateBackSetting();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultSectionsPunchesLateBackSetting setLateBackPairs(java.util.List<GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs> lateBackPairs) {
            this.lateBackPairs = lateBackPairs;
            return this;
        }
        public java.util.List<GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs> getLateBackPairs() {
            return this.lateBackPairs;
        }

    }

    public static class GetShiftResponseBodyResultSectionsPunches extends TeaModel {
        @NameInMap("absenteeismLateMinutes")
        public Long absenteeismLateMinutes;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("across")
        public Long across;

        @NameInMap("beginMin")
        public Long beginMin;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>1970-01-01 19:00:00</p>
         */
        @NameInMap("checkTime")
        public String checkTime;

        /**
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
        public Long endMin;

        @NameInMap("flexMinutes")
        public java.util.List<Long> flexMinutes;

        @NameInMap("freeCheck")
        public Boolean freeCheck;

        @NameInMap("lateBackSetting")
        public GetShiftResponseBodyResultSectionsPunchesLateBackSetting lateBackSetting;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("permitMinutes")
        public Long permitMinutes;

        /**
         * <strong>example:</strong>
         * <p>33928201</p>
         */
        @NameInMap("puncheId")
        public Long puncheId;

        @NameInMap("seriousLateMinutes")
        public Long seriousLateMinutes;

        public static GetShiftResponseBodyResultSectionsPunches build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultSectionsPunches self = new GetShiftResponseBodyResultSectionsPunches();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultSectionsPunches setAbsenteeismLateMinutes(Long absenteeismLateMinutes) {
            this.absenteeismLateMinutes = absenteeismLateMinutes;
            return this;
        }
        public Long getAbsenteeismLateMinutes() {
            return this.absenteeismLateMinutes;
        }

        public GetShiftResponseBodyResultSectionsPunches setAcross(Long across) {
            this.across = across;
            return this;
        }
        public Long getAcross() {
            return this.across;
        }

        public GetShiftResponseBodyResultSectionsPunches setBeginMin(Long beginMin) {
            this.beginMin = beginMin;
            return this;
        }
        public Long getBeginMin() {
            return this.beginMin;
        }

        public GetShiftResponseBodyResultSectionsPunches setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetShiftResponseBodyResultSectionsPunches setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

        public GetShiftResponseBodyResultSectionsPunches setEndMin(Long endMin) {
            this.endMin = endMin;
            return this;
        }
        public Long getEndMin() {
            return this.endMin;
        }

        public GetShiftResponseBodyResultSectionsPunches setFlexMinutes(java.util.List<Long> flexMinutes) {
            this.flexMinutes = flexMinutes;
            return this;
        }
        public java.util.List<Long> getFlexMinutes() {
            return this.flexMinutes;
        }

        public GetShiftResponseBodyResultSectionsPunches setFreeCheck(Boolean freeCheck) {
            this.freeCheck = freeCheck;
            return this;
        }
        public Boolean getFreeCheck() {
            return this.freeCheck;
        }

        public GetShiftResponseBodyResultSectionsPunches setLateBackSetting(GetShiftResponseBodyResultSectionsPunchesLateBackSetting lateBackSetting) {
            this.lateBackSetting = lateBackSetting;
            return this;
        }
        public GetShiftResponseBodyResultSectionsPunchesLateBackSetting getLateBackSetting() {
            return this.lateBackSetting;
        }

        public GetShiftResponseBodyResultSectionsPunches setPermitMinutes(Long permitMinutes) {
            this.permitMinutes = permitMinutes;
            return this;
        }
        public Long getPermitMinutes() {
            return this.permitMinutes;
        }

        public GetShiftResponseBodyResultSectionsPunches setPuncheId(Long puncheId) {
            this.puncheId = puncheId;
            return this;
        }
        public Long getPuncheId() {
            return this.puncheId;
        }

        public GetShiftResponseBodyResultSectionsPunches setSeriousLateMinutes(Long seriousLateMinutes) {
            this.seriousLateMinutes = seriousLateMinutes;
            return this;
        }
        public Long getSeriousLateMinutes() {
            return this.seriousLateMinutes;
        }

    }

    public static class GetShiftResponseBodyResultSectionsRests extends TeaModel {
        @NameInMap("across")
        public Long across;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("checkTime")
        public String checkTime;

        @NameInMap("checkType")
        public String checkType;

        @NameInMap("restId")
        public Long restId;

        public static GetShiftResponseBodyResultSectionsRests build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultSectionsRests self = new GetShiftResponseBodyResultSectionsRests();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultSectionsRests setAcross(Long across) {
            this.across = across;
            return this;
        }
        public Long getAcross() {
            return this.across;
        }

        public GetShiftResponseBodyResultSectionsRests setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetShiftResponseBodyResultSectionsRests setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

        public GetShiftResponseBodyResultSectionsRests setRestId(Long restId) {
            this.restId = restId;
            return this;
        }
        public Long getRestId() {
            return this.restId;
        }

    }

    public static class GetShiftResponseBodyResultSections extends TeaModel {
        @NameInMap("punches")
        public java.util.List<GetShiftResponseBodyResultSectionsPunches> punches;

        @NameInMap("rests")
        public java.util.List<GetShiftResponseBodyResultSectionsRests> rests;

        @NameInMap("sectionId")
        public Long sectionId;

        public static GetShiftResponseBodyResultSections build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultSections self = new GetShiftResponseBodyResultSections();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultSections setPunches(java.util.List<GetShiftResponseBodyResultSectionsPunches> punches) {
            this.punches = punches;
            return this;
        }
        public java.util.List<GetShiftResponseBodyResultSectionsPunches> getPunches() {
            return this.punches;
        }

        public GetShiftResponseBodyResultSections setRests(java.util.List<GetShiftResponseBodyResultSectionsRests> rests) {
            this.rests = rests;
            return this;
        }
        public java.util.List<GetShiftResponseBodyResultSectionsRests> getRests() {
            return this.rests;
        }

        public GetShiftResponseBodyResultSections setSectionId(Long sectionId) {
            this.sectionId = sectionId;
            return this;
        }
        public Long getSectionId() {
            return this.sectionId;
        }

    }

    public static class GetShiftResponseBodyResultShiftSetting extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("attendDays")
        public String attendDays;

        /**
         * <strong>example:</strong>
         * <p>dinge87f1xxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2020-09-06 15:49:27</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2020-09-06 15:49:27</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <strong>example:</strong>
         * <p>678215070</p>
         */
        @NameInMap("shiftId")
        public Long shiftId;

        /**
         * <strong>example:</strong>
         * <p>233840112</p>
         */
        @NameInMap("shiftSettingId")
        public Long shiftSettingId;

        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         */
        @NameInMap("shiftType")
        public String shiftType;

        /**
         * <strong>example:</strong>
         * <p>600</p>
         */
        @NameInMap("workTimeMinutes")
        public Long workTimeMinutes;

        public static GetShiftResponseBodyResultShiftSetting build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResultShiftSetting self = new GetShiftResponseBodyResultShiftSetting();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResultShiftSetting setAttendDays(String attendDays) {
            this.attendDays = attendDays;
            return this;
        }
        public String getAttendDays() {
            return this.attendDays;
        }

        public GetShiftResponseBodyResultShiftSetting setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetShiftResponseBodyResultShiftSetting setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetShiftResponseBodyResultShiftSetting setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetShiftResponseBodyResultShiftSetting setShiftId(Long shiftId) {
            this.shiftId = shiftId;
            return this;
        }
        public Long getShiftId() {
            return this.shiftId;
        }

        public GetShiftResponseBodyResultShiftSetting setShiftSettingId(Long shiftSettingId) {
            this.shiftSettingId = shiftSettingId;
            return this;
        }
        public Long getShiftSettingId() {
            return this.shiftSettingId;
        }

        public GetShiftResponseBodyResultShiftSetting setShiftType(String shiftType) {
            this.shiftType = shiftType;
            return this;
        }
        public String getShiftType() {
            return this.shiftType;
        }

        public GetShiftResponseBodyResultShiftSetting setWorkTimeMinutes(Long workTimeMinutes) {
            this.workTimeMinutes = workTimeMinutes;
            return this;
        }
        public Long getWorkTimeMinutes() {
            return this.workTimeMinutes;
        }

    }

    public static class GetShiftResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dinge87f1xxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>678215070</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>B</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>user123</p>
         */
        @NameInMap("owner")
        public String owner;

        @NameInMap("sections")
        public java.util.List<GetShiftResponseBodyResultSections> sections;

        @NameInMap("shiftGroupId")
        public Long shiftGroupId;

        /**
         * <strong>example:</strong>
         * <p>考勤班</p>
         */
        @NameInMap("shiftGroupName")
        public String shiftGroupName;

        @NameInMap("shiftSetting")
        public GetShiftResponseBodyResultShiftSetting shiftSetting;

        public static GetShiftResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShiftResponseBodyResult self = new GetShiftResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShiftResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetShiftResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetShiftResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetShiftResponseBodyResult setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public GetShiftResponseBodyResult setSections(java.util.List<GetShiftResponseBodyResultSections> sections) {
            this.sections = sections;
            return this;
        }
        public java.util.List<GetShiftResponseBodyResultSections> getSections() {
            return this.sections;
        }

        public GetShiftResponseBodyResult setShiftGroupId(Long shiftGroupId) {
            this.shiftGroupId = shiftGroupId;
            return this;
        }
        public Long getShiftGroupId() {
            return this.shiftGroupId;
        }

        public GetShiftResponseBodyResult setShiftGroupName(String shiftGroupName) {
            this.shiftGroupName = shiftGroupName;
            return this;
        }
        public String getShiftGroupName() {
            return this.shiftGroupName;
        }

        public GetShiftResponseBodyResult setShiftSetting(GetShiftResponseBodyResultShiftSetting shiftSetting) {
            this.shiftSetting = shiftSetting;
            return this;
        }
        public GetShiftResponseBodyResultShiftSetting getShiftSetting() {
            return this.shiftSetting;
        }

    }

}
