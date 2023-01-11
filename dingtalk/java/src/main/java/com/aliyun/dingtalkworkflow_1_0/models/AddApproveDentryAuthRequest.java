// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddApproveDentryAuthRequest extends TeaModel {
    /**
     * <p>授权的钉盘文件信息列表。支持批量授权，最大列表长度：10。</p>
     */
    @NameInMap("fileInfos")
    public java.util.List<AddApproveDentryAuthRequestFileInfos> fileInfos;

    /**
     * <p>授权的用户userid。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddApproveDentryAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        AddApproveDentryAuthRequest self = new AddApproveDentryAuthRequest();
        return TeaModel.build(map, self);
    }

    public AddApproveDentryAuthRequest setFileInfos(java.util.List<AddApproveDentryAuthRequestFileInfos> fileInfos) {
        this.fileInfos = fileInfos;
        return this;
    }
    public java.util.List<AddApproveDentryAuthRequestFileInfos> getFileInfos() {
        return this.fileInfos;
    }

    public AddApproveDentryAuthRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AddApproveDentryAuthRequestFileInfos extends TeaModel {
        /**
         * <p>文件ID。</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>钉盘空间spaceId。</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static AddApproveDentryAuthRequestFileInfos build(java.util.Map<String, ?> map) throws Exception {
            AddApproveDentryAuthRequestFileInfos self = new AddApproveDentryAuthRequestFileInfos();
            return TeaModel.build(map, self);
        }

        public AddApproveDentryAuthRequestFileInfos setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public AddApproveDentryAuthRequestFileInfos setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
