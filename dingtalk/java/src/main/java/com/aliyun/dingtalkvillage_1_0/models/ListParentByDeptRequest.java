// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByDeptRequest extends TeaModel {
    @NameInMap("departmentId")
    public Long departmentId;

    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListParentByDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        ListParentByDeptRequest self = new ListParentByDeptRequest();
        return TeaModel.build(map, self);
    }

    public ListParentByDeptRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public ListParentByDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
