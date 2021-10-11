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

    // key为钉盘文件mediaId，#号开头。只支持xlsx，xls，csv，txt文件。 value为文件名，包含文件扩展名。 不超过20个文件，可以调用单步文件上传接口获取。
    @NameInMap("medias")
    public java.util.Map<String, String> medias;

    // 若medias中文件个数大于1，则该字段必填。 转译完打包的文件名，不需带后缀。钉钉后台会打包成zip压缩文件，并自动拼接上.zip后缀。
    @NameInMap("outputFileName")
    public String outputFileName;

    // unionId
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("eagleEyeTraceId")
    public String eagleEyeTraceId;

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

    public TranslateFileRequest setMedias(java.util.Map<String, String> medias) {
        this.medias = medias;
        return this;
    }
    public java.util.Map<String, String> getMedias() {
        return this.medias;
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

    public TranslateFileRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public TranslateFileRequest setEagleEyeTraceId(String eagleEyeTraceId) {
        this.eagleEyeTraceId = eagleEyeTraceId;
        return this;
    }
    public String getEagleEyeTraceId() {
        return this.eagleEyeTraceId;
    }

}
