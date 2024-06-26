// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalAppOrgsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ExternalQueryExternalAppOrgsResponseBodyResult> result;

    public static ExternalQueryExternalAppOrgsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalAppOrgsResponseBody self = new ExternalQueryExternalAppOrgsResponseBody();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalAppOrgsResponseBody setResult(java.util.List<ExternalQueryExternalAppOrgsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ExternalQueryExternalAppOrgsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ExternalQueryExternalAppOrgsResponseBodyResult extends TeaModel {
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

        public static ExternalQueryExternalAppOrgsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ExternalQueryExternalAppOrgsResponseBodyResult self = new ExternalQueryExternalAppOrgsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ExternalQueryExternalAppOrgsResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ExternalQueryExternalAppOrgsResponseBodyResult setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

    }

}
