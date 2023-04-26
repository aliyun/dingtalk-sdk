// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersRequest extends TeaModel {
    @NameInMap("containAccessLimit")
    public Boolean containAccessLimit;

    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("language")
    public String language;

    @NameInMap("orderField")
    public String orderField;

    @NameInMap("size")
    public Integer size;

    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListDeptUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersRequest self = new ListDeptUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersRequest setContainAccessLimit(Boolean containAccessLimit) {
        this.containAccessLimit = containAccessLimit;
        return this;
    }
    public Boolean getContainAccessLimit() {
        return this.containAccessLimit;
    }

    public ListDeptUsersRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListDeptUsersRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ListDeptUsersRequest setOrderField(String orderField) {
        this.orderField = orderField;
        return this;
    }
    public String getOrderField() {
        return this.orderField;
    }

    public ListDeptUsersRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListDeptUsersRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
