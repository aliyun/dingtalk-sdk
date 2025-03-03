// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PublishSchoolReportResponseBody extends TeaModel {
    @NameInMap("result")
    public PublishSchoolReportResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PublishSchoolReportResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PublishSchoolReportResponseBody self = new PublishSchoolReportResponseBody();
        return TeaModel.build(map, self);
    }

    public PublishSchoolReportResponseBody setResult(PublishSchoolReportResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PublishSchoolReportResponseBodyResult getResult() {
        return this.result;
    }

    public PublishSchoolReportResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PublishSchoolReportResponseBodyResult extends TeaModel {
        @NameInMap("schoolReportId")
        public Long schoolReportId;

        public static PublishSchoolReportResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PublishSchoolReportResponseBodyResult self = new PublishSchoolReportResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PublishSchoolReportResponseBodyResult setSchoolReportId(Long schoolReportId) {
            this.schoolReportId = schoolReportId;
            return this;
        }
        public Long getSchoolReportId() {
            return this.schoolReportId;
        }

    }

}
