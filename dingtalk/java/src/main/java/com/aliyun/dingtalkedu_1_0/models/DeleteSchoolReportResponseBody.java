// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteSchoolReportResponseBody extends TeaModel {
    @NameInMap("result")
    public DeleteSchoolReportResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DeleteSchoolReportResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteSchoolReportResponseBody self = new DeleteSchoolReportResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteSchoolReportResponseBody setResult(DeleteSchoolReportResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeleteSchoolReportResponseBodyResult getResult() {
        return this.result;
    }

    public DeleteSchoolReportResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeleteSchoolReportResponseBodyResult extends TeaModel {
        @NameInMap("schoolReportId")
        public Long schoolReportId;

        public static DeleteSchoolReportResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteSchoolReportResponseBodyResult self = new DeleteSchoolReportResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeleteSchoolReportResponseBodyResult setSchoolReportId(Long schoolReportId) {
            this.schoolReportId = schoolReportId;
            return this;
        }
        public Long getSchoolReportId() {
            return this.schoolReportId;
        }

    }

}
