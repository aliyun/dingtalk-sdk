// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponent extends TeaModel {
    // 控件类型
    @NameInMap("componentType")
    public String componentType;

    // 控件属性
    @NameInMap("props")
    public FormComponentProps props;

    // 子控件集合
    @NameInMap("children")
    public java.util.List<FormComponent> children;

    public static FormComponent build(java.util.Map<String, ?> map) throws Exception {
        FormComponent self = new FormComponent();
        return TeaModel.build(map, self);
    }

    public FormComponent setComponentType(String componentType) {
        this.componentType = componentType;
        return this;
    }
    public String getComponentType() {
        return this.componentType;
    }

    public FormComponent setProps(FormComponentProps props) {
        this.props = props;
        return this;
    }
    public FormComponentProps getProps() {
        return this.props;
    }

    public FormComponent setChildren(java.util.List<FormComponent> children) {
        this.children = children;
        return this;
    }
    public java.util.List<FormComponent> getChildren() {
        return this.children;
    }

}
