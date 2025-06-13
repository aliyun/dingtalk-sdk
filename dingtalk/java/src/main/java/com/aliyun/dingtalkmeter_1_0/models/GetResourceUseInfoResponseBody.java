// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmeter_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUseInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetResourceUseInfoResponseBodyResult> result;

    public static GetResourceUseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUseInfoResponseBody self = new GetResourceUseInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResourceUseInfoResponseBody setResult(java.util.List<GetResourceUseInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetResourceUseInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetResourceUseInfoResponseBodyResult extends TeaModel {
        @NameInMap("quotaNum")
        public Long quotaNum;

        @NameInMap("usedNum")
        public Long usedNum;

        public static GetResourceUseInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetResourceUseInfoResponseBodyResult self = new GetResourceUseInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetResourceUseInfoResponseBodyResult setQuotaNum(Long quotaNum) {
            this.quotaNum = quotaNum;
            return this;
        }
        public Long getQuotaNum() {
            return this.quotaNum;
        }

        public GetResourceUseInfoResponseBodyResult setUsedNum(Long usedNum) {
            this.usedNum = usedNum;
            return this;
        }
        public Long getUsedNum() {
            return this.usedNum;
        }

    }

}
