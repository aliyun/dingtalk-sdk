// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFieldDefByUuidResponseBodyResult> result;

    // 是否成功，true代表成功
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
        // 组件展示状态 
        // 普通NORMAL/禁用DISABLED/只读READONLY/隐藏HIDDEN
        @NameInMap("behavior")
        public String behavior;

        // 子组件信息
        @NameInMap("children")
        public String children;

        // 组件类型，如文本类型：TextField
        @NameInMap("componentName")
        public String componentName;

        // 字段ID，字段唯一标识
        @NameInMap("fieldId")
        public String fieldId;

        // 字段名称。符合国际化标准。
        @NameInMap("label")
        public Object label;

        //  组件属性
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
