// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectStatusListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetProjectStatusListResponseBodyResult> result;

    public static GetProjectStatusListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectStatusListResponseBody self = new GetProjectStatusListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectStatusListResponseBody setResult(java.util.List<GetProjectStatusListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectStatusListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectStatusListResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>进度正常，详细说明</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>0715153011xxxxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>normal</p>
         */
        @NameInMap("degree")
        public String degree;

        /**
         * <strong>example:</strong>
         * <p>进度正常</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>62c25e3b376ecxxxxxxx</p>
         */
        @NameInMap("projectId")
        public String projectId;

        public static GetProjectStatusListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectStatusListResponseBodyResult self = new GetProjectStatusListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectStatusListResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetProjectStatusListResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetProjectStatusListResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetProjectStatusListResponseBodyResult setDegree(String degree) {
            this.degree = degree;
            return this;
        }
        public String getDegree() {
            return this.degree;
        }

        public GetProjectStatusListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProjectStatusListResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

    }

}
