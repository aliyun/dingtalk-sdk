// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormComponentDefinitionListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFormComponentDefinitionListResponseBodyResult> result;

    public static GetFormComponentDefinitionListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormComponentDefinitionListResponseBody self = new GetFormComponentDefinitionListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormComponentDefinitionListResponseBody setResult(java.util.List<GetFormComponentDefinitionListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFormComponentDefinitionListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetFormComponentDefinitionListResponseBodyResult extends TeaModel {
        // label
        @NameInMap("label")
        public String label;

        // componentName
        @NameInMap("componentName")
        public String componentName;

        // key
        @NameInMap("fieldId")
        public String fieldId;

        // parentId
        @NameInMap("parentId")
        public String parentId;

        public static GetFormComponentDefinitionListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFormComponentDefinitionListResponseBodyResult self = new GetFormComponentDefinitionListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFormComponentDefinitionListResponseBodyResult setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetFormComponentDefinitionListResponseBodyResult setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public GetFormComponentDefinitionListResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public GetFormComponentDefinitionListResponseBodyResult setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

    }

}
