// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeletePersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2DeletePersonalityTagResponseBodyResult result;

    public static TalentV2DeletePersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeletePersonalityTagResponseBody self = new TalentV2DeletePersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2DeletePersonalityTagResponseBody setResult(TalentV2DeletePersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2DeletePersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2DeletePersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentV2DeletePersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2DeletePersonalityTagResponseBodyResult self = new TalentV2DeletePersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2DeletePersonalityTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
