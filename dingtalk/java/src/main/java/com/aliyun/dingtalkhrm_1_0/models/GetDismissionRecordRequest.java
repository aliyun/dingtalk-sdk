// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetDismissionRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>30</p>
     */
    @NameInMap("size")
    public Integer size;

    public static GetDismissionRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDismissionRecordRequest self = new GetDismissionRecordRequest();
        return TeaModel.build(map, self);
    }

    public GetDismissionRecordRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetDismissionRecordRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
