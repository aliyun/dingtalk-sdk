// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeleteCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentDeleteCustomTagResponseBodyResult result;

    public static TalentDeleteCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentDeleteCustomTagResponseBody self = new TalentDeleteCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentDeleteCustomTagResponseBody setResult(TalentDeleteCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentDeleteCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentDeleteCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentDeleteCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentDeleteCustomTagResponseBodyResult self = new TalentDeleteCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentDeleteCustomTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
