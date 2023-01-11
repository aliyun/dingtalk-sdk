// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListCommodityRequest extends TeaModel {
    /**
     * <p>accessKey</p>
     */
    @NameInMap("accessKey")
    public String accessKey;

    /**
     * <p>callerUid</p>
     */
    @NameInMap("callerUid")
    public String callerUid;

    /**
     * <p>currentPage</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>pageSize</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

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

    public ListCommodityRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

    public ListCommodityRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListCommodityRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
