// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeletePersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentDeletePersonalityTagResponseBodyResult result;

    public static TalentDeletePersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentDeletePersonalityTagResponseBody self = new TalentDeletePersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentDeletePersonalityTagResponseBody setResult(TalentDeletePersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentDeletePersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentDeletePersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentDeletePersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentDeletePersonalityTagResponseBodyResult self = new TalentDeletePersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentDeletePersonalityTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
