// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SearchFlowRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("cursor")
    public String cursor;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1626861600000</p>
     */
    @NameInMap("maxModifyTimeMills")
    public Long maxModifyTimeMills;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1626861600000</p>
     */
    @NameInMap("minModifyTimeMills")
    public Long minModifyTimeMills;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("size")
    public Long size;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static SearchFlowRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFlowRequest self = new SearchFlowRequest();
        return TeaModel.build(map, self);
    }

    public SearchFlowRequest setCursor(String cursor) {
        this.cursor = cursor;
        return this;
    }
    public String getCursor() {
        return this.cursor;
    }

    public SearchFlowRequest setMaxModifyTimeMills(Long maxModifyTimeMills) {
        this.maxModifyTimeMills = maxModifyTimeMills;
        return this;
    }
    public Long getMaxModifyTimeMills() {
        return this.maxModifyTimeMills;
    }

    public SearchFlowRequest setMinModifyTimeMills(Long minModifyTimeMills) {
        this.minModifyTimeMills = minModifyTimeMills;
        return this;
    }
    public Long getMinModifyTimeMills() {
        return this.minModifyTimeMills;
    }

    public SearchFlowRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

    public SearchFlowRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
