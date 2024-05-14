// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MoveDentryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    @NameInMap("toNextDentryId")
    public String toNextDentryId;

    @NameInMap("toParentDentryId")
    public String toParentDentryId;

    @NameInMap("toPrevDentryId")
    public String toPrevDentryId;

    public static MoveDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveDentryRequest self = new MoveDentryRequest();
        return TeaModel.build(map, self);
    }

    public MoveDentryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public MoveDentryRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveDentryRequest setToNextDentryId(String toNextDentryId) {
        this.toNextDentryId = toNextDentryId;
        return this;
    }
    public String getToNextDentryId() {
        return this.toNextDentryId;
    }

    public MoveDentryRequest setToParentDentryId(String toParentDentryId) {
        this.toParentDentryId = toParentDentryId;
        return this;
    }
    public String getToParentDentryId() {
        return this.toParentDentryId;
    }

    public MoveDentryRequest setToPrevDentryId(String toPrevDentryId) {
        this.toPrevDentryId = toPrevDentryId;
        return this;
    }
    public String getToPrevDentryId() {
        return this.toPrevDentryId;
    }

}
