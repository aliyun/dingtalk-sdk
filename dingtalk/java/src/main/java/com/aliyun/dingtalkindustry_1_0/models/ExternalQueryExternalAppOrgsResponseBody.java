// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalAppOrgsResponseBody extends TeaModel {
    // 返回项目组
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
        // 外部合作组织ID
        @NameInMap("corpId")
        public String corpId;

        // 外部合作组织名称
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
