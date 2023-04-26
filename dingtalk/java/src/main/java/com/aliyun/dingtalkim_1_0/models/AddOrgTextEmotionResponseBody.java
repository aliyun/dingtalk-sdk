// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddOrgTextEmotionResponseBody extends TeaModel {
    @NameInMap("result")
    public AddOrgTextEmotionResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddOrgTextEmotionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOrgTextEmotionResponseBody self = new AddOrgTextEmotionResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOrgTextEmotionResponseBody setResult(AddOrgTextEmotionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOrgTextEmotionResponseBodyResult getResult() {
        return this.result;
    }

    public AddOrgTextEmotionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddOrgTextEmotionResponseBodyResult extends TeaModel {
        @NameInMap("emotionId")
        public String emotionId;

        public static AddOrgTextEmotionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOrgTextEmotionResponseBodyResult self = new AddOrgTextEmotionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddOrgTextEmotionResponseBodyResult setEmotionId(String emotionId) {
            this.emotionId = emotionId;
            return this;
        }
        public String getEmotionId() {
            return this.emotionId;
        }

    }

}
