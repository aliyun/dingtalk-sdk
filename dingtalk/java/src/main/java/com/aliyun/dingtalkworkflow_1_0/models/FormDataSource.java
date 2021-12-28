// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormDataSource extends TeaModel {
    // 关联类型，form关联表单
    @NameInMap("type")
    public String type;

    // 关联表单信息
    @NameInMap("target")
    public FormDataSourceTarget target;

    public static FormDataSource build(java.util.Map<String, ?> map) throws Exception {
        FormDataSource self = new FormDataSource();
        return TeaModel.build(map, self);
    }

    public FormDataSource setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public FormDataSource setTarget(FormDataSourceTarget target) {
        this.target = target;
        return this;
    }
    public FormDataSourceTarget getTarget() {
        return this.target;
    }

    public static class FormDataSourceTarget extends TeaModel {
        // 应用appUuid
        @NameInMap("appUuid")
        public String appUuid;

        // 表单类型，0流程表单
        @NameInMap("appType")
        public Integer appType;

        // 关联表单业务标识
        @NameInMap("bizType")
        public String bizType;

        // 关联表单的formCode
        @NameInMap("formCode")
        public String formCode;

        public static FormDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            FormDataSourceTarget self = new FormDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public FormDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public FormDataSourceTarget setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public FormDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

}
