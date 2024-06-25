// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeductPointRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>biz01</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>兑换商品</p>
     */
    @NameInMap("deductDesc")
    public String deductDesc;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></p>
     */
    @NameInMap("deductDetailUrl")
    public String deductDetailUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deductNum")
    public Integer deductNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>personal</p>
     */
    @NameInMap("pointType")
    public String pointType;

    public static DeductPointRequest build(java.util.Map<String, ?> map) throws Exception {
        DeductPointRequest self = new DeductPointRequest();
        return TeaModel.build(map, self);
    }

    public DeductPointRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public DeductPointRequest setDeductDesc(String deductDesc) {
        this.deductDesc = deductDesc;
        return this;
    }
    public String getDeductDesc() {
        return this.deductDesc;
    }

    public DeductPointRequest setDeductDetailUrl(String deductDetailUrl) {
        this.deductDetailUrl = deductDetailUrl;
        return this;
    }
    public String getDeductDetailUrl() {
        return this.deductDetailUrl;
    }

    public DeductPointRequest setDeductNum(Integer deductNum) {
        this.deductNum = deductNum;
        return this;
    }
    public Integer getDeductNum() {
        return this.deductNum;
    }

    public DeductPointRequest setPointType(String pointType) {
        this.pointType = pointType;
        return this;
    }
    public String getPointType() {
        return this.pointType;
    }

}
