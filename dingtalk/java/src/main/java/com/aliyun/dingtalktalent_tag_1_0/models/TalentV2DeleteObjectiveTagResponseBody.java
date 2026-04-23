// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2DeleteObjectiveTagResponseBodyResult result;

    public static TalentV2DeleteObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteObjectiveTagResponseBody self = new TalentV2DeleteObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteObjectiveTagResponseBody setResult(TalentV2DeleteObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2DeleteObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2DeleteObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentV2DeleteObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2DeleteObjectiveTagResponseBodyResult self = new TalentV2DeleteObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2DeleteObjectiveTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
