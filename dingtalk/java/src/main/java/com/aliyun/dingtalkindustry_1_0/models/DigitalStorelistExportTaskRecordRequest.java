// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStorelistExportTaskRecordRequest extends TeaModel {
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static DigitalStorelistExportTaskRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStorelistExportTaskRecordRequest self = new DigitalStorelistExportTaskRecordRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStorelistExportTaskRecordRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public DigitalStorelistExportTaskRecordRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
