// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponseBody extends TeaModel {
    /**
     * <p>供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>自定义字段列表。</p>
     */
    @NameInMap("result")
    public java.util.List<SearchProjectCustomfieldResponseBodyResult> result;

    /**
     * <p>总数。</p>
     */
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
         * <p>字段类型名称2。</p>
         */
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
        /**
         * <p>选项Id。</p>
         */
        @NameInMap("choiceId")
        public String choiceId;

        /**
         * <p>选项值。</p>
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
        /**
         * <p>高级自定义字段。</p>
         */
        @NameInMap("advancedCustomfield")
        public SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield advancedCustomfield;

        /**
         * <p>绑定的对象Id，此接口为项目ID。</p>
         */
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        /**
         * <p>如果是单选或多选字段，这里是可选项的值</p>
         */
        @NameInMap("choices")
        public java.util.List<SearchProjectCustomfieldResponseBodyResultChoices> choices;

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
        @NameInMap("customfiledId")
        public String customfiledId;

        /**
         * <p>字段名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>如果是企业字段，该字段表达绑定的企业字段ID。</p>
         */
        @NameInMap("originalId")
        public String originalId;

        /**
         * <p>用户自定义数据载体，json格式类型任意数据。</p>
         */
        @NameInMap("payload")
        public java.util.Map<String, ?> payload;

        /**
         * <p>字段类型。 'number', // 数字 'date', // 日期 'text', // 文本 'work', 'multipleChoice', // 多选 'dropDown', // 下拉, 'lookup', 'commongroup', 'cascading', // 层级字段 'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段</p>
         */
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
