// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListRequest extends TeaModel {
    // isv corpId
    @NameInMap("isvCorpId")
    public String isvCorpId;

    // 外部商户批次号
    @NameInMap("outBatchNo")
    public String outBatchNo;

    // 当前页数
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 每页记录数
    @NameInMap("pageSize")
    public Integer pageSize;

    // ISV/企业自建应用suiteId
    @NameInMap("suiteId")
    public String suiteId;

    public static QueryBatchTradeDetailListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeDetailListRequest self = new QueryBatchTradeDetailListRequest();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeDetailListRequest setIsvCorpId(String isvCorpId) {
        this.isvCorpId = isvCorpId;
        return this;
    }
    public String getIsvCorpId() {
        return this.isvCorpId;
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

    public QueryBatchTradeDetailListRequest setSuiteId(String suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public String getSuiteId() {
        return this.suiteId;
    }

}
