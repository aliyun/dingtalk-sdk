// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkstorage_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0
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


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFolderRequest
        /// </param>
        /// <param name="headers">
        /// AddFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFolderResponse
        /// </returns>
        public AddFolderResponse AddFolderWithOptions(string spaceId, string parentId, AddFolderRequest request, AddFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddFolder",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFolderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFolderRequest
        /// </param>
        /// <param name="headers">
        /// AddFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFolderResponse
        /// </returns>
        public async Task<AddFolderResponse> AddFolderWithOptionsAsync(string spaceId, string parentId, AddFolderRequest request, AddFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddFolder",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFolderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFolderResponse
        /// </returns>
        public AddFolderResponse AddFolder(string spaceId, string parentId, AddFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFolderHeaders headers = new AddFolderHeaders();
            return AddFolderWithOptions(spaceId, parentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFolderResponse
        /// </returns>
        public async Task<AddFolderResponse> AddFolderAsync(string spaceId, string parentId, AddFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFolderHeaders headers = new AddFolderHeaders();
            return await AddFolderWithOptionsAsync(spaceId, parentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPermissionRequest
        /// </param>
        /// <param name="headers">
        /// AddPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionResponse
        /// </returns>
        public AddPermissionResponse AddPermissionWithOptions(string spaceId, string dentryId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPermissionRequest
        /// </param>
        /// <param name="headers">
        /// AddPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionResponse
        /// </returns>
        public async Task<AddPermissionResponse> AddPermissionWithOptionsAsync(string spaceId, string dentryId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionResponse
        /// </returns>
        public AddPermissionResponse AddPermission(string spaceId, string dentryId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return AddPermissionWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionResponse
        /// </returns>
        public async Task<AddPermissionResponse> AddPermissionAsync(string spaceId, string dentryId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return await AddPermissionWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSpaceRequest
        /// </param>
        /// <param name="headers">
        /// AddSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSpaceResponse
        /// </returns>
        public AddSpaceResponse AddSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddSpace",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSpaceRequest
        /// </param>
        /// <param name="headers">
        /// AddSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSpaceResponse
        /// </returns>
        public async Task<AddSpaceResponse> AddSpaceWithOptionsAsync(AddSpaceRequest request, AddSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddSpace",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSpaceResponse
        /// </returns>
        public AddSpaceResponse AddSpace(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return AddSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSpaceResponse
        /// </returns>
        public async Task<AddSpaceResponse> AddSpaceAsync(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return await AddSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryRolesRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryRolesResponse
        /// </returns>
        public BatchQueryRolesResponse BatchQueryRolesWithOptions(string spaceId, BatchQueryRolesRequest tmpReq, BatchQueryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryRolesShrinkRequest request = new BatchQueryRolesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DentryIdList))
            {
                request.DentryIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DentryIdList, "dentryIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIdListShrink))
            {
                query["dentryIdList"] = request.DentryIdListShrink;
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
                Action = "BatchQueryRoles",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/permissions/roles/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryRolesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryRolesRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryRolesResponse
        /// </returns>
        public async Task<BatchQueryRolesResponse> BatchQueryRolesWithOptionsAsync(string spaceId, BatchQueryRolesRequest tmpReq, BatchQueryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryRolesShrinkRequest request = new BatchQueryRolesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DentryIdList))
            {
                request.DentryIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DentryIdList, "dentryIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIdListShrink))
            {
                query["dentryIdList"] = request.DentryIdListShrink;
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
                Action = "BatchQueryRoles",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/permissions/roles/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryRolesResponse
        /// </returns>
        public BatchQueryRolesResponse BatchQueryRoles(string spaceId, BatchQueryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryRolesHeaders headers = new BatchQueryRolesHeaders();
            return BatchQueryRolesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryRolesResponse
        /// </returns>
        public async Task<BatchQueryRolesResponse> BatchQueryRolesAsync(string spaceId, BatchQueryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryRolesHeaders headers = new BatchQueryRolesHeaders();
            return await BatchQueryRolesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空回收站</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRecycleBinRequest
        /// </param>
        /// <param name="headers">
        /// ClearRecycleBinHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearRecycleBinResponse
        /// </returns>
        public ClearRecycleBinResponse ClearRecycleBinWithOptions(string recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ClearRecycleBin",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRecycleBinResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空回收站</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRecycleBinRequest
        /// </param>
        /// <param name="headers">
        /// ClearRecycleBinHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearRecycleBinResponse
        /// </returns>
        public async Task<ClearRecycleBinResponse> ClearRecycleBinWithOptionsAsync(string recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ClearRecycleBin",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRecycleBinResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空回收站</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearRecycleBinResponse
        /// </returns>
        public ClearRecycleBinResponse ClearRecycleBin(string recycleBinId, ClearRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
            return ClearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空回收站</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearRecycleBinResponse
        /// </returns>
        public async Task<ClearRecycleBinResponse> ClearRecycleBinAsync(string recycleBinId, ClearRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
            return await ClearRecycleBinWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitFileRequest
        /// </param>
        /// <param name="headers">
        /// CommitFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitFileResponse
        /// </returns>
        public CommitFileResponse CommitFileWithOptions(string spaceId, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteDentryId))
            {
                body["overwriteDentryId"] = request.OverwriteDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitFileRequest
        /// </param>
        /// <param name="headers">
        /// CommitFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitFileResponse
        /// </returns>
        public async Task<CommitFileResponse> CommitFileWithOptionsAsync(string spaceId, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteDentryId))
            {
                body["overwriteDentryId"] = request.OverwriteDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitFileResponse
        /// </returns>
        public CommitFileResponse CommitFile(string spaceId, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return CommitFileWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitFileResponse
        /// </returns>
        public async Task<CommitFileResponse> CommitFileAsync(string spaceId, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return await CommitFileWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentriesRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentriesResponse
        /// </returns>
        public CopyDentriesResponse CopyDentriesWithOptions(string spaceId, CopyDentriesRequest request, CopyDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "CopyDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchCopy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentriesRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentriesResponse
        /// </returns>
        public async Task<CopyDentriesResponse> CopyDentriesWithOptionsAsync(string spaceId, CopyDentriesRequest request, CopyDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "CopyDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchCopy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentriesResponse
        /// </returns>
        public CopyDentriesResponse CopyDentries(string spaceId, CopyDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentriesHeaders headers = new CopyDentriesHeaders();
            return CopyDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentriesResponse
        /// </returns>
        public async Task<CopyDentriesResponse> CopyDentriesAsync(string spaceId, CopyDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentriesHeaders headers = new CopyDentriesHeaders();
            return await CopyDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public CopyDentryResponse CopyDentryWithOptions(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "CopyDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// <param name="headers">
        /// CopyDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public async Task<CopyDentryResponse> CopyDentryWithOptionsAsync(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "CopyDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public CopyDentryResponse CopyDentry(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return CopyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDentryResponse
        /// </returns>
        public async Task<CopyDentryResponse> CopyDentryAsync(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return await CopyDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentriesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentriesResponse
        /// </returns>
        public DeleteDentriesResponse DeleteDentriesWithOptions(string spaceId, DeleteDentriesRequest request, DeleteDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "DeleteDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentriesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentriesResponse
        /// </returns>
        public async Task<DeleteDentriesResponse> DeleteDentriesWithOptionsAsync(string spaceId, DeleteDentriesRequest request, DeleteDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "DeleteDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentriesResponse
        /// </returns>
        public DeleteDentriesResponse DeleteDentries(string spaceId, DeleteDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentriesHeaders headers = new DeleteDentriesHeaders();
            return DeleteDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentriesResponse
        /// </returns>
        public async Task<DeleteDentriesResponse> DeleteDentriesAsync(string spaceId, DeleteDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentriesHeaders headers = new DeleteDentriesHeaders();
            return await DeleteDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryResponse
        /// </returns>
        public DeleteDentryResponse DeleteDentryWithOptions(string spaceId, string dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToRecycleBin))
            {
                query["toRecycleBin"] = request.ToRecycleBin;
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
                Action = "DeleteDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryResponse
        /// </returns>
        public async Task<DeleteDentryResponse> DeleteDentryWithOptionsAsync(string spaceId, string dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToRecycleBin))
            {
                query["toRecycleBin"] = request.ToRecycleBin;
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
                Action = "DeleteDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryResponse
        /// </returns>
        public DeleteDentryResponse DeleteDentry(string spaceId, string dentryId, DeleteDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryHeaders headers = new DeleteDentryHeaders();
            return DeleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryResponse
        /// </returns>
        public async Task<DeleteDentryResponse> DeleteDentryAsync(string spaceId, string dentryId, DeleteDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryHeaders headers = new DeleteDentryHeaders();
            return await DeleteDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryAppPropertiesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentryAppPropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryAppPropertiesResponse
        /// </returns>
        public DeleteDentryAppPropertiesResponse DeleteDentryAppPropertiesWithOptions(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
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
                Action = "DeleteDentryAppProperties",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentryAppPropertiesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryAppPropertiesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDentryAppPropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryAppPropertiesResponse
        /// </returns>
        public async Task<DeleteDentryAppPropertiesResponse> DeleteDentryAppPropertiesWithOptionsAsync(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
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
                Action = "DeleteDentryAppProperties",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDentryAppPropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryAppPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryAppPropertiesResponse
        /// </returns>
        public DeleteDentryAppPropertiesResponse DeleteDentryAppProperties(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
            return DeleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDentryAppPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDentryAppPropertiesResponse
        /// </returns>
        public async Task<DeleteDentryAppPropertiesResponse> DeleteDentryAppPropertiesAsync(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
            return await DeleteDentryAppPropertiesWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// <param name="headers">
        /// DeletePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public DeletePermissionResponse DeletePermissionWithOptions(string spaceId, string dentryId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// <param name="headers">
        /// DeletePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public async Task<DeletePermissionResponse> DeletePermissionWithOptionsAsync(string spaceId, string dentryId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public DeletePermissionResponse DeletePermission(string spaceId, string dentryId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return DeletePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePermissionResponse
        /// </returns>
        public async Task<DeletePermissionResponse> DeletePermissionAsync(string spaceId, string dentryId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return await DeletePermissionWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemResponse
        /// </returns>
        public DeleteRecycleItemResponse DeleteRecycleItemWithOptions(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecycleItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemResponse
        /// </returns>
        public async Task<DeleteRecycleItemResponse> DeleteRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecycleItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemResponse
        /// </returns>
        public DeleteRecycleItemResponse DeleteRecycleItem(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
            return DeleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemResponse
        /// </returns>
        public async Task<DeleteRecycleItemResponse> DeleteRecycleItemAsync(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
            return await DeleteRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemsResponse
        /// </returns>
        public DeleteRecycleItemsResponse DeleteRecycleItemsWithOptions(string recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIds))
            {
                body["recycleItemIds"] = request.RecycleItemIds;
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
                Action = "DeleteRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecycleItemsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemsResponse
        /// </returns>
        public async Task<DeleteRecycleItemsResponse> DeleteRecycleItemsWithOptionsAsync(string recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIds))
            {
                body["recycleItemIds"] = request.RecycleItemIds;
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
                Action = "DeleteRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecycleItemsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemsResponse
        /// </returns>
        public DeleteRecycleItemsResponse DeleteRecycleItems(string recycleBinId, DeleteRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
            return DeleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecycleItemsResponse
        /// </returns>
        public async Task<DeleteRecycleItemsResponse> DeleteRecycleItemsAsync(string recycleBinId, DeleteRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
            return await DeleteRecycleItemsWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开放平台应用在企业存储中的相关应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentAppRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentAppResponse
        /// </returns>
        public GetCurrentAppResponse GetCurrentAppWithOptions(GetCurrentAppRequest request, GetCurrentAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCurrentApp",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/currentApps/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开放平台应用在企业存储中的相关应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentAppRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentAppResponse
        /// </returns>
        public async Task<GetCurrentAppResponse> GetCurrentAppWithOptionsAsync(GetCurrentAppRequest request, GetCurrentAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCurrentApp",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/currentApps/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开放平台应用在企业存储中的相关应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentAppResponse
        /// </returns>
        public GetCurrentAppResponse GetCurrentApp(GetCurrentAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
            return GetCurrentAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开放平台应用在企业存储中的相关应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentAppResponse
        /// </returns>
        public async Task<GetCurrentAppResponse> GetCurrentAppAsync(GetCurrentAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
            return await GetCurrentAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentriesRequest
        /// </param>
        /// <param name="headers">
        /// GetDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentriesResponse
        /// </returns>
        public GetDentriesResponse GetDentriesWithOptions(string spaceId, GetDentriesRequest request, GetDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "GetDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentriesRequest
        /// </param>
        /// <param name="headers">
        /// GetDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentriesResponse
        /// </returns>
        public async Task<GetDentriesResponse> GetDentriesWithOptionsAsync(string spaceId, GetDentriesRequest request, GetDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "GetDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentriesResponse
        /// </returns>
        public GetDentriesResponse GetDentries(string spaceId, GetDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentriesHeaders headers = new GetDentriesHeaders();
            return GetDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentriesResponse
        /// </returns>
        public async Task<GetDentriesResponse> GetDentriesAsync(string spaceId, GetDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentriesHeaders headers = new GetDentriesHeaders();
            return await GetDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryResponse
        /// </returns>
        public GetDentryResponse GetDentryWithOptions(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryResponse
        /// </returns>
        public async Task<GetDentryResponse> GetDentryWithOptionsAsync(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryResponse
        /// </returns>
        public GetDentryResponse GetDentry(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return GetDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件(夹)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryResponse
        /// </returns>
        public async Task<GetDentryResponse> GetDentryAsync(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return await GetDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryOpenInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryOpenInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryOpenInfoResponse
        /// </returns>
        public GetDentryOpenInfoResponse GetDentryOpenInfoWithOptions(string spaceId, string dentryId, GetDentryOpenInfoRequest request, GetDentryOpenInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDentryOpenInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryOpenInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryOpenInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryOpenInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryOpenInfoResponse
        /// </returns>
        public async Task<GetDentryOpenInfoResponse> GetDentryOpenInfoWithOptionsAsync(string spaceId, string dentryId, GetDentryOpenInfoRequest request, GetDentryOpenInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDentryOpenInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryOpenInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryOpenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryOpenInfoResponse
        /// </returns>
        public GetDentryOpenInfoResponse GetDentryOpenInfo(string spaceId, string dentryId, GetDentryOpenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryOpenInfoHeaders headers = new GetDentryOpenInfoHeaders();
            return GetDentryOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件打开链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryOpenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryOpenInfoResponse
        /// </returns>
        public async Task<GetDentryOpenInfoResponse> GetDentryOpenInfoAsync(string spaceId, string dentryId, GetDentryOpenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryOpenInfoHeaders headers = new GetDentryOpenInfoHeaders();
            return await GetDentryOpenInfoWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件缩略图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryThumbnailsRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryThumbnailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryThumbnailsResponse
        /// </returns>
        public GetDentryThumbnailsResponse GetDentryThumbnailsWithOptions(string spaceId, GetDentryThumbnailsRequest request, GetDentryThumbnailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "GetDentryThumbnails",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/thumbnails/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryThumbnailsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件缩略图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryThumbnailsRequest
        /// </param>
        /// <param name="headers">
        /// GetDentryThumbnailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDentryThumbnailsResponse
        /// </returns>
        public async Task<GetDentryThumbnailsResponse> GetDentryThumbnailsWithOptionsAsync(string spaceId, GetDentryThumbnailsRequest request, GetDentryThumbnailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
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
                Action = "GetDentryThumbnails",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/thumbnails/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryThumbnailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件缩略图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryThumbnailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryThumbnailsResponse
        /// </returns>
        public GetDentryThumbnailsResponse GetDentryThumbnails(string spaceId, GetDentryThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryThumbnailsHeaders headers = new GetDentryThumbnailsHeaders();
            return GetDentryThumbnailsWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文件缩略图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDentryThumbnailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDentryThumbnailsResponse
        /// </returns>
        public async Task<GetDentryThumbnailsResponse> GetDentryThumbnailsAsync(string spaceId, GetDentryThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryThumbnailsHeaders headers = new GetDentryThumbnailsHeaders();
            return await GetDentryThumbnailsWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件下载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDownloadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetFileDownloadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileDownloadInfoResponse
        /// </returns>
        public GetFileDownloadInfoResponse GetFileDownloadInfoWithOptions(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFileDownloadInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件下载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDownloadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetFileDownloadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileDownloadInfoResponse
        /// </returns>
        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoWithOptionsAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFileDownloadInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件下载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDownloadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileDownloadInfoResponse
        /// </returns>
        public GetFileDownloadInfoResponse GetFileDownloadInfo(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return GetFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件下载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDownloadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileDownloadInfoResponse
        /// </returns>
        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return await GetFileDownloadInfoWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetFileUploadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public GetFileUploadInfoResponse GetFileUploadInfoWithOptions(string spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Multipart))
            {
                body["multipart"] = request.Multipart;
            }
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetFileUploadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoWithOptionsAsync(string spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Multipart))
            {
                body["multipart"] = request.Multipart;
            }
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public GetFileUploadInfoResponse GetFileUploadInfo(string spaceId, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return GetFileUploadInfoWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoAsync(string spaceId, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return await GetFileUploadInfoWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息(分片上传)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultipartFileUploadInfosRequest
        /// </param>
        /// <param name="headers">
        /// GetMultipartFileUploadInfosHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultipartFileUploadInfosResponse
        /// </returns>
        public GetMultipartFileUploadInfosResponse GetMultipartFileUploadInfosWithOptions(GetMultipartFileUploadInfosRequest request, GetMultipartFileUploadInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumbers))
            {
                body["partNumbers"] = request.PartNumbers;
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
                Action = "GetMultipartFileUploadInfos",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/files/multiPartUploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultipartFileUploadInfosResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息(分片上传)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultipartFileUploadInfosRequest
        /// </param>
        /// <param name="headers">
        /// GetMultipartFileUploadInfosHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultipartFileUploadInfosResponse
        /// </returns>
        public async Task<GetMultipartFileUploadInfosResponse> GetMultipartFileUploadInfosWithOptionsAsync(GetMultipartFileUploadInfosRequest request, GetMultipartFileUploadInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumbers))
            {
                body["partNumbers"] = request.PartNumbers;
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
                Action = "GetMultipartFileUploadInfos",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/files/multiPartUploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultipartFileUploadInfosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息(分片上传)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultipartFileUploadInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultipartFileUploadInfosResponse
        /// </returns>
        public GetMultipartFileUploadInfosResponse GetMultipartFileUploadInfos(GetMultipartFileUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultipartFileUploadInfosHeaders headers = new GetMultipartFileUploadInfosHeaders();
            return GetMultipartFileUploadInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传信息(分片上传)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultipartFileUploadInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultipartFileUploadInfosResponse
        /// </returns>
        public async Task<GetMultipartFileUploadInfosResponse> GetMultipartFileUploadInfosAsync(GetMultipartFileUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultipartFileUploadInfosHeaders headers = new GetMultipartFileUploadInfosHeaders();
            return await GetMultipartFileUploadInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业存储中企业维度的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgResponse
        /// </returns>
        public GetOrgResponse GetOrgWithOptions(string corpId, GetOrgRequest request, GetOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrg",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/orgs/" + corpId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业存储中企业维度的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgResponse
        /// </returns>
        public async Task<GetOrgResponse> GetOrgWithOptionsAsync(string corpId, GetOrgRequest request, GetOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrg",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/orgs/" + corpId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业存储中企业维度的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgResponse
        /// </returns>
        public GetOrgResponse GetOrg(string corpId, GetOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgHeaders headers = new GetOrgHeaders();
            return GetOrgWithOptions(corpId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业存储中企业维度的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgResponse
        /// </returns>
        public async Task<GetOrgResponse> GetOrgAsync(string corpId, GetOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgHeaders headers = new GetOrgHeaders();
            return await GetOrgWithOptionsAsync(corpId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收站信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleBinRequest
        /// </param>
        /// <param name="headers">
        /// GetRecycleBinHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinResponse
        /// </returns>
        public GetRecycleBinResponse GetRecycleBinWithOptions(GetRecycleBinRequest request, GetRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleBinScope))
            {
                query["recycleBinScope"] = request.RecycleBinScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                query["scopeId"] = request.ScopeId;
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
                Action = "GetRecycleBin",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleBinResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收站信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleBinRequest
        /// </param>
        /// <param name="headers">
        /// GetRecycleBinHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinResponse
        /// </returns>
        public async Task<GetRecycleBinResponse> GetRecycleBinWithOptionsAsync(GetRecycleBinRequest request, GetRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleBinScope))
            {
                query["recycleBinScope"] = request.RecycleBinScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                query["scopeId"] = request.ScopeId;
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
                Action = "GetRecycleBin",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleBinResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收站信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinResponse
        /// </returns>
        public GetRecycleBinResponse GetRecycleBin(GetRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
            return GetRecycleBinWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收站信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinResponse
        /// </returns>
        public async Task<GetRecycleBinResponse> GetRecycleBinAsync(GetRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
            return await GetRecycleBinWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// GetRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleItemResponse
        /// </returns>
        public GetRecycleItemResponse GetRecycleItemWithOptions(string recycleBinId, string recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// GetRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleItemResponse
        /// </returns>
        public async Task<GetRecycleItemResponse> GetRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleItemResponse
        /// </returns>
        public GetRecycleItemResponse GetRecycleItem(string recycleBinId, string recycleItemId, GetRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
            return GetRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleItemResponse
        /// </returns>
        public async Task<GetRecycleItemResponse> GetRecycleItemAsync(string recycleBinId, string recycleItemId, GetRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
            return await GetRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceResponse
        /// </returns>
        public GetSpaceResponse GetSpaceWithOptions(string spaceId, GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSpace",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceResponse
        /// </returns>
        public async Task<GetSpaceResponse> GetSpaceWithOptionsAsync(string spaceId, GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSpace",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceResponse
        /// </returns>
        public GetSpaceResponse GetSpace(string spaceId, GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return GetSpaceWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceResponse
        /// </returns>
        public async Task<GetSpaceResponse> GetSpaceAsync(string spaceId, GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return await GetSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTaskWithOptions(string taskId, GetTaskRequest request, GetTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTask",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string taskId, GetTaskRequest request, GetTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTask",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTask(string taskId, GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskHeaders headers = new GetTaskHeaders();
            return GetTaskWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskAsync(string taskId, GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskHeaders headers = new GetTaskHeaders();
            return await GetTaskWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 WebOfficeUrl 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebOfficeUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetWebOfficeUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebOfficeUrlResponse
        /// </returns>
        public GetWebOfficeUrlResponse GetWebOfficeUrlWithOptions(string spaceId, string dentryId, GetWebOfficeUrlRequest request, GetWebOfficeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetWebOfficeUrl",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/webOfficeUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebOfficeUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 WebOfficeUrl 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebOfficeUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetWebOfficeUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebOfficeUrlResponse
        /// </returns>
        public async Task<GetWebOfficeUrlResponse> GetWebOfficeUrlWithOptionsAsync(string spaceId, string dentryId, GetWebOfficeUrlRequest request, GetWebOfficeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetWebOfficeUrl",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/webOfficeUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebOfficeUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 WebOfficeUrl 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebOfficeUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebOfficeUrlResponse
        /// </returns>
        public GetWebOfficeUrlResponse GetWebOfficeUrl(string spaceId, string dentryId, GetWebOfficeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebOfficeUrlHeaders headers = new GetWebOfficeUrlHeaders();
            return GetWebOfficeUrlWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 WebOfficeUrl 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebOfficeUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebOfficeUrlResponse
        /// </returns>
        public async Task<GetWebOfficeUrlResponse> GetWebOfficeUrlAsync(string spaceId, string dentryId, GetWebOfficeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebOfficeUrlHeaders headers = new GetWebOfficeUrlHeaders();
            return await GetWebOfficeUrlWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化文件分片上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitMultipartFileUploadRequest
        /// </param>
        /// <param name="headers">
        /// InitMultipartFileUploadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitMultipartFileUploadResponse
        /// </returns>
        public InitMultipartFileUploadResponse InitMultipartFileUploadWithOptions(string spaceId, InitMultipartFileUploadRequest request, InitMultipartFileUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "InitMultipartFileUpload",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/multiPartUploadInfos/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitMultipartFileUploadResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化文件分片上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitMultipartFileUploadRequest
        /// </param>
        /// <param name="headers">
        /// InitMultipartFileUploadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitMultipartFileUploadResponse
        /// </returns>
        public async Task<InitMultipartFileUploadResponse> InitMultipartFileUploadWithOptionsAsync(string spaceId, InitMultipartFileUploadRequest request, InitMultipartFileUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "InitMultipartFileUpload",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/files/multiPartUploadInfos/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitMultipartFileUploadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化文件分片上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitMultipartFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// InitMultipartFileUploadResponse
        /// </returns>
        public InitMultipartFileUploadResponse InitMultipartFileUpload(string spaceId, InitMultipartFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitMultipartFileUploadHeaders headers = new InitMultipartFileUploadHeaders();
            return InitMultipartFileUploadWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化文件分片上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitMultipartFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// InitMultipartFileUploadResponse
        /// </returns>
        public async Task<InitMultipartFileUploadResponse> InitMultipartFileUploadAsync(string spaceId, InitMultipartFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitMultipartFileUploadHeaders headers = new InitMultipartFileUploadHeaders();
            return await InitMultipartFileUploadWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllDentriesRequest
        /// </param>
        /// <param name="headers">
        /// ListAllDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllDentriesResponse
        /// </returns>
        public ListAllDentriesResponse ListAllDentriesWithOptions(string spaceId, ListAllDentriesRequest request, ListAllDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/listAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllDentriesRequest
        /// </param>
        /// <param name="headers">
        /// ListAllDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllDentriesResponse
        /// </returns>
        public async Task<ListAllDentriesResponse> ListAllDentriesWithOptionsAsync(string spaceId, ListAllDentriesRequest request, ListAllDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/listAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllDentriesResponse
        /// </returns>
        public ListAllDentriesResponse ListAllDentries(string spaceId, ListAllDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllDentriesHeaders headers = new ListAllDentriesHeaders();
            return ListAllDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllDentriesResponse
        /// </returns>
        public async Task<ListAllDentriesResponse> ListAllDentriesAsync(string spaceId, ListAllDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllDentriesHeaders headers = new ListAllDentriesHeaders();
            return await ListAllDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentriesRequest
        /// </param>
        /// <param name="headers">
        /// ListDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDentriesResponse
        /// </returns>
        public ListDentriesResponse ListDentriesWithOptions(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithThumbnail))
            {
                query["withThumbnail"] = request.WithThumbnail;
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
                Action = "ListDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentriesRequest
        /// </param>
        /// <param name="headers">
        /// ListDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDentriesResponse
        /// </returns>
        public async Task<ListDentriesResponse> ListDentriesWithOptionsAsync(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithThumbnail))
            {
                query["withThumbnail"] = request.WithThumbnail;
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
                Action = "ListDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDentriesResponse
        /// </returns>
        public ListDentriesResponse ListDentries(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return ListDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDentriesResponse
        /// </returns>
        public async Task<ListDentriesResponse> ListDentriesAsync(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return await ListDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentryVersionsRequest
        /// </param>
        /// <param name="headers">
        /// ListDentryVersionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDentryVersionsResponse
        /// </returns>
        public ListDentryVersionsResponse ListDentryVersionsWithOptions(string spaceId, string dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListDentryVersions",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentryVersionsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentryVersionsRequest
        /// </param>
        /// <param name="headers">
        /// ListDentryVersionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDentryVersionsResponse
        /// </returns>
        public async Task<ListDentryVersionsResponse> ListDentryVersionsWithOptionsAsync(string spaceId, string dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListDentryVersions",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentryVersionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentryVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDentryVersionsResponse
        /// </returns>
        public ListDentryVersionsResponse ListDentryVersions(string spaceId, string dentryId, ListDentryVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
            return ListDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDentryVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDentryVersionsResponse
        /// </returns>
        public async Task<ListDentryVersionsResponse> ListDentryVersionsAsync(string spaceId, string dentryId, ListDentryVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
            return await ListDentryVersionsWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// ListPermissionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissionsWithOptions(string spaceId, string dentryId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// ListPermissionsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string spaceId, string dentryId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissions(string spaceId, string dentryId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return ListPermissionsWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(string spaceId, string dentryId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return await ListPermissionsWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleItemsResponse
        /// </returns>
        public ListRecycleItemsResponse ListRecycleItemsWithOptions(string recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleItemsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleItemsResponse
        /// </returns>
        public async Task<ListRecycleItemsResponse> ListRecycleItemsWithOptionsAsync(string recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleItemsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleItemsResponse
        /// </returns>
        public ListRecycleItemsResponse ListRecycleItems(string recycleBinId, ListRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
            return ListRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取回收项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleItemsResponse
        /// </returns>
        public async Task<ListRecycleItemsResponse> ListRecycleItemsAsync(string recycleBinId, ListRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
            return await ListRecycleItemsWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentriesRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentriesResponse
        /// </returns>
        public MoveDentriesResponse MoveDentriesWithOptions(string spaceId, MoveDentriesRequest request, MoveDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "MoveDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchMove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentriesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentriesRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentriesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentriesResponse
        /// </returns>
        public async Task<MoveDentriesResponse> MoveDentriesWithOptionsAsync(string spaceId, MoveDentriesRequest request, MoveDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "MoveDentries",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/batchMove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentriesResponse
        /// </returns>
        public MoveDentriesResponse MoveDentries(string spaceId, MoveDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentriesHeaders headers = new MoveDentriesHeaders();
            return MoveDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentriesRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentriesResponse
        /// </returns>
        public async Task<MoveDentriesResponse> MoveDentriesAsync(string spaceId, MoveDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentriesHeaders headers = new MoveDentriesHeaders();
            return await MoveDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public MoveDentryResponse MoveDentryWithOptions(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "MoveDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// <param name="headers">
        /// MoveDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public async Task<MoveDentryResponse> MoveDentryWithOptionsAsync(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
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
                Action = "MoveDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public MoveDentryResponse MoveDentry(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return MoveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveDentryResponse
        /// </returns>
        public async Task<MoveDentryResponse> MoveDentryAsync(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return await MoveDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 accessToken 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshWebOfficeTokenRequest
        /// </param>
        /// <param name="headers">
        /// RefreshWebOfficeTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshWebOfficeTokenResponse
        /// </returns>
        public RefreshWebOfficeTokenResponse RefreshWebOfficeTokenWithOptions(string spaceId, string dentryId, RefreshWebOfficeTokenRequest request, RefreshWebOfficeTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebOfficeAccessToken))
            {
                query["webOfficeAccessToken"] = request.WebOfficeAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebOfficeRefreshToken))
            {
                query["webOfficeRefreshToken"] = request.WebOfficeRefreshToken;
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
                Action = "RefreshWebOfficeToken",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/refreshWebOfficeToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshWebOfficeTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 accessToken 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshWebOfficeTokenRequest
        /// </param>
        /// <param name="headers">
        /// RefreshWebOfficeTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshWebOfficeTokenResponse
        /// </returns>
        public async Task<RefreshWebOfficeTokenResponse> RefreshWebOfficeTokenWithOptionsAsync(string spaceId, string dentryId, RefreshWebOfficeTokenRequest request, RefreshWebOfficeTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebOfficeAccessToken))
            {
                query["webOfficeAccessToken"] = request.WebOfficeAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebOfficeRefreshToken))
            {
                query["webOfficeRefreshToken"] = request.WebOfficeRefreshToken;
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
                Action = "RefreshWebOfficeToken",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/refreshWebOfficeToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshWebOfficeTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 accessToken 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshWebOfficeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshWebOfficeTokenResponse
        /// </returns>
        public RefreshWebOfficeTokenResponse RefreshWebOfficeToken(string spaceId, string dentryId, RefreshWebOfficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefreshWebOfficeTokenHeaders headers = new RefreshWebOfficeTokenHeaders();
            return RefreshWebOfficeTokenWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 accessToken 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshWebOfficeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshWebOfficeTokenResponse
        /// </returns>
        public async Task<RefreshWebOfficeTokenResponse> RefreshWebOfficeTokenAsync(string spaceId, string dentryId, RefreshWebOfficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefreshWebOfficeTokenHeaders headers = new RefreshWebOfficeTokenHeaders();
            return await RefreshWebOfficeTokenWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册文件预览或编辑链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterOpenInfoRequest
        /// </param>
        /// <param name="headers">
        /// RegisterOpenInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterOpenInfoResponse
        /// </returns>
        public RegisterOpenInfoResponse RegisterOpenInfoWithOptions(string spaceId, string dentryId, RegisterOpenInfoRequest request, RegisterOpenInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInfos))
            {
                body["openInfos"] = request.OpenInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["provider"] = request.Provider;
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
                Action = "RegisterOpenInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterOpenInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册文件预览或编辑链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterOpenInfoRequest
        /// </param>
        /// <param name="headers">
        /// RegisterOpenInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterOpenInfoResponse
        /// </returns>
        public async Task<RegisterOpenInfoResponse> RegisterOpenInfoWithOptionsAsync(string spaceId, string dentryId, RegisterOpenInfoRequest request, RegisterOpenInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInfos))
            {
                body["openInfos"] = request.OpenInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["provider"] = request.Provider;
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
                Action = "RegisterOpenInfo",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterOpenInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册文件预览或编辑链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterOpenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterOpenInfoResponse
        /// </returns>
        public RegisterOpenInfoResponse RegisterOpenInfo(string spaceId, string dentryId, RegisterOpenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterOpenInfoHeaders headers = new RegisterOpenInfoHeaders();
            return RegisterOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册文件预览或编辑链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterOpenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterOpenInfoResponse
        /// </returns>
        public async Task<RegisterOpenInfoResponse> RegisterOpenInfoAsync(string spaceId, string dentryId, RegisterOpenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterOpenInfoHeaders headers = new RegisterOpenInfoHeaders();
            return await RegisterOpenInfoWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// <param name="headers">
        /// RenameDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public RenameDentryResponse RenameDentryWithOptions(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
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
                Action = "RenameDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDentryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// <param name="headers">
        /// RenameDentryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public async Task<RenameDentryResponse> RenameDentryWithOptionsAsync(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
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
                Action = "RenameDentry",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public RenameDentryResponse RenameDentry(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return RenameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名文件或文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameDentryRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDentryResponse
        /// </returns>
        public async Task<RenameDentryResponse> RenameDentryAsync(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return await RenameDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// RestoreRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemResponse
        /// </returns>
        public RestoreRecycleItemResponse RestoreRecycleItemWithOptions(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RestoreRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRecycleItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemRequest
        /// </param>
        /// <param name="headers">
        /// RestoreRecycleItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemResponse
        /// </returns>
        public async Task<RestoreRecycleItemResponse> RestoreRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RestoreRecycleItem",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRecycleItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemResponse
        /// </returns>
        public RestoreRecycleItemResponse RestoreRecycleItem(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
            return RestoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemResponse
        /// </returns>
        public async Task<RestoreRecycleItemResponse> RestoreRecycleItemAsync(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
            return await RestoreRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// RestoreRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemsResponse
        /// </returns>
        public RestoreRecycleItemsResponse RestoreRecycleItemsWithOptions(string recycleBinId, RestoreRecycleItemsRequest request, RestoreRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIds))
            {
                body["recycleItemIds"] = request.RecycleItemIds;
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
                Action = "RestoreRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRestore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRecycleItemsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemsRequest
        /// </param>
        /// <param name="headers">
        /// RestoreRecycleItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemsResponse
        /// </returns>
        public async Task<RestoreRecycleItemsResponse> RestoreRecycleItemsWithOptionsAsync(string recycleBinId, RestoreRecycleItemsRequest request, RestoreRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleItemIds))
            {
                body["recycleItemIds"] = request.RecycleItemIds;
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
                Action = "RestoreRecycleItems",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRestore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRecycleItemsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemsResponse
        /// </returns>
        public RestoreRecycleItemsResponse RestoreRecycleItems(string recycleBinId, RestoreRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemsHeaders headers = new RestoreRecycleItemsHeaders();
            return RestoreRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量还原回收站中的回收项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreRecycleItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreRecycleItemsResponse
        /// </returns>
        public async Task<RestoreRecycleItemsResponse> RestoreRecycleItemsAsync(string recycleBinId, RestoreRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemsHeaders headers = new RestoreRecycleItemsHeaders();
            return await RestoreRecycleItemsWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertDentryVersionRequest
        /// </param>
        /// <param name="headers">
        /// RevertDentryVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertDentryVersionResponse
        /// </returns>
        public RevertDentryVersionResponse RevertDentryVersionWithOptions(string spaceId, string dentryId, string version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RevertDentryVersion",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertDentryVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertDentryVersionRequest
        /// </param>
        /// <param name="headers">
        /// RevertDentryVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertDentryVersionResponse
        /// </returns>
        public async Task<RevertDentryVersionResponse> RevertDentryVersionWithOptionsAsync(string spaceId, string dentryId, string version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RevertDentryVersion",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertDentryVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertDentryVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertDentryVersionResponse
        /// </returns>
        public RevertDentryVersionResponse RevertDentryVersion(string spaceId, string dentryId, string version, RevertDentryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
            return RevertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复文件历史版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertDentryVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertDentryVersionResponse
        /// </returns>
        public async Task<RevertDentryVersionResponse> RevertDentryVersionAsync(string spaceId, string dentryId, string version, RevertDentryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
            return await RevertDentryVersionWithOptionsAsync(spaceId, dentryId, version, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeEventRequest
        /// </param>
        /// <param name="headers">
        /// SubscribeEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeEventResponse
        /// </returns>
        public SubscribeEventResponse SubscribeEventWithOptions(SubscribeEventRequest request, SubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
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
                Action = "SubscribeEvent",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/events/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeEventRequest
        /// </param>
        /// <param name="headers">
        /// SubscribeEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeEventResponse
        /// </returns>
        public async Task<SubscribeEventResponse> SubscribeEventWithOptionsAsync(SubscribeEventRequest request, SubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
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
                Action = "SubscribeEvent",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/events/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeEventResponse
        /// </returns>
        public SubscribeEventResponse SubscribeEvent(SubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeEventHeaders headers = new SubscribeEventHeaders();
            return SubscribeEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubscribeEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeEventResponse
        /// </returns>
        public async Task<SubscribeEventResponse> SubscribeEventAsync(SubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeEventHeaders headers = new SubscribeEventHeaders();
            return await SubscribeEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeEventRequest
        /// </param>
        /// <param name="headers">
        /// UnsubscribeEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeEventResponse
        /// </returns>
        public UnsubscribeEventResponse UnsubscribeEventWithOptions(UnsubscribeEventRequest request, UnsubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
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
                Action = "UnsubscribeEvent",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/events/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeEventRequest
        /// </param>
        /// <param name="headers">
        /// UnsubscribeEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeEventResponse
        /// </returns>
        public async Task<UnsubscribeEventResponse> UnsubscribeEventWithOptionsAsync(UnsubscribeEventRequest request, UnsubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
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
                Action = "UnsubscribeEvent",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/events/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeEventResponse
        /// </returns>
        public UnsubscribeEventResponse UnsubscribeEvent(UnsubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeEventHeaders headers = new UnsubscribeEventHeaders();
            return UnsubscribeEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订阅文件变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeEventResponse
        /// </returns>
        public async Task<UnsubscribeEventResponse> UnsubscribeEventAsync(UnsubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeEventHeaders headers = new UnsubscribeEventHeaders();
            return await UnsubscribeEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDentryAppPropertiesRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDentryAppPropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDentryAppPropertiesResponse
        /// </returns>
        public UpdateDentryAppPropertiesResponse UpdateDentryAppPropertiesWithOptions(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppProperties))
            {
                body["appProperties"] = request.AppProperties;
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
                Action = "UpdateDentryAppProperties",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDentryAppPropertiesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDentryAppPropertiesRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDentryAppPropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDentryAppPropertiesResponse
        /// </returns>
        public async Task<UpdateDentryAppPropertiesResponse> UpdateDentryAppPropertiesWithOptionsAsync(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppProperties))
            {
                body["appProperties"] = request.AppProperties;
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
                Action = "UpdateDentryAppProperties",
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDentryAppPropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDentryAppPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDentryAppPropertiesResponse
        /// </returns>
        public UpdateDentryAppPropertiesResponse UpdateDentryAppProperties(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
            return UpdateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改文件上的App属性值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDentryAppPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDentryAppPropertiesResponse
        /// </returns>
        public async Task<UpdateDentryAppPropertiesResponse> UpdateDentryAppPropertiesAsync(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
            return await UpdateDentryAppPropertiesWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public UpdatePermissionResponse UpdatePermissionWithOptions(string spaceId, string dentryId, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public async Task<UpdatePermissionResponse> UpdatePermissionWithOptionsAsync(string spaceId, string dentryId, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "storage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public UpdatePermissionResponse UpdatePermission(string spaceId, string dentryId, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return UpdatePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public async Task<UpdatePermissionResponse> UpdatePermissionAsync(string spaceId, string dentryId, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return await UpdatePermissionWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

    }
}
