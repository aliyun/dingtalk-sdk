// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ExportDocRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public ExportDocRequestParam param;

    public static ExportDocRequest build(java.util.Map<String, ?> map) throws Exception {
        ExportDocRequest self = new ExportDocRequest();
        return TeaModel.build(map, self);
    }

    public ExportDocRequest setParam(ExportDocRequestParam param) {
        this.param = param;
        return this;
    }
    public ExportDocRequestParam getParam() {
        return this.param;
    }

    public static class ExportDocRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dingTalksheetToxlsx</p>
         */
        @NameInMap("exportType")
        public String exportType;

        public static ExportDocRequestParam build(java.util.Map<String, ?> map) throws Exception {
            ExportDocRequestParam self = new ExportDocRequestParam();
            return TeaModel.build(map, self);
        }

        public ExportDocRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public ExportDocRequestParam setExportType(String exportType) {
            this.exportType = exportType;
            return this;
        }
        public String getExportType() {
            return this.exportType;
        }

    }

}
