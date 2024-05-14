// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ExportPointOpenRequest extends TeaModel {
    @NameInMap("exportDate")
    public String exportDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("exportType")
    public Long exportType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ExportPointOpenRequest build(java.util.Map<String, ?> map) throws Exception {
        ExportPointOpenRequest self = new ExportPointOpenRequest();
        return TeaModel.build(map, self);
    }

    public ExportPointOpenRequest setExportDate(String exportDate) {
        this.exportDate = exportDate;
        return this;
    }
    public String getExportDate() {
        return this.exportDate;
    }

    public ExportPointOpenRequest setExportType(Long exportType) {
        this.exportType = exportType;
        return this;
    }
    public Long getExportType() {
        return this.exportType;
    }

    public ExportPointOpenRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
