// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserStayLengthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220501</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static GetUserStayLengthRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserStayLengthRequest self = new GetUserStayLengthRequest();
        return TeaModel.build(map, self);
    }

    public GetUserStayLengthRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetUserStayLengthRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetUserStayLengthRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
