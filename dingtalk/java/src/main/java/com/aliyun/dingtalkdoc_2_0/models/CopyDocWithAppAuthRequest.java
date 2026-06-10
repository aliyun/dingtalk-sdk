// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocWithAppAuthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceDentryUuid")
    public String sourceDentryUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetParentDentryUuid")
    public String targetParentDentryUuid;

    @NameInMap("targetPreDentryUuid")
    public String targetPreDentryUuid;

    public static CopyDocWithAppAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyDocWithAppAuthRequest self = new CopyDocWithAppAuthRequest();
        return TeaModel.build(map, self);
    }

    public CopyDocWithAppAuthRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CopyDocWithAppAuthRequest setSourceDentryUuid(String sourceDentryUuid) {
        this.sourceDentryUuid = sourceDentryUuid;
        return this;
    }
    public String getSourceDentryUuid() {
        return this.sourceDentryUuid;
    }

    public CopyDocWithAppAuthRequest setTargetParentDentryUuid(String targetParentDentryUuid) {
        this.targetParentDentryUuid = targetParentDentryUuid;
        return this;
    }
    public String getTargetParentDentryUuid() {
        return this.targetParentDentryUuid;
    }

    public CopyDocWithAppAuthRequest setTargetPreDentryUuid(String targetPreDentryUuid) {
        this.targetPreDentryUuid = targetPreDentryUuid;
        return this;
    }
    public String getTargetPreDentryUuid() {
        return this.targetPreDentryUuid;
    }

}
