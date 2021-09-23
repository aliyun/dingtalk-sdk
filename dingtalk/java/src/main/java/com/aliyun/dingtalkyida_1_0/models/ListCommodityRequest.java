// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListCommodityRequest extends TeaModel {
    // accessKey
    @NameInMap("accessKey")
    public String accessKey;

    // pageSize
    @NameInMap("pageSize")
    public Integer pageSize;

    // callerUid
    @NameInMap("callerUid")
    public String callerUid;

    // currentPage
    @NameInMap("currentPage")
    public Integer currentPage;

    public static ListCommodityRequest build(java.util.Map<String, ?> map) throws Exception {
        ListCommodityRequest self = new ListCommodityRequest();
        return TeaModel.build(map, self);
    }

    public ListCommodityRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public ListCommodityRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListCommodityRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

    public ListCommodityRequest setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

}
