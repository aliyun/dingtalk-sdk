// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormDataSource extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("target")
    public FormDataSourceTarget target;

    /**
     * <strong>example:</strong>
     * <p>form</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("appType")
        public Integer appType;

        /**
         * <strong>example:</strong>
         * <p>SWAPP-abcd</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
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
