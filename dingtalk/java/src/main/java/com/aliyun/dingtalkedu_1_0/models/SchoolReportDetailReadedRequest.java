// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SchoolReportDetailReadedRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("schoolReportId")
    public Long schoolReportId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("studentIds")
    public java.util.List<String> studentIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SchoolReportDetailReadedRequest build(java.util.Map<String, ?> map) throws Exception {
        SchoolReportDetailReadedRequest self = new SchoolReportDetailReadedRequest();
        return TeaModel.build(map, self);
    }

    public SchoolReportDetailReadedRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public SchoolReportDetailReadedRequest setSchoolReportId(Long schoolReportId) {
        this.schoolReportId = schoolReportId;
        return this;
    }
    public Long getSchoolReportId() {
        return this.schoolReportId;
    }

    public SchoolReportDetailReadedRequest setStudentIds(java.util.List<String> studentIds) {
        this.studentIds = studentIds;
        return this;
    }
    public java.util.List<String> getStudentIds() {
        return this.studentIds;
    }

    public SchoolReportDetailReadedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
