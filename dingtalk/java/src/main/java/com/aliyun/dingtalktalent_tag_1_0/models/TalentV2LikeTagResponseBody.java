// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2LikeTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2LikeTagResponseBodyResult result;

    public static TalentV2LikeTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2LikeTagResponseBody self = new TalentV2LikeTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2LikeTagResponseBody setResult(TalentV2LikeTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2LikeTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2LikeTagResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static TalentV2LikeTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2LikeTagResponseBodyResult self = new TalentV2LikeTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2LikeTagResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
