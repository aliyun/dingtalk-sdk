// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetFormComponentAliasListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFormComponentAliasListResponseBodyResult> result;

    public static GetFormComponentAliasListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormComponentAliasListResponseBody self = new GetFormComponentAliasListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormComponentAliasListResponseBody setResult(java.util.List<GetFormComponentAliasListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFormComponentAliasListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetFormComponentAliasListResponseBodyResult extends TeaModel {
        @NameInMap("alias")
        public String alias;

        @NameInMap("fieldId")
        public String fieldId;

        public static GetFormComponentAliasListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFormComponentAliasListResponseBodyResult self = new GetFormComponentAliasListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFormComponentAliasListResponseBodyResult setAlias(String alias) {
            this.alias = alias;
            return this;
        }
        public String getAlias() {
            return this.alias;
        }

        public GetFormComponentAliasListResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

}
