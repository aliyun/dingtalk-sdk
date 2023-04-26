// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFieldDefByUuidResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetFieldDefByUuidResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFieldDefByUuidResponseBody self = new GetFieldDefByUuidResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFieldDefByUuidResponseBody setResult(java.util.List<GetFieldDefByUuidResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFieldDefByUuidResponseBodyResult> getResult() {
        return this.result;
    }

    public GetFieldDefByUuidResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFieldDefByUuidResponseBodyResult extends TeaModel {
        @NameInMap("behavior")
        public String behavior;

        @NameInMap("children")
        public String children;

        @NameInMap("componentName")
        public String componentName;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public Object label;

        @NameInMap("props")
        public Object props;

        public static GetFieldDefByUuidResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFieldDefByUuidResponseBodyResult self = new GetFieldDefByUuidResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFieldDefByUuidResponseBodyResult setBehavior(String behavior) {
            this.behavior = behavior;
            return this;
        }
        public String getBehavior() {
            return this.behavior;
        }

        public GetFieldDefByUuidResponseBodyResult setChildren(String children) {
            this.children = children;
            return this;
        }
        public String getChildren() {
            return this.children;
        }

        public GetFieldDefByUuidResponseBodyResult setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public GetFieldDefByUuidResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public GetFieldDefByUuidResponseBodyResult setLabel(Object label) {
            this.label = label;
            return this;
        }
        public Object getLabel() {
            return this.label;
        }

        public GetFieldDefByUuidResponseBodyResult setProps(Object props) {
            this.props = props;
            return this;
        }
        public Object getProps() {
            return this.props;
        }

    }

}
