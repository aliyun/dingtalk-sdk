// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportEmpInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportEmpInfoRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportEmpInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportEmpInfoRequest self = new HrbrainImportEmpInfoRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportEmpInfoRequest setBody(java.util.List<HrbrainImportEmpInfoRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportEmpInfoRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportEmpInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportEmpInfoRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("birthday")
        public String birthday;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("dimissionDate")
        public String dimissionDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("empSource")
        public String empSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("empStatus")
        public String empStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("empType")
        public String empType;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gender")
        public String gender;

        @NameInMap("highestDegree")
        public String highestDegree;

        @NameInMap("highestEduName")
        public String highestEduName;

        @NameInMap("isDimission")
        public String isDimission;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobCodeName")
        public String jobCodeName;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("lastSchoolName")
        public String lastSchoolName;

        @NameInMap("marriage")
        public String marriage;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nation")
        public String nation;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nationCtry")
        public String nationCtry;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("politicalStatus")
        public String politicalStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("postName")
        public String postName;

        @NameInMap("registDate")
        public String registDate;

        @NameInMap("regularDate")
        public String regularDate;

        @NameInMap("superEmpId")
        public String superEmpId;

        @NameInMap("superName")
        public String superName;

        @NameInMap("workEmail")
        public String workEmail;

        @NameInMap("workLocAddr")
        public String workLocAddr;

        @NameInMap("workLocCity")
        public String workLocCity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportEmpInfoRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportEmpInfoRequestBody self = new HrbrainImportEmpInfoRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportEmpInfoRequestBody setBirthday(String birthday) {
            this.birthday = birthday;
            return this;
        }
        public String getBirthday() {
            return this.birthday;
        }

        public HrbrainImportEmpInfoRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportEmpInfoRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportEmpInfoRequestBody setDimissionDate(String dimissionDate) {
            this.dimissionDate = dimissionDate;
            return this;
        }
        public String getDimissionDate() {
            return this.dimissionDate;
        }

        public HrbrainImportEmpInfoRequestBody setEmpSource(String empSource) {
            this.empSource = empSource;
            return this;
        }
        public String getEmpSource() {
            return this.empSource;
        }

        public HrbrainImportEmpInfoRequestBody setEmpStatus(String empStatus) {
            this.empStatus = empStatus;
            return this;
        }
        public String getEmpStatus() {
            return this.empStatus;
        }

        public HrbrainImportEmpInfoRequestBody setEmpType(String empType) {
            this.empType = empType;
            return this;
        }
        public String getEmpType() {
            return this.empType;
        }

        public HrbrainImportEmpInfoRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportEmpInfoRequestBody setGender(String gender) {
            this.gender = gender;
            return this;
        }
        public String getGender() {
            return this.gender;
        }

        public HrbrainImportEmpInfoRequestBody setHighestDegree(String highestDegree) {
            this.highestDegree = highestDegree;
            return this;
        }
        public String getHighestDegree() {
            return this.highestDegree;
        }

        public HrbrainImportEmpInfoRequestBody setHighestEduName(String highestEduName) {
            this.highestEduName = highestEduName;
            return this;
        }
        public String getHighestEduName() {
            return this.highestEduName;
        }

        public HrbrainImportEmpInfoRequestBody setIsDimission(String isDimission) {
            this.isDimission = isDimission;
            return this;
        }
        public String getIsDimission() {
            return this.isDimission;
        }

        public HrbrainImportEmpInfoRequestBody setJobCodeName(String jobCodeName) {
            this.jobCodeName = jobCodeName;
            return this;
        }
        public String getJobCodeName() {
            return this.jobCodeName;
        }

        public HrbrainImportEmpInfoRequestBody setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainImportEmpInfoRequestBody setLastSchoolName(String lastSchoolName) {
            this.lastSchoolName = lastSchoolName;
            return this;
        }
        public String getLastSchoolName() {
            return this.lastSchoolName;
        }

        public HrbrainImportEmpInfoRequestBody setMarriage(String marriage) {
            this.marriage = marriage;
            return this;
        }
        public String getMarriage() {
            return this.marriage;
        }

        public HrbrainImportEmpInfoRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportEmpInfoRequestBody setNation(String nation) {
            this.nation = nation;
            return this;
        }
        public String getNation() {
            return this.nation;
        }

        public HrbrainImportEmpInfoRequestBody setNationCtry(String nationCtry) {
            this.nationCtry = nationCtry;
            return this;
        }
        public String getNationCtry() {
            return this.nationCtry;
        }

        public HrbrainImportEmpInfoRequestBody setPoliticalStatus(String politicalStatus) {
            this.politicalStatus = politicalStatus;
            return this;
        }
        public String getPoliticalStatus() {
            return this.politicalStatus;
        }

        public HrbrainImportEmpInfoRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportEmpInfoRequestBody setRegistDate(String registDate) {
            this.registDate = registDate;
            return this;
        }
        public String getRegistDate() {
            return this.registDate;
        }

        public HrbrainImportEmpInfoRequestBody setRegularDate(String regularDate) {
            this.regularDate = regularDate;
            return this;
        }
        public String getRegularDate() {
            return this.regularDate;
        }

        public HrbrainImportEmpInfoRequestBody setSuperEmpId(String superEmpId) {
            this.superEmpId = superEmpId;
            return this;
        }
        public String getSuperEmpId() {
            return this.superEmpId;
        }

        public HrbrainImportEmpInfoRequestBody setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

        public HrbrainImportEmpInfoRequestBody setWorkEmail(String workEmail) {
            this.workEmail = workEmail;
            return this;
        }
        public String getWorkEmail() {
            return this.workEmail;
        }

        public HrbrainImportEmpInfoRequestBody setWorkLocAddr(String workLocAddr) {
            this.workLocAddr = workLocAddr;
            return this;
        }
        public String getWorkLocAddr() {
            return this.workLocAddr;
        }

        public HrbrainImportEmpInfoRequestBody setWorkLocCity(String workLocCity) {
            this.workLocCity = workLocCity;
            return this;
        }
        public String getWorkLocCity() {
            return this.workLocCity;
        }

        public HrbrainImportEmpInfoRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
