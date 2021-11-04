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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddCustomSpaceResponse AddCustomSpace(AddCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
            return AddCustomSpaceWithOptions(request, headers, runtime);
        }

        public async Task<AddCustomSpaceResponse> AddCustomSpaceAsync(AddCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
            return await AddCustomSpaceWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCustomSpaceResponse>(DoROARequest("AddCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/customSpaces", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCustomSpaceResponse>(await DoROARequestAsync("AddCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/customSpaces", "json", req, runtime));
        }

        public AddFileResponse AddFile(string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return AddFileWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<AddFileResponse> AddFileAsync(string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return await AddFileWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public AddFileResponse AddFileWithOptions(string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddFileResponse>(DoROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public async Task<AddFileResponse> AddFileWithOptionsAsync(string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddFileResponse>(await DoROARequestAsync("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public AddPermissionResponse AddPermission(string fileId, string spaceId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return AddPermissionWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<AddPermissionResponse> AddPermissionAsync(string fileId, string spaceId, AddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPermissionHeaders headers = new AddPermissionHeaders();
            return await AddPermissionWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public AddPermissionResponse AddPermissionWithOptions(string fileId, string spaceId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddPermissionResponse>(DoROARequest("AddPermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime));
        }

        public async Task<AddPermissionResponse> AddPermissionWithOptionsAsync(string fileId, string spaceId, AddPermissionRequest request, AddPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddPermissionResponse>(await DoROARequestAsync("AddPermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime));
        }

        public AddSpaceResponse AddSpace(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return AddSpaceWithOptions(request, headers, runtime);
        }

        public async Task<AddSpaceResponse> AddSpaceAsync(AddSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSpaceHeaders headers = new AddSpaceHeaders();
            return await AddSpaceWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddSpaceResponse>(DoROARequest("AddSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddSpaceResponse>(await DoROARequestAsync("AddSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces", "json", req, runtime));
        }

        public ClearRecycleFilesResponse ClearRecycleFiles(ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return ClearRecycleFilesWithOptions(request, headers, runtime);
        }

        public async Task<ClearRecycleFilesResponse> ClearRecycleFilesAsync(ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return await ClearRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ClearRecycleFilesResponse>(DoROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/clear", "none", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ClearRecycleFilesResponse>(await DoROARequestAsync("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/clear", "none", req, runtime));
        }

        public CopyFileResponse CopyFile(string fileId, string spaceId, CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyFileHeaders headers = new CopyFileHeaders();
            return CopyFileWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<CopyFileResponse> CopyFileAsync(string fileId, string spaceId, CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyFileHeaders headers = new CopyFileHeaders();
            return await CopyFileWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public CopyFileResponse CopyFileWithOptions(string fileId, string spaceId, CopyFileRequest request, CopyFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CopyFileResponse>(DoROARequest("CopyFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/copy", "json", req, runtime));
        }

        public async Task<CopyFileResponse> CopyFileWithOptionsAsync(string fileId, string spaceId, CopyFileRequest request, CopyFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CopyFileResponse>(await DoROARequestAsync("CopyFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/copy", "json", req, runtime));
        }

        public DeleteFileResponse DeleteFile(string fileId, string spaceId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return DeleteFileWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(string fileId, string spaceId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return await DeleteFileWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(string fileId, string spaceId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFileResponse>(DoROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string fileId, string spaceId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFileResponse>(await DoROARequestAsync("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public DeleteFilesResponse DeleteFiles(string spaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFilesHeaders headers = new DeleteFilesHeaders();
            return DeleteFilesWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<DeleteFilesResponse> DeleteFilesAsync(string spaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFilesHeaders headers = new DeleteFilesHeaders();
            return await DeleteFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public DeleteFilesResponse DeleteFilesWithOptions(string spaceId, DeleteFilesRequest request, DeleteFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteFilesResponse>(DoROARequest("DeleteFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/batchDelete", "json", req, runtime));
        }

        public async Task<DeleteFilesResponse> DeleteFilesWithOptionsAsync(string spaceId, DeleteFilesRequest request, DeleteFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteFilesResponse>(await DoROARequestAsync("DeleteFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/batchDelete", "json", req, runtime));
        }

        public DeletePermissionResponse DeletePermission(string fileId, string spaceId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return DeletePermissionWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<DeletePermissionResponse> DeletePermissionAsync(string fileId, string spaceId, DeletePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePermissionHeaders headers = new DeletePermissionHeaders();
            return await DeletePermissionWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public DeletePermissionResponse DeletePermissionWithOptions(string fileId, string spaceId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeletePermissionResponse>(DoROARequest("DeletePermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete", "none", req, runtime));
        }

        public async Task<DeletePermissionResponse> DeletePermissionWithOptionsAsync(string fileId, string spaceId, DeletePermissionRequest request, DeletePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeletePermissionResponse>(await DoROARequestAsync("DeletePermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete", "none", req, runtime));
        }

        public DeleteRecycleFilesResponse DeleteRecycleFiles(DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return DeleteRecycleFilesWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRecycleFilesResponse> DeleteRecycleFilesAsync(DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return await DeleteRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(DoROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/delete", "none", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(await DoROARequestAsync("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/delete", "none", req, runtime));
        }

        public DeleteSpaceResponse DeleteSpace(string spaceId, DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return DeleteSpaceWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(string spaceId, DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return await DeleteSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public DeleteSpaceResponse DeleteSpaceWithOptions(string spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(DoROARequest("DeleteSpace", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId, "none", req, runtime));
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceWithOptionsAsync(string spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(await DoROARequestAsync("DeleteSpace", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId, "none", req, runtime));
        }

        public GetAsyncTaskInfoResponse GetAsyncTaskInfo(string taskId, GetAsyncTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAsyncTaskInfoHeaders headers = new GetAsyncTaskInfoHeaders();
            return GetAsyncTaskInfoWithOptions(taskId, request, headers, runtime);
        }

        public async Task<GetAsyncTaskInfoResponse> GetAsyncTaskInfoAsync(string taskId, GetAsyncTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAsyncTaskInfoHeaders headers = new GetAsyncTaskInfoHeaders();
            return await GetAsyncTaskInfoWithOptionsAsync(taskId, request, headers, runtime);
        }

        public GetAsyncTaskInfoResponse GetAsyncTaskInfoWithOptions(string taskId, GetAsyncTaskInfoRequest request, GetAsyncTaskInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAsyncTaskInfoResponse>(DoROARequest("GetAsyncTaskInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<GetAsyncTaskInfoResponse> GetAsyncTaskInfoWithOptionsAsync(string taskId, GetAsyncTaskInfoRequest request, GetAsyncTaskInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAsyncTaskInfoResponse>(await DoROARequestAsync("GetAsyncTaskInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/tasks/" + taskId, "json", req, runtime));
        }

        public GetDownloadInfoResponse GetDownloadInfo(string fileId, string spaceId, GetDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return GetDownloadInfoWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoAsync(string fileId, string spaceId, GetDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return await GetDownloadInfoWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public GetDownloadInfoResponse GetDownloadInfoWithOptions(string fileId, string spaceId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(DoROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime));
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoWithOptionsAsync(string fileId, string spaceId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(await DoROARequestAsync("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime));
        }

        public GetFileInfoResponse GetFileInfo(string fileId, string spaceId, GetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return GetFileInfoWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<GetFileInfoResponse> GetFileInfoAsync(string fileId, string spaceId, GetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return await GetFileInfoWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public GetFileInfoResponse GetFileInfoWithOptions(string fileId, string spaceId, GetFileInfoRequest request, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileInfoResponse>(DoROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public async Task<GetFileInfoResponse> GetFileInfoWithOptionsAsync(string fileId, string spaceId, GetFileInfoRequest request, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileInfoResponse>(await DoROARequestAsync("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public GetPrivilegeInfoResponse GetPrivilegeInfo(string fileId, string spaceId, GetPrivilegeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrivilegeInfoHeaders headers = new GetPrivilegeInfoHeaders();
            return GetPrivilegeInfoWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<GetPrivilegeInfoResponse> GetPrivilegeInfoAsync(string fileId, string spaceId, GetPrivilegeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrivilegeInfoHeaders headers = new GetPrivilegeInfoHeaders();
            return await GetPrivilegeInfoWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public GetPrivilegeInfoResponse GetPrivilegeInfoWithOptions(string fileId, string spaceId, GetPrivilegeInfoRequest request, GetPrivilegeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPrivilegeInfoResponse>(DoROARequest("GetPrivilegeInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/privileges", "json", req, runtime));
        }

        public async Task<GetPrivilegeInfoResponse> GetPrivilegeInfoWithOptionsAsync(string fileId, string spaceId, GetPrivilegeInfoRequest request, GetPrivilegeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPrivilegeInfoResponse>(await DoROARequestAsync("GetPrivilegeInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/privileges", "json", req, runtime));
        }

        public GetQuotaInfosResponse GetQuotaInfos(GetQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQuotaInfosHeaders headers = new GetQuotaInfosHeaders();
            return GetQuotaInfosWithOptions(request, headers, runtime);
        }

        public async Task<GetQuotaInfosResponse> GetQuotaInfosAsync(GetQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQuotaInfosHeaders headers = new GetQuotaInfosHeaders();
            return await GetQuotaInfosWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetQuotaInfosResponse>(DoROARequest("GetQuotaInfos", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/quotaInfos/query", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetQuotaInfosResponse>(await DoROARequestAsync("GetQuotaInfos", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/quotaInfos/query", "json", req, runtime));
        }

        public GetUploadInfoResponse GetUploadInfo(string parentId, string spaceId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return GetUploadInfoWithOptions(parentId, spaceId, request, headers, runtime);
        }

        public async Task<GetUploadInfoResponse> GetUploadInfoAsync(string parentId, string spaceId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return await GetUploadInfoWithOptionsAsync(parentId, spaceId, request, headers, runtime);
        }

        public GetUploadInfoResponse GetUploadInfoWithOptions(string parentId, string spaceId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(DoROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime));
        }

        public async Task<GetUploadInfoResponse> GetUploadInfoWithOptionsAsync(string parentId, string spaceId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(await DoROARequestAsync("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime));
        }

        public GrantPrivilegeOfCustomSpaceResponse GrantPrivilegeOfCustomSpace(string spaceId, GrantPrivilegeOfCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
            return GrantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<GrantPrivilegeOfCustomSpaceResponse> GrantPrivilegeOfCustomSpaceAsync(string spaceId, GrantPrivilegeOfCustomSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
            return await GrantPrivilegeOfCustomSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public GrantPrivilegeOfCustomSpaceResponse GrantPrivilegeOfCustomSpaceWithOptions(string spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GrantPrivilegeOfCustomSpaceResponse>(DoROARequest("GrantPrivilegeOfCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges", "none", req, runtime));
        }

        public async Task<GrantPrivilegeOfCustomSpaceResponse> GrantPrivilegeOfCustomSpaceWithOptionsAsync(string spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GrantPrivilegeOfCustomSpaceResponse>(await DoROARequestAsync("GrantPrivilegeOfCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges", "none", req, runtime));
        }

        public InfoSpaceResponse InfoSpace(string spaceId, InfoSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InfoSpaceHeaders headers = new InfoSpaceHeaders();
            return InfoSpaceWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<InfoSpaceResponse> InfoSpaceAsync(string spaceId, InfoSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InfoSpaceHeaders headers = new InfoSpaceHeaders();
            return await InfoSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public InfoSpaceResponse InfoSpaceWithOptions(string spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InfoSpaceResponse>(DoROARequest("InfoSpace", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId, "json", req, runtime));
        }

        public async Task<InfoSpaceResponse> InfoSpaceWithOptionsAsync(string spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InfoSpaceResponse>(await DoROARequestAsync("InfoSpace", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId, "json", req, runtime));
        }

        public ListFilesResponse ListFiles(string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return ListFilesWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<ListFilesResponse> ListFilesAsync(string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return await ListFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public ListFilesResponse ListFilesWithOptions(string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFilesResponse>(DoROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFilesResponse>(await DoROARequestAsync("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public ListPermissionsResponse ListPermissions(string fileId, string spaceId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return ListPermissionsWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<ListPermissionsResponse> ListPermissionsAsync(string fileId, string spaceId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPermissionsHeaders headers = new ListPermissionsHeaders();
            return await ListPermissionsWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public ListPermissionsResponse ListPermissionsWithOptions(string fileId, string spaceId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPermissionsResponse>(DoROARequest("ListPermissions", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "json", req, runtime));
        }

        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string fileId, string spaceId, ListPermissionsRequest request, ListPermissionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await DoROARequestAsync("ListPermissions", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "json", req, runtime));
        }

        public ListRecycleFilesResponse ListRecycleFiles(ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return ListRecycleFilesWithOptions(request, headers, runtime);
        }

        public async Task<ListRecycleFilesResponse> ListRecycleFilesAsync(ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return await ListRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRecycleFilesResponse>(DoROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/recycleItems", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRecycleFilesResponse>(await DoROARequestAsync("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/recycleItems", "json", req, runtime));
        }

        public ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return ListSpacesWithOptions(request, headers, runtime);
        }

        public async Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return await ListSpacesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSpacesResponse>(DoROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSpacesResponse>(await DoROARequestAsync("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces", "json", req, runtime));
        }

        public ManagementBuyQuotaResponse ManagementBuyQuota(ManagementBuyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementBuyQuotaHeaders headers = new ManagementBuyQuotaHeaders();
            return ManagementBuyQuotaWithOptions(request, headers, runtime);
        }

        public async Task<ManagementBuyQuotaResponse> ManagementBuyQuotaAsync(ManagementBuyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementBuyQuotaHeaders headers = new ManagementBuyQuotaHeaders();
            return await ManagementBuyQuotaWithOptionsAsync(request, headers, runtime);
        }

        public ManagementBuyQuotaResponse ManagementBuyQuotaWithOptions(ManagementBuyQuotaRequest request, ManagementBuyQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementBuyQuotaResponse>(DoROARequest("ManagementBuyQuota", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/managements/quotas/buy", "none", req, runtime));
        }

        public async Task<ManagementBuyQuotaResponse> ManagementBuyQuotaWithOptionsAsync(ManagementBuyQuotaRequest request, ManagementBuyQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementBuyQuotaResponse>(await DoROARequestAsync("ManagementBuyQuota", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/managements/quotas/buy", "none", req, runtime));
        }

        public ManagementListSpacesResponse ManagementListSpaces(ManagementListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementListSpacesHeaders headers = new ManagementListSpacesHeaders();
            return ManagementListSpacesWithOptions(request, headers, runtime);
        }

        public async Task<ManagementListSpacesResponse> ManagementListSpacesAsync(ManagementListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementListSpacesHeaders headers = new ManagementListSpacesHeaders();
            return await ManagementListSpacesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementListSpacesResponse>(DoROARequest("ManagementListSpaces", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/managements/spaces/query", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementListSpacesResponse>(await DoROARequestAsync("ManagementListSpaces", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/managements/spaces/query", "json", req, runtime));
        }

        public ManagementModifySpaceResponse ManagementModifySpace(ManagementModifySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementModifySpaceHeaders headers = new ManagementModifySpaceHeaders();
            return ManagementModifySpaceWithOptions(request, headers, runtime);
        }

        public async Task<ManagementModifySpaceResponse> ManagementModifySpaceAsync(ManagementModifySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManagementModifySpaceHeaders headers = new ManagementModifySpaceHeaders();
            return await ManagementModifySpaceWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementModifySpaceResponse>(DoROARequest("ManagementModifySpace", "drive_1.0", "HTTP", "PUT", "AK", "/v1.0/drive/managements/spaces", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ManagementModifySpaceResponse>(await DoROARequestAsync("ManagementModifySpace", "drive_1.0", "HTTP", "PUT", "AK", "/v1.0/drive/managements/spaces", "json", req, runtime));
        }

        public ModifyPermissionResponse ModifyPermission(string fileId, string spaceId, ModifyPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
            return ModifyPermissionWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<ModifyPermissionResponse> ModifyPermissionAsync(string fileId, string spaceId, ModifyPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
            return await ModifyPermissionWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public ModifyPermissionResponse ModifyPermissionWithOptions(string fileId, string spaceId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyPermissionResponse>(DoROARequest("ModifyPermission", "drive_1.0", "HTTP", "PUT", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime));
        }

        public async Task<ModifyPermissionResponse> ModifyPermissionWithOptionsAsync(string fileId, string spaceId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyPermissionResponse>(await DoROARequestAsync("ModifyPermission", "drive_1.0", "HTTP", "PUT", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime));
        }

        public MoveFileResponse MoveFile(string fileId, string spaceId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return MoveFileWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<MoveFileResponse> MoveFileAsync(string fileId, string spaceId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return await MoveFileWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public MoveFileResponse MoveFileWithOptions(string fileId, string spaceId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveFileResponse>(DoROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime));
        }

        public async Task<MoveFileResponse> MoveFileWithOptionsAsync(string fileId, string spaceId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveFileResponse>(await DoROARequestAsync("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime));
        }

        public MoveFilesResponse MoveFiles(string spaceId, MoveFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFilesHeaders headers = new MoveFilesHeaders();
            return MoveFilesWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<MoveFilesResponse> MoveFilesAsync(string spaceId, MoveFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFilesHeaders headers = new MoveFilesHeaders();
            return await MoveFilesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public MoveFilesResponse MoveFilesWithOptions(string spaceId, MoveFilesRequest request, MoveFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveFilesResponse>(DoROARequest("MoveFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/batchMove", "json", req, runtime));
        }

        public async Task<MoveFilesResponse> MoveFilesWithOptionsAsync(string spaceId, MoveFilesRequest request, MoveFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveFilesResponse>(await DoROARequestAsync("MoveFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/batchMove", "json", req, runtime));
        }

        public RecoverRecycleFilesResponse RecoverRecycleFiles(RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return RecoverRecycleFilesWithOptions(request, headers, runtime);
        }

        public async Task<RecoverRecycleFilesResponse> RecoverRecycleFilesAsync(RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return await RecoverRecycleFilesWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(DoROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/recover", "none", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(await DoROARequestAsync("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/recover", "none", req, runtime));
        }

        public RenameFileResponse RenameFile(string fileId, string spaceId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return RenameFileWithOptions(fileId, spaceId, request, headers, runtime);
        }

        public async Task<RenameFileResponse> RenameFileAsync(string fileId, string spaceId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return await RenameFileWithOptionsAsync(fileId, spaceId, request, headers, runtime);
        }

        public RenameFileResponse RenameFileWithOptions(string fileId, string spaceId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RenameFileResponse>(DoROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime));
        }

        public async Task<RenameFileResponse> RenameFileWithOptionsAsync(string fileId, string spaceId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RenameFileResponse>(await DoROARequestAsync("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime));
        }

    }
}
