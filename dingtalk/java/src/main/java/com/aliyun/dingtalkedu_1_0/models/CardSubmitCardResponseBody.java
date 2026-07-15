// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardSubmitCardResponseBody extends TeaModel {
    @NameInMap("result")
    public CardSubmitCardResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CardSubmitCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardSubmitCardResponseBody self = new CardSubmitCardResponseBody();
        return TeaModel.build(map, self);
    }

    public CardSubmitCardResponseBody setResult(CardSubmitCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CardSubmitCardResponseBodyResult getResult() {
        return this.result;
    }

    public CardSubmitCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CardSubmitCardResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        public static CardSubmitCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CardSubmitCardResponseBodyResult self = new CardSubmitCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CardSubmitCardResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

}
