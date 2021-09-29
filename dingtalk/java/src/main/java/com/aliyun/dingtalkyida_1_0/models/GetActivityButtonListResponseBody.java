// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityButtonListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetActivityButtonListResponseBodyResult> result;

    public static GetActivityButtonListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetActivityButtonListResponseBody self = new GetActivityButtonListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetActivityButtonListResponseBody setResult(java.util.List<GetActivityButtonListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetActivityButtonListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetActivityButtonListResponseBodyResult extends TeaModel {
        // aliasEn
        @NameInMap("aliasInEnglish")
        public String aliasInEnglish;

        // alias
        @NameInMap("aliasInChinese")
        public String aliasInChinese;

        public static GetActivityButtonListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetActivityButtonListResponseBodyResult self = new GetActivityButtonListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetActivityButtonListResponseBodyResult setAliasInEnglish(String aliasInEnglish) {
            this.aliasInEnglish = aliasInEnglish;
            return this;
        }
        public String getAliasInEnglish() {
            return this.aliasInEnglish;
        }

        public GetActivityButtonListResponseBodyResult setAliasInChinese(String aliasInChinese) {
            this.aliasInChinese = aliasInChinese;
            return this;
        }
        public String getAliasInChinese() {
            return this.aliasInChinese;
        }

    }

}
