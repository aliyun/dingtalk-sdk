// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalOrgsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ExternalQueryExternalOrgsResponseBodyResult> result;

    public static ExternalQueryExternalOrgsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalOrgsResponseBody self = new ExternalQueryExternalOrgsResponseBody();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalOrgsResponseBody setResult(java.util.List<ExternalQueryExternalOrgsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ExternalQueryExternalOrgsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ExternalQueryExternalOrgsResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding121212</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>组织名</p>
         */
        @NameInMap("corpName")
        public String corpName;

        public static ExternalQueryExternalOrgsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ExternalQueryExternalOrgsResponseBodyResult self = new ExternalQueryExternalOrgsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ExternalQueryExternalOrgsResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ExternalQueryExternalOrgsResponseBodyResult setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

    }

}
