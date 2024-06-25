// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("deptId")
    public Integer deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponentValues")
    public java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager432</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ProcessForecastRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessForecastRequest self = new ProcessForecastRequest();
        return TeaModel.build(map, self);
    }

    public ProcessForecastRequest setDeptId(Integer deptId) {
        this.deptId = deptId;
        return this;
    }
    public Integer getDeptId() {
        return this.deptId;
    }

    public ProcessForecastRequest setFormComponentValues(java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues) {
        this.formComponentValues = formComponentValues;
        return this;
    }
    public java.util.List<ProcessForecastRequestFormComponentValues> getFormComponentValues() {
        return this.formComponentValues;
    }

    public ProcessForecastRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public ProcessForecastRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class ProcessForecastRequestFormComponentValuesDetailsDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
         */
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValuesDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetailsDetails self = new ProcessForecastRequestFormComponentValuesDetailsDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ProcessForecastRequestFormComponentValuesDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
         */
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValuesDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetails self = new ProcessForecastRequestFormComponentValuesDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValuesDetails setDetails(java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> getDetails() {
            return this.details;
        }

        public ProcessForecastRequestFormComponentValuesDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValuesDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ProcessForecastRequestFormComponentValues extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetails> details;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
         */
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValues self = new ProcessForecastRequestFormComponentValues();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValues setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public ProcessForecastRequestFormComponentValues setDetails(java.util.List<ProcessForecastRequestFormComponentValuesDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<ProcessForecastRequestFormComponentValuesDetails> getDetails() {
            return this.details;
        }

        public ProcessForecastRequestFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
