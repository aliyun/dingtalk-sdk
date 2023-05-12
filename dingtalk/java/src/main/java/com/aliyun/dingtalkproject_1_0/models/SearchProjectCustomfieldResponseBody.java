// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponseBody extends TeaModel {
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
        @NameInMap("advancedCustomFieldId")
        public String advancedCustomFieldId;

        @NameInMap("name")
        public String name;

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
        @NameInMap("choiceId")
        public String choiceId;

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

        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        @NameInMap("choices")
        public java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> choices;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("name")
        public String name;

        @NameInMap("originalId")
        public String originalId;

        @NameInMap("payload")
        public java.util.Map<String, ?> payload;

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
