// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentDeptUsersRequest extends TeaModel {
    /**
     * <p>游标，不传默认1</p>
     */
    @NameInMap("cursor")
    public Long cursor;

    /**
     * <p>角色标签</p>
     */
    @NameInMap("role")
    public String role;

    /**
     * <p>大小</p>
     */
    @NameInMap("size")
    public Integer size;

    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
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
