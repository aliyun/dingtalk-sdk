// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptSimpleUsersRequest extends TeaModel {
    // containAccessLimit
    @NameInMap("containAccessLimit")
    public Boolean containAccessLimit;

    // cursor
    @NameInMap("cursor")
    public Long cursor;

    // language
    @NameInMap("language")
    public String language;

    // orderField
    @NameInMap("orderField")
    public String orderField;

    // size
    @NameInMap("size")
    public Integer size;

    // 下属组织的组织ID，比如下属镇、村的corpId
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListDeptSimpleUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDeptSimpleUsersRequest self = new ListDeptSimpleUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListDeptSimpleUsersRequest setContainAccessLimit(Boolean containAccessLimit) {
        this.containAccessLimit = containAccessLimit;
        return this;
    }
    public Boolean getContainAccessLimit() {
        return this.containAccessLimit;
    }

    public ListDeptSimpleUsersRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListDeptSimpleUsersRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ListDeptSimpleUsersRequest setOrderField(String orderField) {
        this.orderField = orderField;
        return this;
    }
    public String getOrderField() {
        return this.orderField;
    }

    public ListDeptSimpleUsersRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListDeptSimpleUsersRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
