// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DataSyncResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("rowsAffected")
    public Integer rowsAffected;

    public static DataSyncResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DataSyncResponseBody self = new DataSyncResponseBody();
        return TeaModel.build(map, self);
    }

    public DataSyncResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public DataSyncResponseBody setRowsAffected(Integer rowsAffected) {
        this.rowsAffected = rowsAffected;
        return this;
    }
    public Integer getRowsAffected() {
        return this.rowsAffected;
    }

}
