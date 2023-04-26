// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SearchOranizationCustomfieldResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

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

    public SearchOranizationCustomfieldResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield extends TeaModel {
        @NameInMap("advancedCustomfieldId")
        public String advancedCustomfieldId;

        @NameInMap("name")
        public String name;

        @NameInMap("objectType")
        public String objectType;

        public static SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield build(java.util.Map<String, ?> map) throws Exception {
            SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield self = new SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield();
            return TeaModel.build(map, self);
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield setAdvancedCustomfieldId(String advancedCustomfieldId) {
            this.advancedCustomfieldId = advancedCustomfieldId;
            return this;
        }
        public String getAdvancedCustomfieldId() {
            return this.advancedCustomfieldId;
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

    }

    public static class SearchOranizationCustomfieldResponseBodyResultChoices extends TeaModel {
        @NameInMap("choiceId")
        public String choiceId;

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
        @NameInMap("advancedCustomfield")
        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield;

        @NameInMap("choices")
        public java.util.List<SearchOranizationCustomfieldResponseBodyResultChoices> choices;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfieldsId")
        public String customfieldsId;

        @NameInMap("name")
        public String name;

        @NameInMap("payload")
        public java.util.Map<String, ?> payload;

        @NameInMap("type")
        public String type;

        public static SearchOranizationCustomfieldResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchOranizationCustomfieldResponseBodyResult self = new SearchOranizationCustomfieldResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchOranizationCustomfieldResponseBodyResult setAdvancedCustomfield(SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield) {
            this.advancedCustomfield = advancedCustomfield;
            return this;
        }
        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield getAdvancedCustomfield() {
            return this.advancedCustomfield;
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

        public SearchOranizationCustomfieldResponseBodyResult setCustomfieldsId(String customfieldsId) {
            this.customfieldsId = customfieldsId;
            return this;
        }
        public String getCustomfieldsId() {
            return this.customfieldsId;
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
