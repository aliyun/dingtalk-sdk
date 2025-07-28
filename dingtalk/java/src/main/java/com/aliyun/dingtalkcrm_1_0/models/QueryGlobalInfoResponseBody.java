// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryGlobalInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryGlobalInfoResponseBodyResult result;

    public static QueryGlobalInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGlobalInfoResponseBody self = new QueryGlobalInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGlobalInfoResponseBody setResult(QueryGlobalInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryGlobalInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryGlobalInfoResponseBodyResult extends TeaModel {
        @NameInMap("oemEnable")
        public Boolean oemEnable;

        @NameInMap("t2t3Coexist")
        public Boolean t2t3Coexist;

        public static QueryGlobalInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryGlobalInfoResponseBodyResult self = new QueryGlobalInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryGlobalInfoResponseBodyResult setOemEnable(Boolean oemEnable) {
            this.oemEnable = oemEnable;
            return this;
        }
        public Boolean getOemEnable() {
            return this.oemEnable;
        }

        public QueryGlobalInfoResponseBodyResult setT2t3Coexist(Boolean t2t3Coexist) {
            this.t2t3Coexist = t2t3Coexist;
            return this;
        }
        public Boolean getT2t3Coexist() {
            return this.t2t3Coexist;
        }

    }

}
