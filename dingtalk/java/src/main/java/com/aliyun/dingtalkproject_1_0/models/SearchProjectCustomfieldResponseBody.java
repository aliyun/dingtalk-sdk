// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SearchProjectCustomfieldResponseBodyResult> result;

    public static SearchProjectCustomfieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomfieldResponseBody self = new SearchProjectCustomfieldResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomfieldResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectCustomfieldResponseBody setResult(java.util.List<SearchProjectCustomfieldResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchProjectCustomfieldResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchProjectCustomfieldResponseBodyResultAdvancedCustomField extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>thoughts.document</p>
         */
        @NameInMap("objectType")
        public String objectType;

        public static SearchProjectCustomfieldResponseBodyResultAdvancedCustomField build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomfieldResponseBodyResultAdvancedCustomField self = new SearchProjectCustomfieldResponseBodyResultAdvancedCustomField();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField setAdvancedCustomFieldId(String advancedCustomFieldId) {
            this.advancedCustomFieldId = advancedCustomFieldId;
            return this;
        }
        public String getAdvancedCustomFieldId() {
            return this.advancedCustomFieldId;
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

    }

    public static class SearchProjectCustomfieldResponseBodyResultChoices extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>63a5301e420637003f5dxxxx</p>
         */
        @NameInMap("choiceId")
        public String choiceId;

        /**
         * <strong>example:</strong>
         * <p>选项一</p>
         */
        @NameInMap("value")
        public String value;

        public static SearchProjectCustomfieldResponseBodyResultChoices build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomfieldResponseBodyResultChoices self = new SearchProjectCustomfieldResponseBodyResultChoices();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomfieldResponseBodyResultChoices setChoiceId(String choiceId) {
            this.choiceId = choiceId;
            return this;
        }
        public String getChoiceId() {
            return this.choiceId;
        }

        public SearchProjectCustomfieldResponseBodyResultChoices setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SearchProjectCustomfieldResponseBodyResult extends TeaModel {
        @NameInMap("advancedCustomField")
        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField advancedCustomField;

        /**
         * <strong>example:</strong>
         * <p>63a5301e420637003f5dxxxx</p>
         */
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        @NameInMap("choices")
        public java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> choices;

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
         * <p>63a5301e420637003f5dxxxx</p>
         */
        @NameInMap("customFieldId")
        public String customFieldId;

        /**
         * <strong>example:</strong>
         * <p>名字1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>63a5301e420637003f5dxxxx</p>
         */
        @NameInMap("originalId")
        public String originalId;

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

        public static SearchProjectCustomfieldResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomfieldResponseBodyResult self = new SearchProjectCustomfieldResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomfieldResponseBodyResult setAdvancedCustomField(SearchProjectCustomfieldResponseBodyResultAdvancedCustomField advancedCustomField) {
            this.advancedCustomField = advancedCustomField;
            return this;
        }
        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField getAdvancedCustomField() {
            return this.advancedCustomField;
        }

        public SearchProjectCustomfieldResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public SearchProjectCustomfieldResponseBodyResult setChoices(java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> choices) {
            this.choices = choices;
            return this;
        }
        public java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> getChoices() {
            return this.choices;
        }

        public SearchProjectCustomfieldResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchProjectCustomfieldResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchProjectCustomfieldResponseBodyResult setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public SearchProjectCustomfieldResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectCustomfieldResponseBodyResult setOriginalId(String originalId) {
            this.originalId = originalId;
            return this;
        }
        public String getOriginalId() {
            return this.originalId;
        }

        public SearchProjectCustomfieldResponseBodyResult setPayload(java.util.Map<String, ?> payload) {
            this.payload = payload;
            return this;
        }
        public java.util.Map<String, ?> getPayload() {
            return this.payload;
        }

        public SearchProjectCustomfieldResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
