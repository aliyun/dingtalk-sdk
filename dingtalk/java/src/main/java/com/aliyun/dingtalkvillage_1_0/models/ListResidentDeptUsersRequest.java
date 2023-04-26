// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentDeptUsersRequest extends TeaModel {
    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("role")
    public String role;

    @NameInMap("size")
    public Integer size;

    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListResidentDeptUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListResidentDeptUsersRequest self = new ListResidentDeptUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListResidentDeptUsersRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListResidentDeptUsersRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public ListResidentDeptUsersRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListResidentDeptUsersRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
