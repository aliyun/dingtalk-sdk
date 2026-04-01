// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentLikeTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentLikeTagResponseBodyResult result;

    public static TalentLikeTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentLikeTagResponseBody self = new TalentLikeTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentLikeTagResponseBody setResult(TalentLikeTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentLikeTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentLikeTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentLikeTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentLikeTagResponseBodyResult self = new TalentLikeTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentLikeTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
