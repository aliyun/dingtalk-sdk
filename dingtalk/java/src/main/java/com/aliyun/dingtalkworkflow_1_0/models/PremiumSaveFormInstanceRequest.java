// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveFormInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponentValueList")
    public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueList> formComponentValueList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager432</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</p>
     */
    @NameInMap("processCode")
    public String processCode;

    public static PremiumSaveFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveFormInstanceRequest self = new PremiumSaveFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public PremiumSaveFormInstanceRequest setFormComponentValueList(java.util.List<PremiumSaveFormInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public PremiumSaveFormInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public PremiumSaveFormInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public static class PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails extends TeaModel {
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

        public static PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails self = new PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails();
            return TeaModel.build(map, self);
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumSaveFormInstanceRequestFormComponentValueListDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails> details;

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

        public static PremiumSaveFormInstanceRequestFormComponentValueListDetails build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveFormInstanceRequestFormComponentValueListDetails self = new PremiumSaveFormInstanceRequestFormComponentValueListDetails();
            return TeaModel.build(map, self);
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setDetails(java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails> getDetails() {
            return this.details;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueListDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumSaveFormInstanceRequestFormComponentValueList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetails> details;

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

        public static PremiumSaveFormInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveFormInstanceRequestFormComponentValueList self = new PremiumSaveFormInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setDetails(java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<PremiumSaveFormInstanceRequestFormComponentValueListDetails> getDetails() {
            return this.details;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveFormInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
