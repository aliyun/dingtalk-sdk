// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchUserRequest extends TeaModel {
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 用户名称、名称拼音或英文名称
    @NameInMap("queryWord")
    public String queryWord;

    // 分页查询锚点
    @NameInMap("offset")
    public Integer offset;

    // 分页长度
    @NameInMap("size")
    public Integer size;

    // 精确匹配的字段。1：匹配用户名称。不填则为模糊匹配
    @NameInMap("fullMatchField")
    public Integer fullMatchField;

    public static SearchUserRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchUserRequest self = new SearchUserRequest();
        return TeaModel.build(map, self);
    }

    public SearchUserRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SearchUserRequest setQueryWord(String queryWord) {
        this.queryWord = queryWord;
        return this;
    }
    public String getQueryWord() {
        return this.queryWord;
    }

    public SearchUserRequest setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
        return this.offset;
    }

    public SearchUserRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public SearchUserRequest setFullMatchField(Integer fullMatchField) {
        this.fullMatchField = fullMatchField;
        return this;
    }
    public Integer getFullMatchField() {
        return this.fullMatchField;
    }

}
