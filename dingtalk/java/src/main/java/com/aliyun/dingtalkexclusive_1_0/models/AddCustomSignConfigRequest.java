// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddCustomSignConfigRequest extends TeaModel {
    @NameInMap("allEffect")
    public Boolean allEffect;

    @NameInMap("canDownload")
    public Boolean canDownload;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx协议</p>
     */
    @NameInMap("protocolName")
    public String protocolName;

    @NameInMap("pushDeptIds")
    public java.util.List<String> pushDeptIds;

    @NameInMap("pushStaffIds")
    public java.util.List<String> pushStaffIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signTermFiles")
    public java.util.List<AddCustomSignConfigRequestSignTermFiles> signTermFiles;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx协议说明</p>
     */
    @NameInMap("termMessage")
    public String termMessage;

    @NameInMap("unpushDeptIds")
    public java.util.List<String> unpushDeptIds;

    @NameInMap("unpushStaffIds")
    public java.util.List<String> unpushStaffIds;

    public static AddCustomSignConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCustomSignConfigRequest self = new AddCustomSignConfigRequest();
        return TeaModel.build(map, self);
    }

    public AddCustomSignConfigRequest setAllEffect(Boolean allEffect) {
        this.allEffect = allEffect;
        return this;
    }
    public Boolean getAllEffect() {
        return this.allEffect;
    }

    public AddCustomSignConfigRequest setCanDownload(Boolean canDownload) {
        this.canDownload = canDownload;
        return this;
    }
    public Boolean getCanDownload() {
        return this.canDownload;
    }

    public AddCustomSignConfigRequest setProtocolName(String protocolName) {
        this.protocolName = protocolName;
        return this;
    }
    public String getProtocolName() {
        return this.protocolName;
    }

    public AddCustomSignConfigRequest setPushDeptIds(java.util.List<String> pushDeptIds) {
        this.pushDeptIds = pushDeptIds;
        return this;
    }
    public java.util.List<String> getPushDeptIds() {
        return this.pushDeptIds;
    }

    public AddCustomSignConfigRequest setPushStaffIds(java.util.List<String> pushStaffIds) {
        this.pushStaffIds = pushStaffIds;
        return this;
    }
    public java.util.List<String> getPushStaffIds() {
        return this.pushStaffIds;
    }

    public AddCustomSignConfigRequest setSignTermFiles(java.util.List<AddCustomSignConfigRequestSignTermFiles> signTermFiles) {
        this.signTermFiles = signTermFiles;
        return this;
    }
    public java.util.List<AddCustomSignConfigRequestSignTermFiles> getSignTermFiles() {
        return this.signTermFiles;
    }

    public AddCustomSignConfigRequest setTermMessage(String termMessage) {
        this.termMessage = termMessage;
        return this;
    }
    public String getTermMessage() {
        return this.termMessage;
    }

    public AddCustomSignConfigRequest setUnpushDeptIds(java.util.List<String> unpushDeptIds) {
        this.unpushDeptIds = unpushDeptIds;
        return this;
    }
    public java.util.List<String> getUnpushDeptIds() {
        return this.unpushDeptIds;
    }

    public AddCustomSignConfigRequest setUnpushStaffIds(java.util.List<String> unpushStaffIds) {
        this.unpushStaffIds = unpushStaffIds;
        return this;
    }
    public java.util.List<String> getUnpushStaffIds() {
        return this.unpushStaffIds;
    }

    public static class AddCustomSignConfigRequestSignTermFiles extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("mediaId")
        public String mediaId;

        public static AddCustomSignConfigRequestSignTermFiles build(java.util.Map<String, ?> map) throws Exception {
            AddCustomSignConfigRequestSignTermFiles self = new AddCustomSignConfigRequestSignTermFiles();
            return TeaModel.build(map, self);
        }

        public AddCustomSignConfigRequestSignTermFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public AddCustomSignConfigRequestSignTermFiles setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

    }

}
