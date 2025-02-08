// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelKitTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>CARD_EVENT</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>ding12123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>2023234234234</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <strong>example:</strong>
     * <p>CHENZHI</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    public static CancelKitTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelKitTaskRequest self = new CancelKitTaskRequest();
        return TeaModel.build(map, self);
    }

    public CancelKitTaskRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public CancelKitTaskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CancelKitTaskRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public CancelKitTaskRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

}
