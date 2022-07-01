// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDentryRequest extends TeaModel {
    // 拷贝后的文档名称，长度不能超过50。
    @NameInMap("name")
    public String name;

    // 操作人unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 需要移动到的知识库id。
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    // 移动到目标位置的后置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
    @NameInMap("toNextDentryId")
    public String toNextDentryId;

    // 需要移动到目标位置的父节点id。如果为根目录，则不传；如果为非根目录，则需要传对应的id。
    @NameInMap("toParentDentryId")
    public String toParentDentryId;

    // 移动到目标位置的前置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
    @NameInMap("toPrevDentryId")
    public String toPrevDentryId;

    public static CopyDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyDentryRequest self = new CopyDentryRequest();
        return TeaModel.build(map, self);
    }

    public CopyDentryRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CopyDentryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CopyDentryRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public CopyDentryRequest setToNextDentryId(String toNextDentryId) {
        this.toNextDentryId = toNextDentryId;
        return this;
    }
    public String getToNextDentryId() {
        return this.toNextDentryId;
    }

    public CopyDentryRequest setToParentDentryId(String toParentDentryId) {
        this.toParentDentryId = toParentDentryId;
        return this;
    }
    public String getToParentDentryId() {
        return this.toParentDentryId;
    }

    public CopyDentryRequest setToPrevDentryId(String toPrevDentryId) {
        this.toPrevDentryId = toPrevDentryId;
        return this;
    }
    public String getToPrevDentryId() {
        return this.toPrevDentryId;
    }

}
