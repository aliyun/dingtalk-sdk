// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PreDialRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>00003213130</p>
     */
    @NameInMap("callerUserId")
    public String callerUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>312000030213120</p>
     */
    @NameInMap("receiverUserId")
    public String receiverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fdaf-2132</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>VIDEO_CALL</p>
     */
    @NameInMap("type")
    public String type;

    public static PreDialRequest build(java.util.Map<String, ?> map) throws Exception {
        PreDialRequest self = new PreDialRequest();
        return TeaModel.build(map, self);
    }

    public PreDialRequest setCallerUserId(String callerUserId) {
        this.callerUserId = callerUserId;
        return this;
    }
    public String getCallerUserId() {
        return this.callerUserId;
    }

    public PreDialRequest setReceiverUserId(String receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public String getReceiverUserId() {
        return this.receiverUserId;
    }

    public PreDialRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public PreDialRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
