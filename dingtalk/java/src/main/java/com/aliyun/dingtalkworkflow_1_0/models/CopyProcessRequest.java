// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CopyProcessRequest extends TeaModel {
    // 复制选项
    @NameInMap("copyOptions")
    public CopyProcessRequestCopyOptions copyOptions;

    @NameInMap("sourceCorpId")
    public String sourceCorpId;

    // 源模版列表
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
        // 默认为1
        // COPE_TYPE_DEFAULT = 1 默认会使用groupId进行隔离分组，审批首页不可见
        // COPE_TYPE_INCLUDE_FLOW = 2 使用dingtalk 2作为隔离分组，审批首页可见
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
        // 套件业务标识
        @NameInMap("bizType")
        public String bizType;

        // 模板名称
        @NameInMap("name")
        public String name;

        // 模板code
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
