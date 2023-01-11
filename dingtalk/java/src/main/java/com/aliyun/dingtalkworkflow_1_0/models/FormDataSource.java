// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormDataSource extends TeaModel {
    /**
     * <p>关联表单信息</p>
     */
    @NameInMap("target")
    public FormDataSourceTarget target;

    /**
     * <p>关联类型，form关联表单</p>
     */
    @NameInMap("type")
    public String type;

    public static FormDataSource build(java.util.Map<String, ?> map) throws Exception {
        FormDataSource self = new FormDataSource();
        return TeaModel.build(map, self);
    }

    public FormDataSource setTarget(FormDataSourceTarget target) {
        this.target = target;
        return this;
    }
    public FormDataSourceTarget getTarget() {
        return this.target;
    }

    public FormDataSource setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public static class FormDataSourceTarget extends TeaModel {
        /**
         * <p>表单类型，0流程表单</p>
         */
        @NameInMap("appType")
        public Integer appType;

        /**
         * <p>应用appUuid</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>关联表单业务标识</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>关联表单的formCode</p>
         */
        @NameInMap("formCode")
        public String formCode;

        public static FormDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            FormDataSourceTarget self = new FormDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public FormDataSourceTarget setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public FormDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
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
