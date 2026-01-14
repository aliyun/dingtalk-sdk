// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateExportDeviceStatisticTaskResponseBody extends TeaModel {
    @NameInMap("exportStatisticTaskDTO")
    public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO exportStatisticTaskDTO;

    public static CreateExportDeviceStatisticTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateExportDeviceStatisticTaskResponseBody self = new CreateExportDeviceStatisticTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateExportDeviceStatisticTaskResponseBody setExportStatisticTaskDTO(CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO exportStatisticTaskDTO) {
        this.exportStatisticTaskDTO = exportStatisticTaskDTO;
        return this;
    }
    public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO getExportStatisticTaskDTO() {
        return this.exportStatisticTaskDTO;
    }

    public static class CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO extends TeaModel {
        @NameInMap("aiSheetTemplateId")
        public Long aiSheetTemplateId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("documentId")
        public String documentId;

        @NameInMap("documentName")
        public String documentName;

        @NameInMap("documentUrl")
        public String documentUrl;

        public static CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO self = new CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO();
            return TeaModel.build(map, self);
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO setAiSheetTemplateId(Long aiSheetTemplateId) {
            this.aiSheetTemplateId = aiSheetTemplateId;
            return this;
        }
        public Long getAiSheetTemplateId() {
            return this.aiSheetTemplateId;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO setDocumentId(String documentId) {
            this.documentId = documentId;
            return this;
        }
        public String getDocumentId() {
            return this.documentId;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO setDocumentName(String documentName) {
            this.documentName = documentName;
            return this;
        }
        public String getDocumentName() {
            return this.documentName;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO setDocumentUrl(String documentUrl) {
            this.documentUrl = documentUrl;
            return this;
        }
        public String getDocumentUrl() {
            return this.documentUrl;
        }

    }

    public static class CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO extends TeaModel {
        @NameInMap("aiSheetDocumentOpenDTO")
        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO aiSheetDocumentOpenDTO;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskName")
        public String taskName;

        @NameInMap("unionId")
        public String unionId;

        public static CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO build(java.util.Map<String, ?> map) throws Exception {
            CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO self = new CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO();
            return TeaModel.build(map, self);
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO setAiSheetDocumentOpenDTO(CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO aiSheetDocumentOpenDTO) {
            this.aiSheetDocumentOpenDTO = aiSheetDocumentOpenDTO;
            return this;
        }
        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO getAiSheetDocumentOpenDTO() {
            return this.aiSheetDocumentOpenDTO;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
