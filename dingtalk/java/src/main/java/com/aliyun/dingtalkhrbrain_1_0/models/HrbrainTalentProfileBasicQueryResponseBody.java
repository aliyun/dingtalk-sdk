// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileBasicQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainTalentProfileBasicQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainTalentProfileBasicQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileBasicQueryResponseBody self = new HrbrainTalentProfileBasicQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileBasicQueryResponseBody setContent(HrbrainTalentProfileBasicQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainTalentProfileBasicQueryResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainTalentProfileBasicQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainTalentProfileBasicQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainTalentProfileBasicQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList extends TeaModel {
        @NameInMap("age")
        public String age;

        @NameInMap("birthday")
        public String birthday;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("gender")
        public String gender;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("jobcode")
        public String jobcode;

        @NameInMap("name")
        public String name;

        @NameInMap("position")
        public String position;

        @NameInMap("seniorityYears")
        public String seniorityYears;

        @NameInMap("superName")
        public String superName;

        @NameInMap("superWorkNo")
        public String superWorkNo;

        @NameInMap("workNo")
        public String workNo;

        @NameInMap("workPlace")
        public String workPlace;

        public static HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList build(java.util.Map<String, ?> map) throws Exception {
            HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList self = new HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList();
            return TeaModel.build(map, self);
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setAge(String age) {
            this.age = age;
            return this;
        }
        public String getAge() {
            return this.age;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setBirthday(String birthday) {
            this.birthday = birthday;
            return this;
        }
        public String getBirthday() {
            return this.birthday;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setGender(String gender) {
            this.gender = gender;
            return this;
        }
        public String getGender() {
            return this.gender;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setJobcode(String jobcode) {
            this.jobcode = jobcode;
            return this;
        }
        public String getJobcode() {
            return this.jobcode;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setSeniorityYears(String seniorityYears) {
            this.seniorityYears = seniorityYears;
            return this;
        }
        public String getSeniorityYears() {
            return this.seniorityYears;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setSuperWorkNo(String superWorkNo) {
            this.superWorkNo = superWorkNo;
            return this;
        }
        public String getSuperWorkNo() {
            return this.superWorkNo;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList setWorkPlace(String workPlace) {
            this.workPlace = workPlace;
            return this;
        }
        public String getWorkPlace() {
            return this.workPlace;
        }

    }

    public static class HrbrainTalentProfileBasicQueryResponseBodyContent extends TeaModel {
        @NameInMap("profileBaseInfoList")
        public java.util.List<HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList> profileBaseInfoList;

        public static HrbrainTalentProfileBasicQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainTalentProfileBasicQueryResponseBodyContent self = new HrbrainTalentProfileBasicQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainTalentProfileBasicQueryResponseBodyContent setProfileBaseInfoList(java.util.List<HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList> profileBaseInfoList) {
            this.profileBaseInfoList = profileBaseInfoList;
            return this;
        }
        public java.util.List<HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList> getProfileBaseInfoList() {
            return this.profileBaseInfoList;
        }

    }

}
