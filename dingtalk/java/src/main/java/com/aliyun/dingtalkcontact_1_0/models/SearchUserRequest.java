// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchUserRequest extends TeaModel {
    /**
     * <p>精确匹配的字段。1：匹配用户名称。不填则为模糊匹配</p>
     */
    @NameInMap("fullMatchField")
    public Integer fullMatchField;

    /**
     * <p>分页查询锚点</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>用户名称、名称拼音或英文名称</p>
     */
    @NameInMap("queryWord")
    public String queryWord;

    /**
     * <p>分页长度</p>
     */
    @NameInMap("size")
    public Integer size;

    public static SearchUserRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchUserRequest self = new SearchUserRequest();
        return TeaModel.build(map, self);
    }

    public SearchUserRequest setFullMatchField(Integer fullMatchField) {
        this.fullMatchField = fullMatchField;
        return this;
    }
    public Integer getFullMatchField() {
        return this.fullMatchField;
    }

    public SearchUserRequest setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
        return this.offset;
    }

    public SearchUserRequest setQueryWord(String queryWord) {
        this.queryWord = queryWord;
        return this;
    }
    public String getQueryWord() {
        return this.queryWord;
    }

    public SearchUserRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
