// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2DeleteCustomTagResponseBodyResult result;

    public static TalentV2DeleteCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteCustomTagResponseBody self = new TalentV2DeleteCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteCustomTagResponseBody setResult(TalentV2DeleteCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2DeleteCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2DeleteCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentV2DeleteCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2DeleteCustomTagResponseBodyResult self = new TalentV2DeleteCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2DeleteCustomTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
