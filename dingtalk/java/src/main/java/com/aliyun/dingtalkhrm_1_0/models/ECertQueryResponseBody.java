// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ECertQueryResponseBody extends TeaModel {
    // 身份证号码
    @NameInMap("certNO")
    public String certNO;

    // 职务ID
    @NameInMap("employJobId")
    public String employJobId;

    // 职务名称
    @NameInMap("employJobIdLabel")
    public String employJobIdLabel;

    // 职位ID
    @NameInMap("employPositionId")
    public String employPositionId;

    // 职位名称
    @NameInMap("employPositionIdLabel")
    public String employPositionIdLabel;

    // 职级ID
    @NameInMap("employPositionRankId")
    public String employPositionRankId;

    // 职级名称
    @NameInMap("employPositionRankIdLabel")
    public String employPositionRankIdLabel;

    // 入职日期
    @NameInMap("hiredDate")
    public String hiredDate;

    // 离职日期
    @NameInMap("lastWorkDay")
    public String lastWorkDay;

    // 主部门ID
    @NameInMap("mainDeptId")
    public Long mainDeptId;

    // 主部门
    @NameInMap("mainDeptName")
    public String mainDeptName;

    // 姓名
    @NameInMap("name")
    public String name;

    // 身份证姓名
    @NameInMap("realName")
    public String realName;

    // 被动离职原因
    @NameInMap("terminationReasonPassive")
    public java.util.List<String> terminationReasonPassive;

    // 主动离职原因
    @NameInMap("terminationReasonVoluntary")
    public java.util.List<String> terminationReasonVoluntary;

    public static ECertQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ECertQueryResponseBody self = new ECertQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public ECertQueryResponseBody setCertNO(String certNO) {
        this.certNO = certNO;
        return this;
    }
    public String getCertNO() {
        return this.certNO;
    }

    public ECertQueryResponseBody setEmployJobId(String employJobId) {
        this.employJobId = employJobId;
        return this;
    }
    public String getEmployJobId() {
        return this.employJobId;
    }

    public ECertQueryResponseBody setEmployJobIdLabel(String employJobIdLabel) {
        this.employJobIdLabel = employJobIdLabel;
        return this;
    }
    public String getEmployJobIdLabel() {
        return this.employJobIdLabel;
    }

    public ECertQueryResponseBody setEmployPositionId(String employPositionId) {
        this.employPositionId = employPositionId;
        return this;
    }
    public String getEmployPositionId() {
        return this.employPositionId;
    }

    public ECertQueryResponseBody setEmployPositionIdLabel(String employPositionIdLabel) {
        this.employPositionIdLabel = employPositionIdLabel;
        return this;
    }
    public String getEmployPositionIdLabel() {
        return this.employPositionIdLabel;
    }

    public ECertQueryResponseBody setEmployPositionRankId(String employPositionRankId) {
        this.employPositionRankId = employPositionRankId;
        return this;
    }
    public String getEmployPositionRankId() {
        return this.employPositionRankId;
    }

    public ECertQueryResponseBody setEmployPositionRankIdLabel(String employPositionRankIdLabel) {
        this.employPositionRankIdLabel = employPositionRankIdLabel;
        return this;
    }
    public String getEmployPositionRankIdLabel() {
        return this.employPositionRankIdLabel;
    }

    public ECertQueryResponseBody setHiredDate(String hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public String getHiredDate() {
        return this.hiredDate;
    }

    public ECertQueryResponseBody setLastWorkDay(String lastWorkDay) {
        this.lastWorkDay = lastWorkDay;
        return this;
    }
    public String getLastWorkDay() {
        return this.lastWorkDay;
    }

    public ECertQueryResponseBody setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public ECertQueryResponseBody setMainDeptName(String mainDeptName) {
        this.mainDeptName = mainDeptName;
        return this;
    }
    public String getMainDeptName() {
        return this.mainDeptName;
    }

    public ECertQueryResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ECertQueryResponseBody setRealName(String realName) {
        this.realName = realName;
        return this;
    }
    public String getRealName() {
        return this.realName;
    }

    public ECertQueryResponseBody setTerminationReasonPassive(java.util.List<String> terminationReasonPassive) {
        this.terminationReasonPassive = terminationReasonPassive;
        return this;
    }
    public java.util.List<String> getTerminationReasonPassive() {
        return this.terminationReasonPassive;
    }

    public ECertQueryResponseBody setTerminationReasonVoluntary(java.util.List<String> terminationReasonVoluntary) {
        this.terminationReasonVoluntary = terminationReasonVoluntary;
        return this;
    }
    public java.util.List<String> getTerminationReasonVoluntary() {
        return this.terminationReasonVoluntary;
    }

}
