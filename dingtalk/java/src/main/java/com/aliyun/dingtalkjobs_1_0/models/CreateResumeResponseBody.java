// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class CreateResumeResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateResumeResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateResumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateResumeResponseBody self = new CreateResumeResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateResumeResponseBody setResult(CreateResumeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateResumeResponseBodyResult getResult() {
        return this.result;
    }

    public CreateResumeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateResumeResponseBodyResult extends TeaModel {
        @NameInMap("resumeId")
        public String resumeId;

        public static CreateResumeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeResponseBodyResult self = new CreateResumeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateResumeResponseBodyResult setResumeId(String resumeId) {
            this.resumeId = resumeId;
            return this;
        }
        public String getResumeId() {
            return this.resumeId;
        }

    }

}
