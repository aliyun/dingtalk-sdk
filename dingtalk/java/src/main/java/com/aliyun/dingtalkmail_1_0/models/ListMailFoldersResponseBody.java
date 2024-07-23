// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class ListMailFoldersResponseBody extends TeaModel {
    @NameInMap("folders")
    public java.util.List<ListMailFoldersResponseBodyFolders> folders;

    public static ListMailFoldersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMailFoldersResponseBody self = new ListMailFoldersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMailFoldersResponseBody setFolders(java.util.List<ListMailFoldersResponseBodyFolders> folders) {
        this.folders = folders;
        return this;
    }
    public java.util.List<ListMailFoldersResponseBodyFolders> getFolders() {
        return this.folders;
    }

    public static class ListMailFoldersResponseBodyFolders extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("childFolderCount")
        public Integer childFolderCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("extensions")
        public java.util.Map<String, String> extensions;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("parentFolderId")
        public String parentFolderId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("totalItemCount")
        public Integer totalItemCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unreadItemCount")
        public Integer unreadItemCount;

        public static ListMailFoldersResponseBodyFolders build(java.util.Map<String, ?> map) throws Exception {
            ListMailFoldersResponseBodyFolders self = new ListMailFoldersResponseBodyFolders();
            return TeaModel.build(map, self);
        }

        public ListMailFoldersResponseBodyFolders setChildFolderCount(Integer childFolderCount) {
            this.childFolderCount = childFolderCount;
            return this;
        }
        public Integer getChildFolderCount() {
            return this.childFolderCount;
        }

        public ListMailFoldersResponseBodyFolders setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListMailFoldersResponseBodyFolders setExtensions(java.util.Map<String, String> extensions) {
            this.extensions = extensions;
            return this;
        }
        public java.util.Map<String, String> getExtensions() {
            return this.extensions;
        }

        public ListMailFoldersResponseBodyFolders setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListMailFoldersResponseBodyFolders setParentFolderId(String parentFolderId) {
            this.parentFolderId = parentFolderId;
            return this;
        }
        public String getParentFolderId() {
            return this.parentFolderId;
        }

        public ListMailFoldersResponseBodyFolders setTotalItemCount(Integer totalItemCount) {
            this.totalItemCount = totalItemCount;
            return this;
        }
        public Integer getTotalItemCount() {
            return this.totalItemCount;
        }

        public ListMailFoldersResponseBodyFolders setUnreadItemCount(Integer unreadItemCount) {
            this.unreadItemCount = unreadItemCount;
            return this;
        }
        public Integer getUnreadItemCount() {
            return this.unreadItemCount;
        }

    }

}
