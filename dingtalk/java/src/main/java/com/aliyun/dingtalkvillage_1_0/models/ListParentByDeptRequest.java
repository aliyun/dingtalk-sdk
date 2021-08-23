// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByDeptRequest extends TeaModel {
    // 真实请求的组织corpId
    @NameInMap("subCorpId")
    public String subCorpId;

    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    public static ListParentByDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        ListParentByDeptRequest self = new ListParentByDeptRequest();
        return TeaModel.build(map, self);
    }

    public ListParentByDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListParentByDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
