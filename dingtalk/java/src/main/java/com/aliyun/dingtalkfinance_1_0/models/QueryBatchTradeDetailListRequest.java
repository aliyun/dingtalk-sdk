// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20210901001</p>
     */
    @NameInMap("outBatchNo")
    public String outBatchNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryBatchTradeDetailListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeDetailListRequest self = new QueryBatchTradeDetailListRequest();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeDetailListRequest setOutBatchNo(String outBatchNo) {
        this.outBatchNo = outBatchNo;
        return this;
    }
    public String getOutBatchNo() {
        return this.outBatchNo;
    }

    public QueryBatchTradeDetailListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryBatchTradeDetailListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
