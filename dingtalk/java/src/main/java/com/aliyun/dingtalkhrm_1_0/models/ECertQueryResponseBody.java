// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ECertQueryResponseBody extends TeaModel {
    /**
     * <p>身份证号码</p>
     */
    @NameInMap("certNO")
    public String certNO;

    /**
     * <p>职务ID</p>
     */
    @NameInMap("employJobId")
    public String employJobId;

    /**
     * <p>职务名称</p>
     */
    @NameInMap("employJobIdLabel")
    public String employJobIdLabel;

    /**
     * <p>职位ID</p>
     */
    @NameInMap("employPositionId")
    public String employPositionId;

    /**
     * <p>职位名称</p>
     */
    @NameInMap("employPositionIdLabel")
    public String employPositionIdLabel;

    /**
     * <p>职级ID</p>
     */
    @NameInMap("employPositionRankId")
    public String employPositionRankId;

    /**
     * <p>职级名称</p>
     */
    @NameInMap("employPositionRankIdLabel")
    public String employPositionRankIdLabel;

    /**
     * <p>入职日期</p>
     */
    @NameInMap("hiredDate")
    public String hiredDate;

    /**
     * <p>离职日期</p>
     */
    @NameInMap("lastWorkDay")
    public String lastWorkDay;

    /**
     * <p>主部门ID</p>
     */
    @NameInMap("mainDeptId")
    public Long mainDeptId;

    /**
     * <p>主部门</p>
     */
    @NameInMap("mainDeptName")
    public String mainDeptName;

    /**
     * <p>姓名</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>身份证姓名</p>
     */
    @NameInMap("realName")
    public String realName;

    /**
     * <p>被动离职原因</p>
     */
    @NameInMap("terminationReasonPassive")
    public java.util.List<String> terminationReasonPassive;

    /**
     * <p>主动离职原因</p>
     */
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
