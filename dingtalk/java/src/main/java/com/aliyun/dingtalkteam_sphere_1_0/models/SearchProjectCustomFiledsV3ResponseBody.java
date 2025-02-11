// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomFiledsV3ResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<SearchProjectCustomFiledsV3ResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>35</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static SearchProjectCustomFiledsV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomFiledsV3ResponseBody self = new SearchProjectCustomFiledsV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomFiledsV3ResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectCustomFiledsV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SearchProjectCustomFiledsV3ResponseBody setResult(java.util.List<SearchProjectCustomFiledsV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchProjectCustomFiledsV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public SearchProjectCustomFiledsV3ResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("objectType")
        public String objectType;

        public static SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield self = new SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

    }

    public static class SearchProjectCustomFiledsV3ResponseBodyResultChoices extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("value")
        public String value;

        public static SearchProjectCustomFiledsV3ResponseBodyResultChoices build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomFiledsV3ResponseBodyResultChoices self = new SearchProjectCustomFiledsV3ResponseBodyResultChoices();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomFiledsV3ResponseBodyResultChoices setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResultChoices setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SearchProjectCustomFiledsV3ResponseBodyResult extends TeaModel {
        @NameInMap("advancedCustomfield")
        public SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield advancedCustomfield;

        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        @NameInMap("boundToObjectType")
        public String boundToObjectType;

        @NameInMap("choices")
        public java.util.List<SearchProjectCustomFiledsV3ResponseBodyResultChoices> choices;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("originalId")
        public String originalId;

        @NameInMap("type")
        public String type;

        public static SearchProjectCustomFiledsV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectCustomFiledsV3ResponseBodyResult self = new SearchProjectCustomFiledsV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setAdvancedCustomfield(SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield advancedCustomfield) {
            this.advancedCustomfield = advancedCustomfield;
            return this;
        }
        public SearchProjectCustomFiledsV3ResponseBodyResultAdvancedCustomfield getAdvancedCustomfield() {
            return this.advancedCustomfield;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setBoundToObjectType(String boundToObjectType) {
            this.boundToObjectType = boundToObjectType;
            return this;
        }
        public String getBoundToObjectType() {
            return this.boundToObjectType;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setChoices(java.util.List<SearchProjectCustomFiledsV3ResponseBodyResultChoices> choices) {
            this.choices = choices;
            return this;
        }
        public java.util.List<SearchProjectCustomFiledsV3ResponseBodyResultChoices> getChoices() {
            return this.choices;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setOriginalId(String originalId) {
            this.originalId = originalId;
            return this;
        }
        public String getOriginalId() {
            return this.originalId;
        }

        public SearchProjectCustomFiledsV3ResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
