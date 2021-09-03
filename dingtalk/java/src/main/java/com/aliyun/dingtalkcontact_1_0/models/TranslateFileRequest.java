// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TranslateFileRequest extends TeaModel {
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 钉盘mediaId，#号开头。可以通过单步上传api获取
    @NameInMap("mediaId")
    public String mediaId;

    // 转译后文件名（含扩展名）
    @NameInMap("outputFileName")
    public String outputFileName;

    // unionId
    @NameInMap("unionId")
    public String unionId;

    public static TranslateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        TranslateFileRequest self = new TranslateFileRequest();
        return TeaModel.build(map, self);
    }

    public TranslateFileRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public TranslateFileRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public TranslateFileRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public TranslateFileRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public TranslateFileRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public TranslateFileRequest setOutputFileName(String outputFileName) {
        this.outputFileName = outputFileName;
        return this;
    }
    public String getOutputFileName() {
        return this.outputFileName;
    }

    public TranslateFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
