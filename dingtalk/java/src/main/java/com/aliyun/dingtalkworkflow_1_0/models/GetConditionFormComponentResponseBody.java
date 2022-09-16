// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetConditionFormComponentResponseBody extends TeaModel {
    // 返回结果。
    @NameInMap("result")
    public java.util.List<GetConditionFormComponentResponseBodyResult> result;

    public static GetConditionFormComponentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConditionFormComponentResponseBody self = new GetConditionFormComponentResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConditionFormComponentResponseBody setResult(java.util.List<GetConditionFormComponentResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetConditionFormComponentResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetConditionFormComponentResponseBodyResult extends TeaModel {
        // 表单ID。
        @NameInMap("id")
        public String id;

        // 表单名称。
        @NameInMap("label")
        public String label;

        public static GetConditionFormComponentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetConditionFormComponentResponseBodyResult self = new GetConditionFormComponentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetConditionFormComponentResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetConditionFormComponentResponseBodyResult setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

    }

}
