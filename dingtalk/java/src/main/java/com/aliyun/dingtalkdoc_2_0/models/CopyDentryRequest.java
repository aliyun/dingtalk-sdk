// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDentryRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    @NameInMap("toNextDentryId")
    public String toNextDentryId;

    @NameInMap("toParentDentryId")
    public String toParentDentryId;

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
