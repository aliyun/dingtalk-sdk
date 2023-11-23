// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClassWithDeletedResponseBody extends TeaModel {
    @NameInMap("result")
    public GetClassWithDeletedResponseBodyResult result;

    public static GetClassWithDeletedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetClassWithDeletedResponseBody self = new GetClassWithDeletedResponseBody();
        return TeaModel.build(map, self);
    }

    public GetClassWithDeletedResponseBody setResult(GetClassWithDeletedResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetClassWithDeletedResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public String checkTime;

        public static GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin self = new GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

    }

    public static class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("checkTime")
        public String checkTime;

        public static GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd self = new GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

    }

    public static class GetClassWithDeletedResponseBodyResultClassSettingRestTimeList extends TeaModel {
        @NameInMap("begin")
        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin begin;

        @NameInMap("end")
        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd end;

        public static GetClassWithDeletedResponseBodyResultClassSettingRestTimeList build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultClassSettingRestTimeList self = new GetClassWithDeletedResponseBodyResultClassSettingRestTimeList();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeList setBegin(GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin begin) {
            this.begin = begin;
            return this;
        }
        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin getBegin() {
            return this.begin;
        }

        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeList setEnd(GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd end) {
            this.end = end;
            return this;
        }
        public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd getEnd() {
            return this.end;
        }

    }

    public static class GetClassWithDeletedResponseBodyResultClassSetting extends TeaModel {
        @NameInMap("classSettingId")
        public Long classSettingId;

        @NameInMap("restTimeList")
        public java.util.List<GetClassWithDeletedResponseBodyResultClassSettingRestTimeList> restTimeList;

        public static GetClassWithDeletedResponseBodyResultClassSetting build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultClassSetting self = new GetClassWithDeletedResponseBodyResultClassSetting();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultClassSetting setClassSettingId(Long classSettingId) {
            this.classSettingId = classSettingId;
            return this;
        }
        public Long getClassSettingId() {
            return this.classSettingId;
        }

        public GetClassWithDeletedResponseBodyResultClassSetting setRestTimeList(java.util.List<GetClassWithDeletedResponseBodyResultClassSettingRestTimeList> restTimeList) {
            this.restTimeList = restTimeList;
            return this;
        }
        public java.util.List<GetClassWithDeletedResponseBodyResultClassSettingRestTimeList> getRestTimeList() {
            return this.restTimeList;
        }

    }

    public static class GetClassWithDeletedResponseBodyResultSectionsTimes extends TeaModel {
        @NameInMap("across")
        public Integer across;

        @NameInMap("beginMin")
        public Long beginMin;

        @NameInMap("checkTime")
        public String checkTime;

        @NameInMap("checkType")
        public String checkType;

        @NameInMap("endMin")
        public Long endMin;

        public static GetClassWithDeletedResponseBodyResultSectionsTimes build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultSectionsTimes self = new GetClassWithDeletedResponseBodyResultSectionsTimes();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultSectionsTimes setAcross(Integer across) {
            this.across = across;
            return this;
        }
        public Integer getAcross() {
            return this.across;
        }

        public GetClassWithDeletedResponseBodyResultSectionsTimes setBeginMin(Long beginMin) {
            this.beginMin = beginMin;
            return this;
        }
        public Long getBeginMin() {
            return this.beginMin;
        }

        public GetClassWithDeletedResponseBodyResultSectionsTimes setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetClassWithDeletedResponseBodyResultSectionsTimes setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

        public GetClassWithDeletedResponseBodyResultSectionsTimes setEndMin(Long endMin) {
            this.endMin = endMin;
            return this;
        }
        public Long getEndMin() {
            return this.endMin;
        }

    }

    public static class GetClassWithDeletedResponseBodyResultSections extends TeaModel {
        @NameInMap("times")
        public java.util.List<GetClassWithDeletedResponseBodyResultSectionsTimes> times;

        public static GetClassWithDeletedResponseBodyResultSections build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResultSections self = new GetClassWithDeletedResponseBodyResultSections();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResultSections setTimes(java.util.List<GetClassWithDeletedResponseBodyResultSectionsTimes> times) {
            this.times = times;
            return this;
        }
        public java.util.List<GetClassWithDeletedResponseBodyResultSectionsTimes> getTimes() {
            return this.times;
        }

    }

    public static class GetClassWithDeletedResponseBodyResult extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("classSetting")
        public GetClassWithDeletedResponseBodyResultClassSetting classSetting;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("name")
        public String name;

        @NameInMap("sections")
        public java.util.List<GetClassWithDeletedResponseBodyResultSections> sections;

        @NameInMap("workDays")
        public java.util.List<Integer> workDays;

        public static GetClassWithDeletedResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetClassWithDeletedResponseBodyResult self = new GetClassWithDeletedResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetClassWithDeletedResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public GetClassWithDeletedResponseBodyResult setClassSetting(GetClassWithDeletedResponseBodyResultClassSetting classSetting) {
            this.classSetting = classSetting;
            return this;
        }
        public GetClassWithDeletedResponseBodyResultClassSetting getClassSetting() {
            return this.classSetting;
        }

        public GetClassWithDeletedResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetClassWithDeletedResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetClassWithDeletedResponseBodyResult setSections(java.util.List<GetClassWithDeletedResponseBodyResultSections> sections) {
            this.sections = sections;
            return this;
        }
        public java.util.List<GetClassWithDeletedResponseBodyResultSections> getSections() {
            return this.sections;
        }

        public GetClassWithDeletedResponseBodyResult setWorkDays(java.util.List<Integer> workDays) {
            this.workDays = workDays;
            return this;
        }
        public java.util.List<Integer> getWorkDays() {
            return this.workDays;
        }

    }

}
