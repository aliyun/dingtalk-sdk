// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchUserRequest extends TeaModel {
    @NameInMap("fullMatchField")
    public Integer fullMatchField;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("queryWord")
    public String queryWord;

    /**
     * <p>This parameter is required.</p>
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
