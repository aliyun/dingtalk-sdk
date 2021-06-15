// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeCrmPersonalCustomerObjectMetaResponseBody extends TeaModel {
    // 对象名称
    @NameInMap("name")
    public String name;

    // 是否自定义对象
    @NameInMap("customized")
    public Boolean customized;

    // 字段列表
    @NameInMap("fields")
    public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFields> fields;

    public static DescribeCrmPersonalCustomerObjectMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DescribeCrmPersonalCustomerObjectMetaResponseBody self = new DescribeCrmPersonalCustomerObjectMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public DescribeCrmPersonalCustomerObjectMetaResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DescribeCrmPersonalCustomerObjectMetaResponseBody setCustomized(Boolean customized) {
        this.customized = customized;
        return this;
    }
    public Boolean getCustomized() {
        return this.customized;
    }

    public DescribeCrmPersonalCustomerObjectMetaResponseBody setFields(java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFields> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFields> getFields() {
        return this.fields;
    }

    public static class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions self = new DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions();
            return TeaModel.build(map, self);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions self = new DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions();
            return TeaModel.build(map, self);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("type")
        public String type;

        @NameInMap("nillable")
        public Boolean nillable;

        @NameInMap("unit")
        public String unit;

        @NameInMap("format")
        public String format;

        @NameInMap("selectOptions")
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions> selectOptions;

        @NameInMap("name")
        public String name;

        public static DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields self = new DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields();
            return TeaModel.build(map, self);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setNillable(Boolean nillable) {
            this.nillable = nillable;
            return this;
        }
        public Boolean getNillable() {
            return this.nillable;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setSelectOptions(java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions> selectOptions) {
            this.selectOptions = selectOptions;
            return this;
        }
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions> getSelectOptions() {
            return this.selectOptions;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("aggregator")
        public String aggregator;

        public static DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields self = new DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields();
            return TeaModel.build(map, self);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields setAggregator(String aggregator) {
            this.aggregator = aggregator;
            return this;
        }
        public String getAggregator() {
            return this.aggregator;
        }

    }

    public static class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("customized")
        public Boolean customized;

        @NameInMap("label")
        public String label;

        @NameInMap("type")
        public String type;

        @NameInMap("nillable")
        public Boolean nillable;

        @NameInMap("format")
        public String format;

        @NameInMap("unit")
        public String unit;

        @NameInMap("selectOptions")
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions> selectOptions;

        @NameInMap("quote")
        public Boolean quote;

        @NameInMap("referenceTo")
        public String referenceTo;

        @NameInMap("referenceFields")
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields> referenceFields;

        @NameInMap("rollUpSummaryFields")
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields> rollUpSummaryFields;

        public static DescribeCrmPersonalCustomerObjectMetaResponseBodyFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeCrmPersonalCustomerObjectMetaResponseBodyFields self = new DescribeCrmPersonalCustomerObjectMetaResponseBodyFields();
            return TeaModel.build(map, self);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setCustomized(Boolean customized) {
            this.customized = customized;
            return this;
        }
        public Boolean getCustomized() {
            return this.customized;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setNillable(Boolean nillable) {
            this.nillable = nillable;
            return this;
        }
        public Boolean getNillable() {
            return this.nillable;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setSelectOptions(java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions> selectOptions) {
            this.selectOptions = selectOptions;
            return this;
        }
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions> getSelectOptions() {
            return this.selectOptions;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setQuote(Boolean quote) {
            this.quote = quote;
            return this;
        }
        public Boolean getQuote() {
            return this.quote;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setReferenceTo(String referenceTo) {
            this.referenceTo = referenceTo;
            return this;
        }
        public String getReferenceTo() {
            return this.referenceTo;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setReferenceFields(java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields> referenceFields) {
            this.referenceFields = referenceFields;
            return this;
        }
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields> getReferenceFields() {
            return this.referenceFields;
        }

        public DescribeCrmPersonalCustomerObjectMetaResponseBodyFields setRollUpSummaryFields(java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields> rollUpSummaryFields) {
            this.rollUpSummaryFields = rollUpSummaryFields;
            return this;
        }
        public java.util.List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields> getRollUpSummaryFields() {
            return this.rollUpSummaryFields;
        }

    }

}
