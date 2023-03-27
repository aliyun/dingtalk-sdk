// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldResponseBody extends TeaModel {
    /**
     * <p>供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>自定义字段列表。</p>
     */
    @NameInMap("result")
    public java.util.List<SearchOranizationCustomfieldResponseBodyResult> result;

    /**
     * <p>总数。</p>
     */
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
        /**
         * <p>字段类型ID。</p>
         */
        @NameInMap("advancedCustomfieldId")
        public String advancedCustomfieldId;

        /**
         * <p>字段类型名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>字段类型名称2</p>
         */
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
        /**
         * <p>选项ID。</p>
         */
        @NameInMap("choiceId")
        public String choiceId;

        /**
         * <p>选项值。</p>
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
        /**
         * <p>高级自定义字段。</p>
         */
        @NameInMap("advancedCustomfield")
        public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield;

        /**
         * <p>如果是单选或多选字段，这里是可选项的值</p>
         */
        @NameInMap("choices")
        public java.util.List<SearchOranizationCustomfieldResponseBodyResultChoices> choices;

        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建人ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>自定义字段ID。</p>
         */
        @NameInMap("customfieldsId")
        public String customfieldsId;

        /**
         * <p>字段名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户自定义数据载体，json格式类型任意数据。</p>
         */
        @NameInMap("payload")
        public java.util.Map<String, ?> payload;

        /**
         * <p>字段类型。   'number', // 数字     'date', // 日期     'text', // 文本     'work',     'multipleChoice', // 多选     'dropDown', // 下拉,     'lookup',     'commongroup',     'cascading', // 层级字段     'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段</p>
         */
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
