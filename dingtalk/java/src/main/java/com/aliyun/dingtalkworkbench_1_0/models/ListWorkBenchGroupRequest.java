// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ListWorkBenchGroupRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("opUnionId")
    public String opUnionId;

    // 合作空间corpId
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    // WORK_ALL
    @NameInMap("groupType")
    public String groupType;

    public static ListWorkBenchGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        ListWorkBenchGroupRequest self = new ListWorkBenchGroupRequest();
        return TeaModel.build(map, self);
    }

    public ListWorkBenchGroupRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public ListWorkBenchGroupRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

    public ListWorkBenchGroupRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

}
