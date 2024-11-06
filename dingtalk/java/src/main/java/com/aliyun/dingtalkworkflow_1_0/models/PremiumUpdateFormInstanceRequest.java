// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateFormInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponentValueList")
    public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("formInstanceIds")
    public java.util.List<String> formInstanceIds;

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

    public static PremiumUpdateFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateFormInstanceRequest self = new PremiumUpdateFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateFormInstanceRequest setFormComponentValueList(java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public PremiumUpdateFormInstanceRequest setFormInstanceIds(java.util.List<String> formInstanceIds) {
        this.formInstanceIds = formInstanceIds;
        return this;
    }
    public java.util.List<String> getFormInstanceIds() {
        return this.formInstanceIds;
    }

    public PremiumUpdateFormInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public PremiumUpdateFormInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public static class PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails extends TeaModel {
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

        public static PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails self = new PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails();
            return TeaModel.build(map, self);
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumUpdateFormInstanceRequestFormComponentValueListDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails> details;

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

        public static PremiumUpdateFormInstanceRequestFormComponentValueListDetails build(java.util.Map<String, ?> map) throws Exception {
            PremiumUpdateFormInstanceRequestFormComponentValueListDetails self = new PremiumUpdateFormInstanceRequestFormComponentValueListDetails();
            return TeaModel.build(map, self);
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setDetails(java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails> getDetails() {
            return this.details;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueListDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumUpdateFormInstanceRequestFormComponentValueList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetails> details;

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

        public static PremiumUpdateFormInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            PremiumUpdateFormInstanceRequestFormComponentValueList self = new PremiumUpdateFormInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setDetails(java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<PremiumUpdateFormInstanceRequestFormComponentValueListDetails> getDetails() {
            return this.details;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumUpdateFormInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
