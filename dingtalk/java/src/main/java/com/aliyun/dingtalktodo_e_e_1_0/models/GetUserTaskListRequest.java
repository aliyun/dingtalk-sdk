// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetUserTaskListRequest extends TeaModel {
    @NameInMap("done")
    public Boolean done;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("type")
    public String type;

    public static GetUserTaskListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserTaskListRequest self = new GetUserTaskListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserTaskListRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetUserTaskListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetUserTaskListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetUserTaskListRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
