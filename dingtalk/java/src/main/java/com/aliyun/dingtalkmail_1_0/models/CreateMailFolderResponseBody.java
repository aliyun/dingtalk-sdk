// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateMailFolderResponseBody extends TeaModel {
    @NameInMap("folder")
    public CreateMailFolderResponseBodyFolder folder;

    @NameInMap("requestId")
    public String requestId;

    public static CreateMailFolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMailFolderResponseBody self = new CreateMailFolderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMailFolderResponseBody setFolder(CreateMailFolderResponseBodyFolder folder) {
        this.folder = folder;
        return this;
    }
    public CreateMailFolderResponseBodyFolder getFolder() {
        return this.folder;
    }

    public CreateMailFolderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class CreateMailFolderResponseBodyFolder extends TeaModel {
        @NameInMap("childFolderCount")
        public Integer childFolderCount;

        @NameInMap("displayName")
        public String displayName;

        @NameInMap("extensions")
        public java.util.Map<String, ?> extensions;

        @NameInMap("id")
        public String id;

        @NameInMap("parentFolderId")
        public String parentFolderId;

        @NameInMap("totalItemCount")
        public Integer totalItemCount;

        @NameInMap("unreadItemCount")
        public Integer unreadItemCount;

        public static CreateMailFolderResponseBodyFolder build(java.util.Map<String, ?> map) throws Exception {
            CreateMailFolderResponseBodyFolder self = new CreateMailFolderResponseBodyFolder();
            return TeaModel.build(map, self);
        }

        public CreateMailFolderResponseBodyFolder setChildFolderCount(Integer childFolderCount) {
            this.childFolderCount = childFolderCount;
            return this;
        }
        public Integer getChildFolderCount() {
            return this.childFolderCount;
        }

        public CreateMailFolderResponseBodyFolder setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateMailFolderResponseBodyFolder setExtensions(java.util.Map<String, ?> extensions) {
            this.extensions = extensions;
            return this;
        }
        public java.util.Map<String, ?> getExtensions() {
            return this.extensions;
        }

        public CreateMailFolderResponseBodyFolder setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateMailFolderResponseBodyFolder setParentFolderId(String parentFolderId) {
            this.parentFolderId = parentFolderId;
            return this;
        }
        public String getParentFolderId() {
            return this.parentFolderId;
        }

        public CreateMailFolderResponseBodyFolder setTotalItemCount(Integer totalItemCount) {
            this.totalItemCount = totalItemCount;
            return this;
        }
        public Integer getTotalItemCount() {
            return this.totalItemCount;
        }

        public CreateMailFolderResponseBodyFolder setUnreadItemCount(Integer unreadItemCount) {
            this.unreadItemCount = unreadItemCount;
            return this;
        }
        public Integer getUnreadItemCount() {
            return this.unreadItemCount;
        }

    }

}
