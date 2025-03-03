// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SchoolReportDetailReadedResponseBody extends TeaModel {
    @NameInMap("result")
    public SchoolReportDetailReadedResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SchoolReportDetailReadedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SchoolReportDetailReadedResponseBody self = new SchoolReportDetailReadedResponseBody();
        return TeaModel.build(map, self);
    }

    public SchoolReportDetailReadedResponseBody setResult(SchoolReportDetailReadedResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SchoolReportDetailReadedResponseBodyResult getResult() {
        return this.result;
    }

    public SchoolReportDetailReadedResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SchoolReportDetailReadedResponseBodyResult extends TeaModel {
        @NameInMap("schoolReportDetailId")
        public java.util.List<String> schoolReportDetailId;

        public static SchoolReportDetailReadedResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SchoolReportDetailReadedResponseBodyResult self = new SchoolReportDetailReadedResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SchoolReportDetailReadedResponseBodyResult setSchoolReportDetailId(java.util.List<String> schoolReportDetailId) {
            this.schoolReportDetailId = schoolReportDetailId;
            return this;
        }
        public java.util.List<String> getSchoolReportDetailId() {
            return this.schoolReportDetailId;
        }

    }

}
