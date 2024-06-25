// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SearchOranizationCustomfieldResponseBodyResult> result;

    public static SearchOranizationCustomfieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchOranizationCustomfieldResponseBody self = new SearchOranizationCustomfieldResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchOranizationCustomfieldResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchOranizationCustomfieldResponseBody setResult(java.util.List<SearchOranizationCustomfieldResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchOranizationCustomfieldResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>63a5301e420637003f5dxxxx</p>
         */
        @NameInMap("advancedCustomFieldId")
        public String advancedCustomFieldId;

        /**
         * <strong>example:</strong>
         * <p>所思文档</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("objectType")
        public String objectType;

        public static SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField build(java.util.Map<String, ?> map) throws Exception {
            SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField self = new SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField();
            return TeaModel.build(map, self);
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField setAdvancedCustomFieldId(String advancedCustomFieldId) {
            this.advancedCustomFieldId = advancedCustomFieldId;
            return this;
        }
        public String getAdvancedCustomFieldId() {
            return this.advancedCustomFieldId;
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

    }

    public static class SearchOranizationCustomfieldResponseBodyResultChoices extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("choiceId")
        public String choiceId;

        /**
         * <strong>example:</strong>
         * <p>选项一</p>
         */
        @NameInMap("value")
        public String value;

        public static SearchOranizationCustomfieldResponseBodyResultChoices build(java.util.Map<String, ?> map) throws Exception {
            SearchOranizationCustomfieldResponseBodyResultChoices self = new SearchOranizationCustomfieldResponseBodyResultChoices();
            return TeaModel.build(map, self);
        }

        public SearchOranizationCustomfieldResponseBodyResultChoices setChoiceId(String choiceId) {
            this.choiceId = choiceId;
            return this;
        }
        public String getChoiceId() {
            return this.choiceId;
        }

        public SearchOranizationCustomfieldResponseBodyResultChoices setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SearchOranizationCustomfieldResponseBodyResult extends TeaModel {
        @NameInMap("advancedCustomField")
        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField advancedCustomField;

        @NameInMap("choices")
        public java.util.List<SearchOranizationCustomfieldResponseBodyResultChoices> choices;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>0715153011125xxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("customFieldsId")
        public String customFieldsId;

        /**
         * <strong>example:</strong>
         * <p>自定义字段</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>{&quot;_appId&quot;:&quot;5937b10b83963200444b1ff8&quot;,&quot;kanbanCardAddCustomfieldDisable&quot;:true,&quot;locales&quot;:{&quot;name&quot;:{&quot;en&quot;:&quot;Progress update time&quot;,&quot;zh&quot;:&quot;进展更新时间&quot;}}}</p>
         */
        @NameInMap("payload")
        public java.util.Map<String, ?> payload;

        /**
         * <strong>example:</strong>
         * <p>number</p>
         */
        @NameInMap("type")
        public String type;

        public static SearchOranizationCustomfieldResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchOranizationCustomfieldResponseBodyResult self = new SearchOranizationCustomfieldResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchOranizationCustomfieldResponseBodyResult setAdvancedCustomField(SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField advancedCustomField) {
            this.advancedCustomField = advancedCustomField;
            return this;
        }
        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField getAdvancedCustomField() {
            return this.advancedCustomField;
        }

        public SearchOranizationCustomfieldResponseBodyResult setChoices(java.util.List<SearchOranizationCustomfieldResponseBodyResultChoices> choices) {
            this.choices = choices;
            return this;
        }
        public java.util.List<SearchOranizationCustomfieldResponseBodyResultChoices> getChoices() {
            return this.choices;
        }

        public SearchOranizationCustomfieldResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchOranizationCustomfieldResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchOranizationCustomfieldResponseBodyResult setCustomFieldsId(String customFieldsId) {
            this.customFieldsId = customFieldsId;
            return this;
        }
        public String getCustomFieldsId() {
            return this.customFieldsId;
        }

        public SearchOranizationCustomfieldResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchOranizationCustomfieldResponseBodyResult setPayload(java.util.Map<String, ?> payload) {
            this.payload = payload;
            return this;
        }
        public java.util.Map<String, ?> getPayload() {
            return this.payload;
        }

        public SearchOranizationCustomfieldResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
