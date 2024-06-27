// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdrive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 新建自定义空间
         *
         * @param request AddCustomSpaceRequest
         * @param headers AddCustomSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomSpaceResponse
         */
        public AddCustomSpaceResponse AddCustomSpaceWithOptions(AddCustomSpaceRequest request, AddCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionMode))
            {
                body["permissionMode"] = request.PermissionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/customSpaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新建自定义空间
         *
         * @param request AddCustomSpaceRequest
         * @param headers AddCustomSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomSpaceResponse
         */
        public async Task<AddCustomSpaceResponse> AddCustomSpaceWithOptionsAsync(AddCustomSpaceRequest request, AddCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionMode))
            {
                body["permissionMode"] = request.PermissionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/customSpaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新建自定义空间
         *
         * @param request AddCustomSpaceRequest
         * @return AddCustomSpaceResponse
         */
        public AddCustomSpaceResponse AddCustomSpace(AddCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
            return AddCustomSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建自定义空间
         *
         * @param request AddCustomSpaceRequest
         * @return AddCustomSpaceResponse
         */
        public async Task<AddCustomSpaceResponse> AddCustomSpaceAsync(AddCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
            return await AddCustomSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加文件
         *
         * @param request AddFileRequest
         * @param headers AddFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public AddFileResponse AddFileWithOptions(string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加文件
         *
         * @param request AddFileRequest
         * @param headers AddFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public async Task<AddFileResponse> AddFileWithOptionsAsync(string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加文件
         *
         * @param request AddFileRequest
         * @return AddFileResponse
         */
        public AddFileResponse AddFile(string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return AddFileWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 添加文件
         *
         * @param request AddFileRequest
         * @return AddFileResponse
         */
        public async Task<AddFileResponse> AddFileAsync(string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return await AddFileWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @param headers AddPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPermissionResponse
         */
        public AddPermissionResponse AddPermissionWithOptions(string spaceId, string fileId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddPermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @param headers AddPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPermissionResponse
         */
        public async Task<AddPermissionResponse> AddPermissionWithOptionsAsync(string spaceId, string fileId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @return AddPermissionResponse
         */
        public AddPermissionResponse AddPermission(string spaceId, string fileId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return AddPermissionWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @return AddPermissionResponse
         */
        public async Task<AddPermissionResponse> AddPermissionAsync(string spaceId, string fileId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return await AddPermissionWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 新建空间
         *
         * @param request AddSpaceRequest
         * @param headers AddSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSpaceResponse
         */
        public AddSpaceResponse AddSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新建空间
         *
         * @param request AddSpaceRequest
         * @param headers AddSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSpaceResponse
         */
        public async Task<AddSpaceResponse> AddSpaceWithOptionsAsync(AddSpaceRequest request, AddSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新建空间
         *
         * @param request AddSpaceRequest
         * @return AddSpaceResponse
         */
        public AddSpaceResponse AddSpace(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return AddSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建空间
         *
         * @param request AddSpaceRequest
         * @return AddSpaceResponse
         */
        public async Task<AddSpaceResponse> AddSpaceAsync(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return await AddSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 清空回收站文件
         *
         * @param request ClearRecycleFilesRequest
         * @param headers ClearRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRecycleFilesResponse
         */
        public ClearRecycleFilesResponse ClearRecycleFilesWithOptions(ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ClearRecycleFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 清空回收站文件
         *
         * @param request ClearRecycleFilesRequest
         * @param headers ClearRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRecycleFilesResponse
         */
        public async Task<ClearRecycleFilesResponse> ClearRecycleFilesWithOptionsAsync(ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ClearRecycleFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 清空回收站文件
         *
         * @param request ClearRecycleFilesRequest
         * @return ClearRecycleFilesResponse
         */
        public ClearRecycleFilesResponse ClearRecycleFiles(ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return ClearRecycleFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 清空回收站文件
         *
         * @param request ClearRecycleFilesRequest
         * @return ClearRecycleFilesResponse
         */
        public async Task<ClearRecycleFilesResponse> ClearRecycleFilesAsync(ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return await ClearRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 拷贝文件
         *
         * @param request CopyFileRequest
         * @param headers CopyFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyFileResponse
         */
        public CopyFileResponse CopyFileWithOptions(string spaceId, string fileId, CopyFileRequest request, CopyFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 拷贝文件
         *
         * @param request CopyFileRequest
         * @param headers CopyFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyFileResponse
         */
        public async Task<CopyFileResponse> CopyFileWithOptionsAsync(string spaceId, string fileId, CopyFileRequest request, CopyFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 拷贝文件
         *
         * @param request CopyFileRequest
         * @return CopyFileResponse
         */
        public CopyFileResponse CopyFile(string spaceId, string fileId, CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyFileHeaders headers = new CopyFileHeaders();
            return CopyFileWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 拷贝文件
         *
         * @param request CopyFileRequest
         * @return CopyFileResponse
         */
        public async Task<CopyFileResponse> CopyFileAsync(string spaceId, string fileId, CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyFileHeaders headers = new CopyFileHeaders();
            return await CopyFileWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 删除文件
         *
         * @param request DeleteFileRequest
         * @param headers DeleteFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFileWithOptions(string spaceId, string fileId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                query["deletePolicy"] = request.DeletePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除文件
         *
         * @param request DeleteFileRequest
         * @param headers DeleteFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string spaceId, string fileId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                query["deletePolicy"] = request.DeletePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除文件
         *
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFile(string spaceId, string fileId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return DeleteFileWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 删除文件
         *
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileAsync(string spaceId, string fileId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return await DeleteFileWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 批量删除文件（夹）
         *
         * @param request DeleteFilesRequest
         * @param headers DeleteFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFilesResponse
         */
        public DeleteFilesResponse DeleteFilesWithOptions(string spaceId, DeleteFilesRequest request, DeleteFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                body["deletePolicy"] = request.DeletePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量删除文件（夹）
         *
         * @param request DeleteFilesRequest
         * @param headers DeleteFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFilesResponse
         */
        public async Task<DeleteFilesResponse> DeleteFilesWithOptionsAsync(string spaceId, DeleteFilesRequest request, DeleteFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                body["deletePolicy"] = request.DeletePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量删除文件（夹）
         *
         * @param request DeleteFilesRequest
         * @return DeleteFilesResponse
         */
        public DeleteFilesResponse DeleteFiles(string spaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFilesHeaders headers = new DeleteFilesHeaders();
            return DeleteFilesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 批量删除文件（夹）
         *
         * @param request DeleteFilesRequest
         * @return DeleteFilesResponse
         */
        public async Task<DeleteFilesResponse> DeleteFilesAsync(string spaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFilesHeaders headers = new DeleteFilesHeaders();
            return await DeleteFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @param headers DeletePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePermissionResponse
         */
        public DeletePermissionResponse DeletePermissionWithOptions(string spaceId, string fileId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @param headers DeletePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePermissionResponse
         */
        public async Task<DeletePermissionResponse> DeletePermissionWithOptionsAsync(string spaceId, string fileId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @return DeletePermissionResponse
         */
        public DeletePermissionResponse DeletePermission(string spaceId, string fileId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return DeletePermissionWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @return DeletePermissionResponse
         */
        public async Task<DeletePermissionResponse> DeletePermissionAsync(string spaceId, string fileId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return await DeletePermissionWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 彻底删除回收站文件
         *
         * @param request DeleteRecycleFilesRequest
         * @param headers DeleteRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRecycleFilesResponse
         */
        public DeleteRecycleFilesResponse DeleteRecycleFilesWithOptions(DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIdList))
            {
                body["recycleItemIdList"] = request.RecycleItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 彻底删除回收站文件
         *
         * @param request DeleteRecycleFilesRequest
         * @param headers DeleteRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRecycleFilesResponse
         */
        public async Task<DeleteRecycleFilesResponse> DeleteRecycleFilesWithOptionsAsync(DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIdList))
            {
                body["recycleItemIdList"] = request.RecycleItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 彻底删除回收站文件
         *
         * @param request DeleteRecycleFilesRequest
         * @return DeleteRecycleFilesResponse
         */
        public DeleteRecycleFilesResponse DeleteRecycleFiles(DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return DeleteRecycleFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 彻底删除回收站文件
         *
         * @param request DeleteRecycleFilesRequest
         * @return DeleteRecycleFilesResponse
         */
        public async Task<DeleteRecycleFilesResponse> DeleteRecycleFilesAsync(DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return await DeleteRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除空间
         *
         * @param request DeleteSpaceRequest
         * @param headers DeleteSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSpaceResponse
         */
        public DeleteSpaceResponse DeleteSpaceWithOptions(string spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除空间
         *
         * @param request DeleteSpaceRequest
         * @param headers DeleteSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSpaceResponse
         */
        public async Task<DeleteSpaceResponse> DeleteSpaceWithOptionsAsync(string spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除空间
         *
         * @param request DeleteSpaceRequest
         * @return DeleteSpaceResponse
         */
        public DeleteSpaceResponse DeleteSpace(string spaceId, DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return DeleteSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 删除空间
         *
         * @param request DeleteSpaceRequest
         * @return DeleteSpaceResponse
         */
        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(string spaceId, DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return await DeleteSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取异步任务信息
         *
         * @param request GetAsyncTaskInfoRequest
         * @param headers GetAsyncTaskInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskInfoResponse
         */
        public GetAsyncTaskInfoResponse GetAsyncTaskInfoWithOptions(string taskId, GetAsyncTaskInfoRequest request, GetAsyncTaskInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTaskInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务信息
         *
         * @param request GetAsyncTaskInfoRequest
         * @param headers GetAsyncTaskInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskInfoResponse
         */
        public async Task<GetAsyncTaskInfoResponse> GetAsyncTaskInfoWithOptionsAsync(string taskId, GetAsyncTaskInfoRequest request, GetAsyncTaskInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTaskInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务信息
         *
         * @param request GetAsyncTaskInfoRequest
         * @return GetAsyncTaskInfoResponse
         */
        public GetAsyncTaskInfoResponse GetAsyncTaskInfo(string taskId, GetAsyncTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAsyncTaskInfoHeaders headers = new GetAsyncTaskInfoHeaders();
            return GetAsyncTaskInfoWithOptions(taskId, request, headers, runtime);
        }

        /**
         * @summary 获取异步任务信息
         *
         * @param request GetAsyncTaskInfoRequest
         * @return GetAsyncTaskInfoResponse
         */
        public async Task<GetAsyncTaskInfoResponse> GetAsyncTaskInfoAsync(string taskId, GetAsyncTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAsyncTaskInfoHeaders headers = new GetAsyncTaskInfoHeaders();
            return await GetAsyncTaskInfoWithOptionsAsync(taskId, request, headers, runtime);
        }

        /**
         * @summary 获取下载信息
         *
         * @param request GetDownloadInfoRequest
         * @param headers GetDownloadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadInfoResponse
         */
        public GetDownloadInfoResponse GetDownloadInfoWithOptions(string spaceId, string fileId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInternalResourceUrl))
            {
                query["withInternalResourceUrl"] = request.WithInternalResourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithRegion))
            {
                query["withRegion"] = request.WithRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取下载信息
         *
         * @param request GetDownloadInfoRequest
         * @param headers GetDownloadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadInfoResponse
         */
        public async Task<GetDownloadInfoResponse> GetDownloadInfoWithOptionsAsync(string spaceId, string fileId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInternalResourceUrl))
            {
                query["withInternalResourceUrl"] = request.WithInternalResourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithRegion))
            {
                query["withRegion"] = request.WithRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取下载信息
         *
         * @param request GetDownloadInfoRequest
         * @return GetDownloadInfoResponse
         */
        public GetDownloadInfoResponse GetDownloadInfo(string spaceId, string fileId, GetDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return GetDownloadInfoWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取下载信息
         *
         * @param request GetDownloadInfoRequest
         * @return GetDownloadInfoResponse
         */
        public async Task<GetDownloadInfoResponse> GetDownloadInfoAsync(string spaceId, string fileId, GetDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return await GetDownloadInfoWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取文件信息
         *
         * @param request GetFileInfoRequest
         * @param headers GetFileInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileInfoResponse
         */
        public GetFileInfoResponse GetFileInfoWithOptions(string spaceId, string fileId, GetFileInfoRequest request, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取文件信息
         *
         * @param request GetFileInfoRequest
         * @param headers GetFileInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileInfoResponse
         */
        public async Task<GetFileInfoResponse> GetFileInfoWithOptionsAsync(string spaceId, string fileId, GetFileInfoRequest request, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文件信息
         *
         * @param request GetFileInfoRequest
         * @return GetFileInfoResponse
         */
        public GetFileInfoResponse GetFileInfo(string spaceId, string fileId, GetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return GetFileInfoWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取文件信息
         *
         * @param request GetFileInfoRequest
         * @return GetFileInfoResponse
         */
        public async Task<GetFileInfoResponse> GetFileInfoAsync(string spaceId, string fileId, GetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return await GetFileInfoWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取我的工作空间信息
         *
         * @param request GetMySpaceInfoRequest
         * @param headers GetMySpaceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMySpaceInfoResponse
         */
        public GetMySpaceInfoResponse GetMySpaceInfoWithOptions(GetMySpaceInfoRequest request, GetMySpaceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySpaceInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/mySpaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySpaceInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取我的工作空间信息
         *
         * @param request GetMySpaceInfoRequest
         * @param headers GetMySpaceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMySpaceInfoResponse
         */
        public async Task<GetMySpaceInfoResponse> GetMySpaceInfoWithOptionsAsync(GetMySpaceInfoRequest request, GetMySpaceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySpaceInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/mySpaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySpaceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取我的工作空间信息
         *
         * @param request GetMySpaceInfoRequest
         * @return GetMySpaceInfoResponse
         */
        public GetMySpaceInfoResponse GetMySpaceInfo(GetMySpaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMySpaceInfoHeaders headers = new GetMySpaceInfoHeaders();
            return GetMySpaceInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取我的工作空间信息
         *
         * @param request GetMySpaceInfoRequest
         * @return GetMySpaceInfoResponse
         */
        public async Task<GetMySpaceInfoResponse> GetMySpaceInfoAsync(GetMySpaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMySpaceInfoHeaders headers = new GetMySpaceInfoHeaders();
            return await GetMySpaceInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取预览信息
         *
         * @param request GetPreviewInfoRequest
         * @param headers GetPreviewInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPreviewInfoResponse
         */
        public GetPreviewInfoResponse GetPreviewInfoWithOptions(string spaceId, string fileId, GetPreviewInfoRequest request, GetPreviewInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["watermark"] = request.Watermark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreviewInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/previewInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreviewInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取预览信息
         *
         * @param request GetPreviewInfoRequest
         * @param headers GetPreviewInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPreviewInfoResponse
         */
        public async Task<GetPreviewInfoResponse> GetPreviewInfoWithOptionsAsync(string spaceId, string fileId, GetPreviewInfoRequest request, GetPreviewInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["watermark"] = request.Watermark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreviewInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/previewInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreviewInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取预览信息
         *
         * @param request GetPreviewInfoRequest
         * @return GetPreviewInfoResponse
         */
        public GetPreviewInfoResponse GetPreviewInfo(string spaceId, string fileId, GetPreviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPreviewInfoHeaders headers = new GetPreviewInfoHeaders();
            return GetPreviewInfoWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取预览信息
         *
         * @param request GetPreviewInfoRequest
         * @return GetPreviewInfoResponse
         */
        public async Task<GetPreviewInfoResponse> GetPreviewInfoAsync(string spaceId, string fileId, GetPreviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPreviewInfoHeaders headers = new GetPreviewInfoHeaders();
            return await GetPreviewInfoWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取权限点信息
         *
         * @param request GetPrivilegeInfoRequest
         * @param headers GetPrivilegeInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivilegeInfoResponse
         */
        public GetPrivilegeInfoResponse GetPrivilegeInfoWithOptions(string spaceId, string fileId, GetPrivilegeInfoRequest request, GetPrivilegeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivilegeInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/privileges",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivilegeInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取权限点信息
         *
         * @param request GetPrivilegeInfoRequest
         * @param headers GetPrivilegeInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivilegeInfoResponse
         */
        public async Task<GetPrivilegeInfoResponse> GetPrivilegeInfoWithOptionsAsync(string spaceId, string fileId, GetPrivilegeInfoRequest request, GetPrivilegeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivilegeInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/privileges",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivilegeInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取权限点信息
         *
         * @param request GetPrivilegeInfoRequest
         * @return GetPrivilegeInfoResponse
         */
        public GetPrivilegeInfoResponse GetPrivilegeInfo(string spaceId, string fileId, GetPrivilegeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrivilegeInfoHeaders headers = new GetPrivilegeInfoHeaders();
            return GetPrivilegeInfoWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取权限点信息
         *
         * @param request GetPrivilegeInfoRequest
         * @return GetPrivilegeInfoResponse
         */
        public async Task<GetPrivilegeInfoResponse> GetPrivilegeInfoAsync(string spaceId, string fileId, GetPrivilegeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrivilegeInfoHeaders headers = new GetPrivilegeInfoHeaders();
            return await GetPrivilegeInfoWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取容量信息列表
         *
         * @param request GetQuotaInfosRequest
         * @param headers GetQuotaInfosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaInfosResponse
         */
        public GetQuotaInfosResponse GetQuotaInfosWithOptions(GetQuotaInfosRequest request, GetQuotaInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifiers))
            {
                body["identifiers"] = request.Identifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaInfos",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/quotaInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaInfosResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取容量信息列表
         *
         * @param request GetQuotaInfosRequest
         * @param headers GetQuotaInfosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaInfosResponse
         */
        public async Task<GetQuotaInfosResponse> GetQuotaInfosWithOptionsAsync(GetQuotaInfosRequest request, GetQuotaInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifiers))
            {
                body["identifiers"] = request.Identifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaInfos",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/quotaInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaInfosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取容量信息列表
         *
         * @param request GetQuotaInfosRequest
         * @return GetQuotaInfosResponse
         */
        public GetQuotaInfosResponse GetQuotaInfos(GetQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQuotaInfosHeaders headers = new GetQuotaInfosHeaders();
            return GetQuotaInfosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取容量信息列表
         *
         * @param request GetQuotaInfosRequest
         * @return GetQuotaInfosResponse
         */
        public async Task<GetQuotaInfosResponse> GetQuotaInfosAsync(GetQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQuotaInfosHeaders headers = new GetQuotaInfosHeaders();
            return await GetQuotaInfosWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取上传信息
         *
         * @param request GetUploadInfoRequest
         * @param headers GetUploadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadInfoResponse
         */
        public GetUploadInfoResponse GetUploadInfoWithOptions(string spaceId, string parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerRegion))
            {
                query["callerRegion"] = request.CallerRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInternalEndPoint))
            {
                query["withInternalEndPoint"] = request.WithInternalEndPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithRegion))
            {
                query["withRegion"] = request.WithRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取上传信息
         *
         * @param request GetUploadInfoRequest
         * @param headers GetUploadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadInfoResponse
         */
        public async Task<GetUploadInfoResponse> GetUploadInfoWithOptionsAsync(string spaceId, string parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerRegion))
            {
                query["callerRegion"] = request.CallerRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInternalEndPoint))
            {
                query["withInternalEndPoint"] = request.WithInternalEndPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithRegion))
            {
                query["withRegion"] = request.WithRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadInfo",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取上传信息
         *
         * @param request GetUploadInfoRequest
         * @return GetUploadInfoResponse
         */
        public GetUploadInfoResponse GetUploadInfo(string spaceId, string parentId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return GetUploadInfoWithOptions(spaceId, parentId, request, headers, runtime);
        }

        /**
         * @summary 获取上传信息
         *
         * @param request GetUploadInfoRequest
         * @return GetUploadInfoResponse
         */
        public async Task<GetUploadInfoResponse> GetUploadInfoAsync(string spaceId, string parentId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return await GetUploadInfoWithOptionsAsync(spaceId, parentId, request, headers, runtime);
        }

        /**
         * @summary 添加自定义空间权限
         *
         * @param request GrantPrivilegeOfCustomSpaceRequest
         * @param headers GrantPrivilegeOfCustomSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPrivilegeOfCustomSpaceResponse
         */
        public GrantPrivilegeOfCustomSpaceResponse GrantPrivilegeOfCustomSpaceWithOptions(string spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPrivilegeOfCustomSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPrivilegeOfCustomSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加自定义空间权限
         *
         * @param request GrantPrivilegeOfCustomSpaceRequest
         * @param headers GrantPrivilegeOfCustomSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPrivilegeOfCustomSpaceResponse
         */
        public async Task<GrantPrivilegeOfCustomSpaceResponse> GrantPrivilegeOfCustomSpaceWithOptionsAsync(string spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPrivilegeOfCustomSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPrivilegeOfCustomSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加自定义空间权限
         *
         * @param request GrantPrivilegeOfCustomSpaceRequest
         * @return GrantPrivilegeOfCustomSpaceResponse
         */
        public GrantPrivilegeOfCustomSpaceResponse GrantPrivilegeOfCustomSpace(string spaceId, GrantPrivilegeOfCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
            return GrantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 添加自定义空间权限
         *
         * @param request GrantPrivilegeOfCustomSpaceRequest
         * @return GrantPrivilegeOfCustomSpaceResponse
         */
        public async Task<GrantPrivilegeOfCustomSpaceResponse> GrantPrivilegeOfCustomSpaceAsync(string spaceId, GrantPrivilegeOfCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
            return await GrantPrivilegeOfCustomSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取空间信息
         *
         * @param request InfoSpaceRequest
         * @param headers InfoSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InfoSpaceResponse
         */
        public InfoSpaceResponse InfoSpaceWithOptions(string spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InfoSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InfoSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取空间信息
         *
         * @param request InfoSpaceRequest
         * @param headers InfoSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InfoSpaceResponse
         */
        public async Task<InfoSpaceResponse> InfoSpaceWithOptionsAsync(string spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InfoSpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InfoSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取空间信息
         *
         * @param request InfoSpaceRequest
         * @return InfoSpaceResponse
         */
        public InfoSpaceResponse InfoSpace(string spaceId, InfoSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InfoSpaceHeaders headers = new InfoSpaceHeaders();
            return InfoSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取空间信息
         *
         * @param request InfoSpaceRequest
         * @return InfoSpaceResponse
         */
        public async Task<InfoSpaceResponse> InfoSpaceAsync(string spaceId, InfoSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InfoSpaceHeaders headers = new InfoSpaceHeaders();
            return await InfoSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文件列表
         *
         * @param request ListFilesRequest
         * @param headers ListFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFilesResponse
         */
        public ListFilesResponse ListFilesWithOptions(string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIcon))
            {
                query["withIcon"] = request.WithIcon;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取文件列表
         *
         * @param request ListFilesRequest
         * @param headers ListFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFilesResponse
         */
        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIcon))
            {
                query["withIcon"] = request.WithIcon;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文件列表
         *
         * @param request ListFilesRequest
         * @return ListFilesResponse
         */
        public ListFilesResponse ListFiles(string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return ListFilesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文件列表
         *
         * @param request ListFilesRequest
         * @return ListFilesResponse
         */
        public async Task<ListFilesResponse> ListFilesAsync(string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return await ListFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @param headers ListPermissionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPermissionsResponse
         */
        public ListPermissionsResponse ListPermissionsWithOptions(string spaceId, string fileId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @param headers ListPermissionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPermissionsResponse
         */
        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string spaceId, string fileId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @return ListPermissionsResponse
         */
        public ListPermissionsResponse ListPermissions(string spaceId, string fileId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return ListPermissionsWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @return ListPermissionsResponse
         */
        public async Task<ListPermissionsResponse> ListPermissionsAsync(string spaceId, string fileId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return await ListPermissionsWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 获取回收站文件列表
         *
         * @param request ListRecycleFilesRequest
         * @param headers ListRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycleFilesResponse
         */
        public ListRecycleFilesResponse ListRecycleFilesWithOptions(ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                query["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取回收站文件列表
         *
         * @param request ListRecycleFilesRequest
         * @param headers ListRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycleFilesResponse
         */
        public async Task<ListRecycleFilesResponse> ListRecycleFilesWithOptionsAsync(ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                query["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取回收站文件列表
         *
         * @param request ListRecycleFilesRequest
         * @return ListRecycleFilesResponse
         */
        public ListRecycleFilesResponse ListRecycleFiles(ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return ListRecycleFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取回收站文件列表
         *
         * @param request ListRecycleFilesRequest
         * @return ListRecycleFilesResponse
         */
        public async Task<ListRecycleFilesResponse> ListRecycleFilesAsync(ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return await ListRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取空间列表
         *
         * @param request ListSpacesRequest
         * @param headers ListSpacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSpacesResponse
         */
        public ListSpacesResponse ListSpacesWithOptions(ListSpacesRequest request, ListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSpaces",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpacesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取空间列表
         *
         * @param request ListSpacesRequest
         * @param headers ListSpacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSpacesResponse
         */
        public async Task<ListSpacesResponse> ListSpacesWithOptionsAsync(ListSpacesRequest request, ListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSpaces",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取空间列表
         *
         * @param request ListSpacesRequest
         * @return ListSpacesResponse
         */
        public ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return ListSpacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取空间列表
         *
         * @param request ListSpacesRequest
         * @return ListSpacesResponse
         */
        public async Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return await ListSpacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 管理侧购买容量
         *
         * @param request ManagementBuyQuotaRequest
         * @param headers ManagementBuyQuotaHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementBuyQuotaResponse
         */
        public ManagementBuyQuotaResponse ManagementBuyQuotaWithOptions(ManagementBuyQuotaRequest request, ManagementBuyQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementBuyQuota",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/quotas/buy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ManagementBuyQuotaResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 管理侧购买容量
         *
         * @param request ManagementBuyQuotaRequest
         * @param headers ManagementBuyQuotaHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementBuyQuotaResponse
         */
        public async Task<ManagementBuyQuotaResponse> ManagementBuyQuotaWithOptionsAsync(ManagementBuyQuotaRequest request, ManagementBuyQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementBuyQuota",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/quotas/buy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ManagementBuyQuotaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 管理侧购买容量
         *
         * @param request ManagementBuyQuotaRequest
         * @return ManagementBuyQuotaResponse
         */
        public ManagementBuyQuotaResponse ManagementBuyQuota(ManagementBuyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementBuyQuotaHeaders headers = new ManagementBuyQuotaHeaders();
            return ManagementBuyQuotaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 管理侧购买容量
         *
         * @param request ManagementBuyQuotaRequest
         * @return ManagementBuyQuotaResponse
         */
        public async Task<ManagementBuyQuotaResponse> ManagementBuyQuotaAsync(ManagementBuyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementBuyQuotaHeaders headers = new ManagementBuyQuotaHeaders();
            return await ManagementBuyQuotaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 管理侧获取空间列表
         *
         * @param request ManagementListSpacesRequest
         * @param headers ManagementListSpacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementListSpacesResponse
         */
        public ManagementListSpacesResponse ManagementListSpacesWithOptions(ManagementListSpacesRequest request, ManagementListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIds))
            {
                body["spaceIds"] = request.SpaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementListSpaces",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagementListSpacesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 管理侧获取空间列表
         *
         * @param request ManagementListSpacesRequest
         * @param headers ManagementListSpacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementListSpacesResponse
         */
        public async Task<ManagementListSpacesResponse> ManagementListSpacesWithOptionsAsync(ManagementListSpacesRequest request, ManagementListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIds))
            {
                body["spaceIds"] = request.SpaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementListSpaces",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagementListSpacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 管理侧获取空间列表
         *
         * @param request ManagementListSpacesRequest
         * @return ManagementListSpacesResponse
         */
        public ManagementListSpacesResponse ManagementListSpaces(ManagementListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementListSpacesHeaders headers = new ManagementListSpacesHeaders();
            return ManagementListSpacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 管理侧获取空间列表
         *
         * @param request ManagementListSpacesRequest
         * @return ManagementListSpacesResponse
         */
        public async Task<ManagementListSpacesResponse> ManagementListSpacesAsync(ManagementListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementListSpacesHeaders headers = new ManagementListSpacesHeaders();
            return await ManagementListSpacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 管理侧修改空间信息
         *
         * @param request ManagementModifySpaceRequest
         * @param headers ManagementModifySpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementModifySpaceResponse
         */
        public ManagementModifySpaceResponse ManagementModifySpaceWithOptions(ManagementModifySpaceRequest request, ManagementModifySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIds))
            {
                body["spaceIds"] = request.SpaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementModifySpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagementModifySpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 管理侧修改空间信息
         *
         * @param request ManagementModifySpaceRequest
         * @param headers ManagementModifySpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagementModifySpaceResponse
         */
        public async Task<ManagementModifySpaceResponse> ManagementModifySpaceWithOptionsAsync(ManagementModifySpaceRequest request, ManagementModifySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIds))
            {
                body["spaceIds"] = request.SpaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagementModifySpace",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/managements/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagementModifySpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 管理侧修改空间信息
         *
         * @param request ManagementModifySpaceRequest
         * @return ManagementModifySpaceResponse
         */
        public ManagementModifySpaceResponse ManagementModifySpace(ManagementModifySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementModifySpaceHeaders headers = new ManagementModifySpaceHeaders();
            return ManagementModifySpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 管理侧修改空间信息
         *
         * @param request ManagementModifySpaceRequest
         * @return ManagementModifySpaceResponse
         */
        public async Task<ManagementModifySpaceResponse> ManagementModifySpaceAsync(ManagementModifySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementModifySpaceHeaders headers = new ManagementModifySpaceHeaders();
            return await ManagementModifySpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改权限
         *
         * @param request ModifyPermissionRequest
         * @param headers ModifyPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPermissionResponse
         */
        public ModifyPermissionResponse ModifyPermissionWithOptions(string spaceId, string fileId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyPermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改权限
         *
         * @param request ModifyPermissionRequest
         * @param headers ModifyPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPermissionResponse
         */
        public async Task<ModifyPermissionResponse> ModifyPermissionWithOptionsAsync(string spaceId, string fileId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPermission",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改权限
         *
         * @param request ModifyPermissionRequest
         * @return ModifyPermissionResponse
         */
        public ModifyPermissionResponse ModifyPermission(string spaceId, string fileId, ModifyPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
            return ModifyPermissionWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 修改权限
         *
         * @param request ModifyPermissionRequest
         * @return ModifyPermissionResponse
         */
        public async Task<ModifyPermissionResponse> ModifyPermissionAsync(string spaceId, string fileId, ModifyPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
            return await ModifyPermissionWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 移动文件
         *
         * @param request MoveFileRequest
         * @param headers MoveFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFileResponse
         */
        public MoveFileResponse MoveFileWithOptions(string spaceId, string fileId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移动文件
         *
         * @param request MoveFileRequest
         * @param headers MoveFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFileResponse
         */
        public async Task<MoveFileResponse> MoveFileWithOptionsAsync(string spaceId, string fileId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移动文件
         *
         * @param request MoveFileRequest
         * @return MoveFileResponse
         */
        public MoveFileResponse MoveFile(string spaceId, string fileId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return MoveFileWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 移动文件
         *
         * @param request MoveFileRequest
         * @return MoveFileResponse
         */
        public async Task<MoveFileResponse> MoveFileAsync(string spaceId, string fileId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return await MoveFileWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 批量移动文件（夹）
         *
         * @param request MoveFilesRequest
         * @param headers MoveFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFilesResponse
         */
        public MoveFilesResponse MoveFilesWithOptions(string spaceId, MoveFilesRequest request, MoveFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/batchMove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量移动文件（夹）
         *
         * @param request MoveFilesRequest
         * @param headers MoveFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFilesResponse
         */
        public async Task<MoveFilesResponse> MoveFilesWithOptionsAsync(string spaceId, MoveFilesRequest request, MoveFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIds))
            {
                body["fileIds"] = request.FileIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/batchMove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量移动文件（夹）
         *
         * @param request MoveFilesRequest
         * @return MoveFilesResponse
         */
        public MoveFilesResponse MoveFiles(string spaceId, MoveFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFilesHeaders headers = new MoveFilesHeaders();
            return MoveFilesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 批量移动文件（夹）
         *
         * @param request MoveFilesRequest
         * @return MoveFilesResponse
         */
        public async Task<MoveFilesResponse> MoveFilesAsync(string spaceId, MoveFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFilesHeaders headers = new MoveFilesHeaders();
            return await MoveFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 还原回收站文件
         *
         * @param request RecoverRecycleFilesRequest
         * @param headers RecoverRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoverRecycleFilesResponse
         */
        public RecoverRecycleFilesResponse RecoverRecycleFilesWithOptions(RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIdList))
            {
                body["recycleItemIdList"] = request.RecycleItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/recover",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 还原回收站文件
         *
         * @param request RecoverRecycleFilesRequest
         * @param headers RecoverRecycleFilesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoverRecycleFilesResponse
         */
        public async Task<RecoverRecycleFilesResponse> RecoverRecycleFilesWithOptionsAsync(RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIdList))
            {
                body["recycleItemIdList"] = request.RecycleItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverRecycleFiles",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/recycleItems/recover",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 还原回收站文件
         *
         * @param request RecoverRecycleFilesRequest
         * @return RecoverRecycleFilesResponse
         */
        public RecoverRecycleFilesResponse RecoverRecycleFiles(RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return RecoverRecycleFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 还原回收站文件
         *
         * @param request RecoverRecycleFilesRequest
         * @return RecoverRecycleFilesResponse
         */
        public async Task<RecoverRecycleFilesResponse> RecoverRecycleFilesAsync(RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return await RecoverRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 重命名文件
         *
         * @param request RenameFileRequest
         * @param headers RenameFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameFileResponse
         */
        public RenameFileResponse RenameFileWithOptions(string spaceId, string fileId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFileName))
            {
                body["newFileName"] = request.NewFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 重命名文件
         *
         * @param request RenameFileRequest
         * @param headers RenameFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameFileResponse
         */
        public async Task<RenameFileResponse> RenameFileWithOptionsAsync(string spaceId, string fileId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFileName))
            {
                body["newFileName"] = request.NewFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameFile",
                Version = "drive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 重命名文件
         *
         * @param request RenameFileRequest
         * @return RenameFileResponse
         */
        public RenameFileResponse RenameFile(string spaceId, string fileId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return RenameFileWithOptions(spaceId, fileId, request, headers, runtime);
        }

        /**
         * @summary 重命名文件
         *
         * @param request RenameFileRequest
         * @return RenameFileResponse
         */
        public async Task<RenameFileResponse> RenameFileAsync(string spaceId, string fileId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return await RenameFileWithOptionsAsync(spaceId, fileId, request, headers, runtime);
        }

    }
}
