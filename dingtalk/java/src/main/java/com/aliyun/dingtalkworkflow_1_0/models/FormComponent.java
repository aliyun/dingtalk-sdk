// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponent extends TeaModel {
    @NameInMap("children")
    public java.util.List<FormComponent> children;

    @NameInMap("componentType")
    public String componentType;

    @NameInMap("props")
    public FormComponentProps props;

    public static FormComponent build(java.util.Map<String, ?> map) throws Exception {
        FormComponent self = new FormComponent();
        return TeaModel.build(map, self);
    }

    public FormComponent setChildren(java.util.List<FormComponent> children) {
        this.children = children;
        return this;
    }
    public java.util.List<FormComponent> getChildren() {
        return this.children;
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

}
