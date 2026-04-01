// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeleteObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentDeleteObjectiveTagResponseBodyResult result;

    public static TalentDeleteObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentDeleteObjectiveTagResponseBody self = new TalentDeleteObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentDeleteObjectiveTagResponseBody setResult(TalentDeleteObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentDeleteObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentDeleteObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentDeleteObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentDeleteObjectiveTagResponseBodyResult self = new TalentDeleteObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentDeleteObjectiveTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
