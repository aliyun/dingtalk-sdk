// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByUserRequest extends TeaModel {
    /**
     * <p>页数</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>钉钉userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListObjectiveByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByUserRequest self = new ListObjectiveByUserRequest();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByUserRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListObjectiveByUserRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListObjectiveByUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
