// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GenerateFlashMinutesDocumentUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cloud_record</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>1727185971000</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("expireTime")
    public Long expireTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRG9KXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GenerateFlashMinutesDocumentUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GenerateFlashMinutesDocumentUrlRequest self = new GenerateFlashMinutesDocumentUrlRequest();
        return TeaModel.build(map, self);
    }

    public GenerateFlashMinutesDocumentUrlRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public GenerateFlashMinutesDocumentUrlRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public GenerateFlashMinutesDocumentUrlRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
