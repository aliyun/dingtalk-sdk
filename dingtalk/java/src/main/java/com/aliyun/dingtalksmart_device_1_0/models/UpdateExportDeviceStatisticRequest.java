// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class UpdateExportDeviceStatisticRequest extends TeaModel {
    @NameInMap("creatorCorpId")
    public String creatorCorpId;

    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("records")
    public java.util.List<UpdateExportDeviceStatisticRequestRecords> records;

    @NameInMap("taskId")
    public String taskId;

    public static UpdateExportDeviceStatisticRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateExportDeviceStatisticRequest self = new UpdateExportDeviceStatisticRequest();
        return TeaModel.build(map, self);
    }

    public UpdateExportDeviceStatisticRequest setCreatorCorpId(String creatorCorpId) {
        this.creatorCorpId = creatorCorpId;
        return this;
    }
    public String getCreatorCorpId() {
        return this.creatorCorpId;
    }

    public UpdateExportDeviceStatisticRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public UpdateExportDeviceStatisticRequest setRecords(java.util.List<UpdateExportDeviceStatisticRequestRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<UpdateExportDeviceStatisticRequestRecords> getRecords() {
        return this.records;
    }

    public UpdateExportDeviceStatisticRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class UpdateExportDeviceStatisticRequestRecords extends TeaModel {
        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        @NameInMap("sheetName")
        public String sheetName;

        public static UpdateExportDeviceStatisticRequestRecords build(java.util.Map<String, ?> map) throws Exception {
            UpdateExportDeviceStatisticRequestRecords self = new UpdateExportDeviceStatisticRequestRecords();
            return TeaModel.build(map, self);
        }

        public UpdateExportDeviceStatisticRequestRecords setFields(java.util.Map<String, ?> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.Map<String, ?> getFields() {
            return this.fields;
        }

        public UpdateExportDeviceStatisticRequestRecords setSheetName(String sheetName) {
            this.sheetName = sheetName;
            return this;
        }
        public String getSheetName() {
            return this.sheetName;
        }

    }

}
