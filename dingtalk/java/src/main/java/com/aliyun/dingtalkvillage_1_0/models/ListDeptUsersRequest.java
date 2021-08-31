// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersRequest extends TeaModel {
    // cursor
    @NameInMap("cursor")
    public Long cursor;

    // size
    @NameInMap("size")
    public Integer size;

    // containAccessLimit
    @NameInMap("containAccessLimit")
    public Boolean containAccessLimit;

    // 下属组织的组织ID，比如下属镇、村的corpId
    @NameInMap("subCorpId")
    public String subCorpId;

    // language
    @NameInMap("language")
    public String language;

    // orderField
    @NameInMap("orderField")
    public String orderField;

    public static ListDeptUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersRequest self = new ListDeptUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListDeptUsersRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListDeptUsersRequest setContainAccessLimit(Boolean containAccessLimit) {
        this.containAccessLimit = containAccessLimit;
        return this;
    }
    public Boolean getContainAccessLimit() {
        return this.containAccessLimit;
    }

    public ListDeptUsersRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
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

}
