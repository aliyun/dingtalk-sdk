// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkstorage_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0
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
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @param headers AddPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPermissionResponse
         */
        public AddPermissionResponse AddPermissionWithOptions(string dentryUuid, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
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
        public async Task<AddPermissionResponse> AddPermissionWithOptionsAsync(string dentryUuid, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @return AddPermissionResponse
         */
        public AddPermissionResponse AddPermission(string dentryUuid, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return AddPermissionWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 添加权限
         *
         * @param request AddPermissionRequest
         * @return AddPermissionResponse
         */
        public async Task<AddPermissionResponse> AddPermissionAsync(string dentryUuid, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return await AddPermissionWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 提交文件
         *
         * @param request CommitFileRequest
         * @param headers CommitFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitFileResponse
         */
        public CommitFileResponse CommitFileWithOptions(string parentDentryUuid, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadKey))
            {
                body["uploadKey"] = request.UploadKey;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFile",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/files/" + parentDentryUuid + "/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 提交文件
         *
         * @param request CommitFileRequest
         * @param headers CommitFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitFileResponse
         */
        public async Task<CommitFileResponse> CommitFileWithOptionsAsync(string parentDentryUuid, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadKey))
            {
                body["uploadKey"] = request.UploadKey;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFile",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/files/" + parentDentryUuid + "/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 提交文件
         *
         * @param request CommitFileRequest
         * @return CommitFileResponse
         */
        public CommitFileResponse CommitFile(string parentDentryUuid, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return CommitFileWithOptions(parentDentryUuid, request, headers, runtime);
        }

        /**
         * @summary 提交文件
         *
         * @param request CommitFileRequest
         * @return CommitFileResponse
         */
        public async Task<CommitFileResponse> CommitFileAsync(string parentDentryUuid, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return await CommitFileWithOptionsAsync(parentDentryUuid, request, headers, runtime);
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @param headers DeletePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePermissionResponse
         */
        public DeletePermissionResponse DeletePermissionWithOptions(string dentryUuid, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
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
        public async Task<DeletePermissionResponse> DeletePermissionWithOptionsAsync(string dentryUuid, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @return DeletePermissionResponse
         */
        public DeletePermissionResponse DeletePermission(string dentryUuid, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return DeletePermissionWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 删除权限
         *
         * @param request DeletePermissionRequest
         * @return DeletePermissionResponse
         */
        public async Task<DeletePermissionResponse> DeletePermissionAsync(string dentryUuid, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return await DeletePermissionWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取文件上传信息
         *
         * @param request GetFileUploadInfoRequest
         * @param headers GetFileUploadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileUploadInfoResponse
         */
        public GetFileUploadInfoResponse GetFileUploadInfoWithOptions(string parentDentryUuid, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/files/" + parentDentryUuid + "/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取文件上传信息
         *
         * @param request GetFileUploadInfoRequest
         * @param headers GetFileUploadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileUploadInfoResponse
         */
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoWithOptionsAsync(string parentDentryUuid, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/files/" + parentDentryUuid + "/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文件上传信息
         *
         * @param request GetFileUploadInfoRequest
         * @return GetFileUploadInfoResponse
         */
        public GetFileUploadInfoResponse GetFileUploadInfo(string parentDentryUuid, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return GetFileUploadInfoWithOptions(parentDentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取文件上传信息
         *
         * @param request GetFileUploadInfoRequest
         * @return GetFileUploadInfoResponse
         */
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoAsync(string parentDentryUuid, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return await GetFileUploadInfoWithOptionsAsync(parentDentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取权限继承模式
         *
         * @param request GetPermissionInheritanceRequest
         * @param headers GetPermissionInheritanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionInheritanceResponse
         */
        public GetPermissionInheritanceResponse GetPermissionInheritanceWithOptions(string dentryUuid, GetPermissionInheritanceRequest request, GetPermissionInheritanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPermissionInheritance",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionInheritanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取权限继承模式
         *
         * @param request GetPermissionInheritanceRequest
         * @param headers GetPermissionInheritanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionInheritanceResponse
         */
        public async Task<GetPermissionInheritanceResponse> GetPermissionInheritanceWithOptionsAsync(string dentryUuid, GetPermissionInheritanceRequest request, GetPermissionInheritanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPermissionInheritance",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionInheritanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取权限继承模式
         *
         * @param request GetPermissionInheritanceRequest
         * @return GetPermissionInheritanceResponse
         */
        public GetPermissionInheritanceResponse GetPermissionInheritance(string dentryUuid, GetPermissionInheritanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionInheritanceHeaders headers = new GetPermissionInheritanceHeaders();
            return GetPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取权限继承模式
         *
         * @param request GetPermissionInheritanceRequest
         * @return GetPermissionInheritanceResponse
         */
        public async Task<GetPermissionInheritanceResponse> GetPermissionInheritanceAsync(string dentryUuid, GetPermissionInheritanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionInheritanceHeaders headers = new GetPermissionInheritanceHeaders();
            return await GetPermissionInheritanceWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取分享范围
         *
         * @param request GetPermissionShareScopeRequest
         * @param headers GetPermissionShareScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionShareScopeResponse
         */
        public GetPermissionShareScopeResponse GetPermissionShareScopeWithOptions(string dentryUuid, GetPermissionShareScopeRequest request, GetPermissionShareScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPermissionShareScope",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionShareScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取分享范围
         *
         * @param request GetPermissionShareScopeRequest
         * @param headers GetPermissionShareScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionShareScopeResponse
         */
        public async Task<GetPermissionShareScopeResponse> GetPermissionShareScopeWithOptionsAsync(string dentryUuid, GetPermissionShareScopeRequest request, GetPermissionShareScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPermissionShareScope",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionShareScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取分享范围
         *
         * @param request GetPermissionShareScopeRequest
         * @return GetPermissionShareScopeResponse
         */
        public GetPermissionShareScopeResponse GetPermissionShareScope(string dentryUuid, GetPermissionShareScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionShareScopeHeaders headers = new GetPermissionShareScopeHeaders();
            return GetPermissionShareScopeWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取分享范围
         *
         * @param request GetPermissionShareScopeRequest
         * @return GetPermissionShareScopeResponse
         */
        public async Task<GetPermissionShareScopeResponse> GetPermissionShareScopeAsync(string dentryUuid, GetPermissionShareScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPermissionShareScopeHeaders headers = new GetPermissionShareScopeHeaders();
            return await GetPermissionShareScopeWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @param headers ListPermissionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPermissionsResponse
         */
        public ListPermissionsResponse ListPermissionsWithOptions(string dentryUuid, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/query",
                Method = "POST",
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
        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string dentryUuid, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/query",
                Method = "POST",
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
        public ListPermissionsResponse ListPermissions(string dentryUuid, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return ListPermissionsWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 获取权限列表
         *
         * @param request ListPermissionsRequest
         * @return ListPermissionsResponse
         */
        public async Task<ListPermissionsResponse> ListPermissionsAsync(string dentryUuid, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return await ListPermissionsWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 查询员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerGetDefaultHandOverUserRequest
         * @param headers ManagerGetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagerGetDefaultHandOverUserResponse
         */
        public ManagerGetDefaultHandOverUserResponse ManagerGetDefaultHandOverUserWithOptions(ManagerGetDefaultHandOverUserRequest request, ManagerGetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ManagerGetDefaultHandOverUser",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/managementSettings/defaultHandOverUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagerGetDefaultHandOverUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerGetDefaultHandOverUserRequest
         * @param headers ManagerGetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagerGetDefaultHandOverUserResponse
         */
        public async Task<ManagerGetDefaultHandOverUserResponse> ManagerGetDefaultHandOverUserWithOptionsAsync(ManagerGetDefaultHandOverUserRequest request, ManagerGetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "ManagerGetDefaultHandOverUser",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/managementSettings/defaultHandOverUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagerGetDefaultHandOverUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerGetDefaultHandOverUserRequest
         * @return ManagerGetDefaultHandOverUserResponse
         */
        public ManagerGetDefaultHandOverUserResponse ManagerGetDefaultHandOverUser(ManagerGetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagerGetDefaultHandOverUserHeaders headers = new ManagerGetDefaultHandOverUserHeaders();
            return ManagerGetDefaultHandOverUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerGetDefaultHandOverUserRequest
         * @return ManagerGetDefaultHandOverUserResponse
         */
        public async Task<ManagerGetDefaultHandOverUserResponse> ManagerGetDefaultHandOverUserAsync(ManagerGetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagerGetDefaultHandOverUserHeaders headers = new ManagerGetDefaultHandOverUserHeaders();
            return await ManagerGetDefaultHandOverUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerSetDefaultHandOverUserRequest
         * @param headers ManagerSetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagerSetDefaultHandOverUserResponse
         */
        public ManagerSetDefaultHandOverUserResponse ManagerSetDefaultHandOverUserWithOptions(ManagerSetDefaultHandOverUserRequest request, ManagerSetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultHandoverUserId))
            {
                body["defaultHandoverUserId"] = request.DefaultHandoverUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagerSetDefaultHandOverUser",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/managementSettings/defaultHandOverUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagerSetDefaultHandOverUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerSetDefaultHandOverUserRequest
         * @param headers ManagerSetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManagerSetDefaultHandOverUserResponse
         */
        public async Task<ManagerSetDefaultHandOverUserResponse> ManagerSetDefaultHandOverUserWithOptionsAsync(ManagerSetDefaultHandOverUserRequest request, ManagerSetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultHandoverUserId))
            {
                body["defaultHandoverUserId"] = request.DefaultHandoverUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagerSetDefaultHandOverUser",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/managementSettings/defaultHandOverUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagerSetDefaultHandOverUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerSetDefaultHandOverUserRequest
         * @return ManagerSetDefaultHandOverUserResponse
         */
        public ManagerSetDefaultHandOverUserResponse ManagerSetDefaultHandOverUser(ManagerSetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagerSetDefaultHandOverUserHeaders headers = new ManagerSetDefaultHandOverUserHeaders();
            return ManagerSetDefaultHandOverUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置员工离职时空间默认转交人(管理员)
         *
         * @param request ManagerSetDefaultHandOverUserRequest
         * @return ManagerSetDefaultHandOverUserResponse
         */
        public async Task<ManagerSetDefaultHandOverUserResponse> ManagerSetDefaultHandOverUserAsync(ManagerSetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagerSetDefaultHandOverUserHeaders headers = new ManagerSetDefaultHandOverUserHeaders();
            return await ManagerSetDefaultHandOverUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索文件
         *
         * @param request SearchDentriesRequest
         * @param headers SearchDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDentriesResponse
         */
        public SearchDentriesResponse SearchDentriesWithOptions(SearchDentriesRequest request, SearchDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDentries",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/dentries/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDentriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索文件
         *
         * @param request SearchDentriesRequest
         * @param headers SearchDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDentriesResponse
         */
        public async Task<SearchDentriesResponse> SearchDentriesWithOptionsAsync(SearchDentriesRequest request, SearchDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDentries",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/dentries/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索文件
         *
         * @param request SearchDentriesRequest
         * @return SearchDentriesResponse
         */
        public SearchDentriesResponse SearchDentries(SearchDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDentriesHeaders headers = new SearchDentriesHeaders();
            return SearchDentriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索文件
         *
         * @param request SearchDentriesRequest
         * @return SearchDentriesResponse
         */
        public async Task<SearchDentriesResponse> SearchDentriesAsync(SearchDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDentriesHeaders headers = new SearchDentriesHeaders();
            return await SearchDentriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索公开发布文件
         *
         * @param request SearchPublishDentriesRequest
         * @param headers SearchPublishDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPublishDentriesResponse
         */
        public SearchPublishDentriesResponse SearchPublishDentriesWithOptions(SearchPublishDentriesRequest request, SearchPublishDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPublishDentries",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/publishDentries/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPublishDentriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索公开发布文件
         *
         * @param request SearchPublishDentriesRequest
         * @param headers SearchPublishDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPublishDentriesResponse
         */
        public async Task<SearchPublishDentriesResponse> SearchPublishDentriesWithOptionsAsync(SearchPublishDentriesRequest request, SearchPublishDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPublishDentries",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/publishDentries/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPublishDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索公开发布文件
         *
         * @param request SearchPublishDentriesRequest
         * @return SearchPublishDentriesResponse
         */
        public SearchPublishDentriesResponse SearchPublishDentries(SearchPublishDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchPublishDentriesHeaders headers = new SearchPublishDentriesHeaders();
            return SearchPublishDentriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索公开发布文件
         *
         * @param request SearchPublishDentriesRequest
         * @return SearchPublishDentriesResponse
         */
        public async Task<SearchPublishDentriesResponse> SearchPublishDentriesAsync(SearchPublishDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchPublishDentriesHeaders headers = new SearchPublishDentriesHeaders();
            return await SearchPublishDentriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索知识库
         *
         * @param request SearchWorkspacesRequest
         * @param headers SearchWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchWorkspacesResponse
         */
        public SearchWorkspacesResponse SearchWorkspacesWithOptions(SearchWorkspacesRequest request, SearchWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchWorkspaces",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/workspaces/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchWorkspacesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索知识库
         *
         * @param request SearchWorkspacesRequest
         * @param headers SearchWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchWorkspacesResponse
         */
        public async Task<SearchWorkspacesResponse> SearchWorkspacesWithOptionsAsync(SearchWorkspacesRequest request, SearchWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchWorkspaces",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/workspaces/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchWorkspacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索知识库
         *
         * @param request SearchWorkspacesRequest
         * @return SearchWorkspacesResponse
         */
        public SearchWorkspacesResponse SearchWorkspaces(SearchWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspacesHeaders headers = new SearchWorkspacesHeaders();
            return SearchWorkspacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索知识库
         *
         * @param request SearchWorkspacesRequest
         * @return SearchWorkspacesResponse
         */
        public async Task<SearchWorkspacesResponse> SearchWorkspacesAsync(SearchWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspacesHeaders headers = new SearchWorkspacesHeaders();
            return await SearchWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置权限继承模式
         *
         * @param request SetPermissionInheritanceRequest
         * @param headers SetPermissionInheritanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPermissionInheritanceResponse
         */
        public SetPermissionInheritanceResponse SetPermissionInheritanceWithOptions(string dentryUuid, SetPermissionInheritanceRequest request, SetPermissionInheritanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inheritance))
            {
                body["inheritance"] = request.Inheritance;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPermissionInheritance",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPermissionInheritanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置权限继承模式
         *
         * @param request SetPermissionInheritanceRequest
         * @param headers SetPermissionInheritanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPermissionInheritanceResponse
         */
        public async Task<SetPermissionInheritanceResponse> SetPermissionInheritanceWithOptionsAsync(string dentryUuid, SetPermissionInheritanceRequest request, SetPermissionInheritanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inheritance))
            {
                body["inheritance"] = request.Inheritance;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPermissionInheritance",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPermissionInheritanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置权限继承模式
         *
         * @param request SetPermissionInheritanceRequest
         * @return SetPermissionInheritanceResponse
         */
        public SetPermissionInheritanceResponse SetPermissionInheritance(string dentryUuid, SetPermissionInheritanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetPermissionInheritanceHeaders headers = new SetPermissionInheritanceHeaders();
            return SetPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 设置权限继承模式
         *
         * @param request SetPermissionInheritanceRequest
         * @return SetPermissionInheritanceResponse
         */
        public async Task<SetPermissionInheritanceResponse> SetPermissionInheritanceAsync(string dentryUuid, SetPermissionInheritanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetPermissionInheritanceHeaders headers = new SetPermissionInheritanceHeaders();
            return await SetPermissionInheritanceWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 设置分享范围
         *
         * @param request SetPermissionShareScopeRequest
         * @param headers SetPermissionShareScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPermissionShareScopeResponse
         */
        public SetPermissionShareScopeResponse SetPermissionShareScopeWithOptions(string dentryUuid, SetPermissionShareScopeRequest request, SetPermissionShareScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPermissionShareScope",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/scopes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPermissionShareScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置分享范围
         *
         * @param request SetPermissionShareScopeRequest
         * @param headers SetPermissionShareScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPermissionShareScopeResponse
         */
        public async Task<SetPermissionShareScopeResponse> SetPermissionShareScopeWithOptionsAsync(string dentryUuid, SetPermissionShareScopeRequest request, SetPermissionShareScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPermissionShareScope",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/scopes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPermissionShareScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置分享范围
         *
         * @param request SetPermissionShareScopeRequest
         * @return SetPermissionShareScopeResponse
         */
        public SetPermissionShareScopeResponse SetPermissionShareScope(string dentryUuid, SetPermissionShareScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetPermissionShareScopeHeaders headers = new SetPermissionShareScopeHeaders();
            return SetPermissionShareScopeWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 设置分享范围
         *
         * @param request SetPermissionShareScopeRequest
         * @return SetPermissionShareScopeResponse
         */
        public async Task<SetPermissionShareScopeResponse> SetPermissionShareScopeAsync(string dentryUuid, SetPermissionShareScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetPermissionShareScopeHeaders headers = new SetPermissionShareScopeHeaders();
            return await SetPermissionShareScopeWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 修改权限
         *
         * @param request UpdatePermissionRequest
         * @param headers UpdatePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePermissionResponse
         */
        public UpdatePermissionResponse UpdatePermissionWithOptions(string dentryUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改权限
         *
         * @param request UpdatePermissionRequest
         * @param headers UpdatePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePermissionResponse
         */
        public async Task<UpdatePermissionResponse> UpdatePermissionWithOptionsAsync(string dentryUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["roleId"] = request.RoleId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePermission",
                Version = "storage_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改权限
         *
         * @param request UpdatePermissionRequest
         * @return UpdatePermissionResponse
         */
        public UpdatePermissionResponse UpdatePermission(string dentryUuid, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return UpdatePermissionWithOptions(dentryUuid, request, headers, runtime);
        }

        /**
         * @summary 修改权限
         *
         * @param request UpdatePermissionRequest
         * @return UpdatePermissionResponse
         */
        public async Task<UpdatePermissionResponse> UpdatePermissionAsync(string dentryUuid, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return await UpdatePermissionWithOptionsAsync(dentryUuid, request, headers, runtime);
        }

    }
}
