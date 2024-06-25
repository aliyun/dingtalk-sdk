// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CopyProcessRequest extends TeaModel {
    @NameInMap("copyOptions")
    public CopyProcessRequestCopyOptions copyOptions;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingabc</p>
     */
    @NameInMap("sourceCorpId")
    public String sourceCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceProcessVOList")
    public java.util.List<CopyProcessRequestSourceProcessVOList> sourceProcessVOList;

    public static CopyProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyProcessRequest self = new CopyProcessRequest();
        return TeaModel.build(map, self);
    }

    public CopyProcessRequest setCopyOptions(CopyProcessRequestCopyOptions copyOptions) {
        this.copyOptions = copyOptions;
        return this;
    }
    public CopyProcessRequestCopyOptions getCopyOptions() {
        return this.copyOptions;
    }

    public CopyProcessRequest setSourceCorpId(String sourceCorpId) {
        this.sourceCorpId = sourceCorpId;
        return this;
    }
    public String getSourceCorpId() {
        return this.sourceCorpId;
    }

    public CopyProcessRequest setSourceProcessVOList(java.util.List<CopyProcessRequestSourceProcessVOList> sourceProcessVOList) {
        this.sourceProcessVOList = sourceProcessVOList;
        return this;
    }
    public java.util.List<CopyProcessRequestSourceProcessVOList> getSourceProcessVOList() {
        return this.sourceProcessVOList;
    }

    public static class CopyProcessRequestCopyOptions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("copyType")
        public Integer copyType;

        public static CopyProcessRequestCopyOptions build(java.util.Map<String, ?> map) throws Exception {
            CopyProcessRequestCopyOptions self = new CopyProcessRequestCopyOptions();
            return TeaModel.build(map, self);
        }

        public CopyProcessRequestCopyOptions setCopyType(Integer copyType) {
            this.copyType = copyType;
            return this;
        }
        public Integer getCopyType() {
            return this.copyType;
        }

    }

    public static class CopyProcessRequestSourceProcessVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>proc-abc</p>
         */
        @NameInMap("processCode")
        public String processCode;

        public static CopyProcessRequestSourceProcessVOList build(java.util.Map<String, ?> map) throws Exception {
            CopyProcessRequestSourceProcessVOList self = new CopyProcessRequestSourceProcessVOList();
            return TeaModel.build(map, self);
        }

        public CopyProcessRequestSourceProcessVOList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public CopyProcessRequestSourceProcessVOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CopyProcessRequestSourceProcessVOList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
