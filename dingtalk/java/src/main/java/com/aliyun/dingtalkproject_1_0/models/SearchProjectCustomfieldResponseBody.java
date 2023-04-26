// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SearchProjectCustomfieldResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

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

    public SearchProjectCustomfieldResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield extends TeaModel {
        @NameInMap("advancedCustomfieldId")
        public String advancedCustomfieldId;

        @NameInMap("name")
        public String name;

        @NameInMap("objectType")
        public String objectType;

        public static SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield self = new SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield setAdvancedCustomfieldId(String advancedCustomfieldId) {
            this.advancedCustomfieldId = advancedCustomfieldId;
            return this;
        }
        public String getAdvancedCustomfieldId() {
            return this.advancedCustomfieldId;
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield setObjectType(String objectType) {
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
        @NameInMap("advancedCustomfield")
        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield;

        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        @NameInMap("choices")
        public java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> choices;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfiledId")
        public String customfiledId;

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

        public SearchProjectCustomfieldResponseBodyResult setAdvancedCustomfield(SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield) {
            this.advancedCustomfield = advancedCustomfield;
            return this;
        }
        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield getAdvancedCustomfield() {
            return this.advancedCustomfield;
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

        public SearchProjectCustomfieldResponseBodyResult setCustomfiledId(String customfiledId) {
            this.customfiledId = customfiledId;
            return this;
        }
        public String getCustomfiledId() {
            return this.customfiledId;
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
