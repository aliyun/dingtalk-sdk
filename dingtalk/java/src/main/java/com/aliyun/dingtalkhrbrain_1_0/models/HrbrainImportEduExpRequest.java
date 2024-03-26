// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportEduExpRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportEduExpRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportEduExpRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportEduExpRequest self = new HrbrainImportEduExpRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportEduExpRequest setBody(java.util.List<HrbrainImportEduExpRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportEduExpRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportEduExpRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportEduExpRequestBody extends TeaModel {
        @NameInMap("eduName")
        public String eduName;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("major")
        public String major;

        @NameInMap("name")
        public String name;

        @NameInMap("schoolName")
        public String schoolName;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportEduExpRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportEduExpRequestBody self = new HrbrainImportEduExpRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportEduExpRequestBody setEduName(String eduName) {
            this.eduName = eduName;
            return this;
        }
        public String getEduName() {
            return this.eduName;
        }

        public HrbrainImportEduExpRequestBody setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public HrbrainImportEduExpRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportEduExpRequestBody setMajor(String major) {
            this.major = major;
            return this;
        }
        public String getMajor() {
            return this.major;
        }

        public HrbrainImportEduExpRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportEduExpRequestBody setSchoolName(String schoolName) {
            this.schoolName = schoolName;
            return this;
        }
        public String getSchoolName() {
            return this.schoolName;
        }

        public HrbrainImportEduExpRequestBody setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public HrbrainImportEduExpRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
