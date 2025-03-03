// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteSchoolReportRequest extends TeaModel {
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
    @NameInMap("teacherId")
    public String teacherId;

    public static DeleteSchoolReportRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteSchoolReportRequest self = new DeleteSchoolReportRequest();
        return TeaModel.build(map, self);
    }

    public DeleteSchoolReportRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public DeleteSchoolReportRequest setSchoolReportId(Long schoolReportId) {
        this.schoolReportId = schoolReportId;
        return this;
    }
    public Long getSchoolReportId() {
        return this.schoolReportId;
    }

    public DeleteSchoolReportRequest setTeacherId(String teacherId) {
        this.teacherId = teacherId;
        return this;
    }
    public String getTeacherId() {
        return this.teacherId;
    }

}
