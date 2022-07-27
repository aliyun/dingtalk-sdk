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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddFolderResponse AddFolder(string spaceId, string parentId, AddFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFolderHeaders headers = new AddFolderHeaders();
            return AddFolderWithOptions(spaceId, parentId, request, headers, runtime);
        }

        public async Task<AddFolderResponse> AddFolderAsync(string spaceId, string parentId, AddFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFolderHeaders headers = new AddFolderHeaders();
            return await AddFolderWithOptionsAsync(spaceId, parentId, request, headers, runtime);
        }

        public AddFolderResponse AddFolderWithOptions(string spaceId, string parentId, AddFolderRequest request, AddFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<AddFolderResponse>(DoROARequest("AddFolder", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders", "json", req, runtime));
        }

        public async Task<AddFolderResponse> AddFolderWithOptionsAsync(string spaceId, string parentId, AddFolderRequest request, AddFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<AddFolderResponse>(await DoROARequestAsync("AddFolder", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders", "json", req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<AddSpaceResponse>(DoROARequest("AddSpace", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces", "json", req, runtime));
        }

        public async Task<AddSpaceResponse> AddSpaceWithOptionsAsync(AddSpaceRequest request, AddSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<AddSpaceResponse>(await DoROARequestAsync("AddSpace", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces", "json", req, runtime));
        }

        public ClearRecycleBinResponse ClearRecycleBin(string recycleBinId, ClearRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
            return ClearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
        }

        public async Task<ClearRecycleBinResponse> ClearRecycleBinAsync(string recycleBinId, ClearRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
            return await ClearRecycleBinWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        public ClearRecycleBinResponse ClearRecycleBinWithOptions(string recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<ClearRecycleBinResponse>(DoROARequest("ClearRecycleBin", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/clear", "json", req, runtime));
        }

        public async Task<ClearRecycleBinResponse> ClearRecycleBinWithOptionsAsync(string recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<ClearRecycleBinResponse>(await DoROARequestAsync("ClearRecycleBin", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/clear", "json", req, runtime));
        }

        public CommitFileResponse CommitFile(string spaceId, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return CommitFileWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<CommitFileResponse> CommitFileAsync(string spaceId, CommitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitFileHeaders headers = new CommitFileHeaders();
            return await CommitFileWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public CommitFileResponse CommitFileWithOptions(string spaceId, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<CommitFileResponse>(DoROARequest("CommitFile", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/commit", "json", req, runtime));
        }

        public async Task<CommitFileResponse> CommitFileWithOptionsAsync(string spaceId, CommitFileRequest request, CommitFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<CommitFileResponse>(await DoROARequestAsync("CommitFile", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/commit", "json", req, runtime));
        }

        public CopyDentryResponse CopyDentry(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return CopyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<CopyDentryResponse> CopyDentryAsync(string spaceId, string dentryId, CopyDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyDentryHeaders headers = new CopyDentryHeaders();
            return await CopyDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public CopyDentryResponse CopyDentryWithOptions(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<CopyDentryResponse>(DoROARequest("CopyDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime));
        }

        public async Task<CopyDentryResponse> CopyDentryWithOptionsAsync(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<CopyDentryResponse>(await DoROARequestAsync("CopyDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime));
        }

        public DeleteDentryResponse DeleteDentry(string spaceId, string dentryId, DeleteDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryHeaders headers = new DeleteDentryHeaders();
            return DeleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<DeleteDentryResponse> DeleteDentryAsync(string spaceId, string dentryId, DeleteDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryHeaders headers = new DeleteDentryHeaders();
            return await DeleteDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public DeleteDentryResponse DeleteDentryWithOptions(string spaceId, string dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<DeleteDentryResponse>(DoROARequest("DeleteDentry", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId, "json", req, runtime));
        }

        public async Task<DeleteDentryResponse> DeleteDentryWithOptionsAsync(string spaceId, string dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<DeleteDentryResponse>(await DoROARequestAsync("DeleteDentry", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId, "json", req, runtime));
        }

        public DeleteDentryAppPropertiesResponse DeleteDentryAppProperties(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
            return DeleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<DeleteDentryAppPropertiesResponse> DeleteDentryAppPropertiesAsync(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
            return await DeleteDentryAppPropertiesWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public DeleteDentryAppPropertiesResponse DeleteDentryAppPropertiesWithOptions(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<DeleteDentryAppPropertiesResponse>(DoROARequest("DeleteDentryAppProperties", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove", "json", req, runtime));
        }

        public async Task<DeleteDentryAppPropertiesResponse> DeleteDentryAppPropertiesWithOptionsAsync(string spaceId, string dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<DeleteDentryAppPropertiesResponse>(await DoROARequestAsync("DeleteDentryAppProperties", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove", "json", req, runtime));
        }

        public DeleteRecycleItemResponse DeleteRecycleItem(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
            return DeleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public async Task<DeleteRecycleItemResponse> DeleteRecycleItemAsync(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
            return await DeleteRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public DeleteRecycleItemResponse DeleteRecycleItemWithOptions(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
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
            return TeaModel.ToObject<DeleteRecycleItemResponse>(DoROARequest("DeleteRecycleItem", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId, "json", req, runtime));
        }

        public async Task<DeleteRecycleItemResponse> DeleteRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
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
            return TeaModel.ToObject<DeleteRecycleItemResponse>(await DoROARequestAsync("DeleteRecycleItem", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId, "json", req, runtime));
        }

        public DeleteRecycleItemsResponse DeleteRecycleItems(string recycleBinId, DeleteRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
            return DeleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
        }

        public async Task<DeleteRecycleItemsResponse> DeleteRecycleItemsAsync(string recycleBinId, DeleteRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
            return await DeleteRecycleItemsWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        public DeleteRecycleItemsResponse DeleteRecycleItemsWithOptions(string recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<DeleteRecycleItemsResponse>(DoROARequest("DeleteRecycleItems", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove", "json", req, runtime));
        }

        public async Task<DeleteRecycleItemsResponse> DeleteRecycleItemsWithOptionsAsync(string recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<DeleteRecycleItemsResponse>(await DoROARequestAsync("DeleteRecycleItems", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove", "json", req, runtime));
        }

        public GetCurrentAppResponse GetCurrentApp(GetCurrentAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
            return GetCurrentAppWithOptions(request, headers, runtime);
        }

        public async Task<GetCurrentAppResponse> GetCurrentAppAsync(GetCurrentAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
            return await GetCurrentAppWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetCurrentAppResponse>(DoROARequest("GetCurrentApp", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/currentApps/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetCurrentAppResponse>(await DoROARequestAsync("GetCurrentApp", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/currentApps/query", "json", req, runtime));
        }

        public GetDentryResponse GetDentry(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return GetDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<GetDentryResponse> GetDentryAsync(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return await GetDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public GetDentryResponse GetDentryWithOptions(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetDentryResponse>(DoROARequest("GetDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query", "json", req, runtime));
        }

        public async Task<GetDentryResponse> GetDentryWithOptionsAsync(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetDentryResponse>(await DoROARequestAsync("GetDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query", "json", req, runtime));
        }

        public GetFileDownloadInfoResponse GetFileDownloadInfo(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return GetFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return await GetFileDownloadInfoWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public GetFileDownloadInfoResponse GetFileDownloadInfoWithOptions(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(DoROARequest("GetFileDownloadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query", "json", req, runtime));
        }

        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoWithOptionsAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(await DoROARequestAsync("GetFileDownloadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query", "json", req, runtime));
        }

        public GetFileUploadInfoResponse GetFileUploadInfo(string spaceId, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return GetFileUploadInfoWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoAsync(string spaceId, GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return await GetFileUploadInfoWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public GetFileUploadInfoResponse GetFileUploadInfoWithOptions(string spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetFileUploadInfoResponse>(DoROARequest("GetFileUploadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query", "json", req, runtime));
        }

        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoWithOptionsAsync(string spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await DoROARequestAsync("GetFileUploadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query", "json", req, runtime));
        }

        public GetRecycleBinResponse GetRecycleBin(GetRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
            return GetRecycleBinWithOptions(request, headers, runtime);
        }

        public async Task<GetRecycleBinResponse> GetRecycleBinAsync(GetRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
            return await GetRecycleBinWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetRecycleBinResponse>(DoROARequest("GetRecycleBin", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetRecycleBinResponse>(await DoROARequestAsync("GetRecycleBin", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins", "json", req, runtime));
        }

        public GetRecycleItemResponse GetRecycleItem(string recycleBinId, string recycleItemId, GetRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
            return GetRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public async Task<GetRecycleItemResponse> GetRecycleItemAsync(string recycleBinId, string recycleItemId, GetRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
            return await GetRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public GetRecycleItemResponse GetRecycleItemWithOptions(string recycleBinId, string recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
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
            return TeaModel.ToObject<GetRecycleItemResponse>(DoROARequest("GetRecycleItem", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId, "json", req, runtime));
        }

        public async Task<GetRecycleItemResponse> GetRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
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
            return TeaModel.ToObject<GetRecycleItemResponse>(await DoROARequestAsync("GetRecycleItem", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId, "json", req, runtime));
        }

        public GetSpaceResponse GetSpace(string spaceId, GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return GetSpaceWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<GetSpaceResponse> GetSpaceAsync(string spaceId, GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return await GetSpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public GetSpaceResponse GetSpaceWithOptions(string spaceId, GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSpaceResponse>(DoROARequest("GetSpace", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId, "json", req, runtime));
        }

        public async Task<GetSpaceResponse> GetSpaceWithOptionsAsync(string spaceId, GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSpaceResponse>(await DoROARequestAsync("GetSpace", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId, "json", req, runtime));
        }

        public ListDentriesResponse ListDentries(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return ListDentriesWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<ListDentriesResponse> ListDentriesAsync(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return await ListDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public ListDentriesResponse ListDentriesWithOptions(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDentriesResponse>(DoROARequest("ListDentries", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries", "json", req, runtime));
        }

        public async Task<ListDentriesResponse> ListDentriesWithOptionsAsync(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDentriesResponse>(await DoROARequestAsync("ListDentries", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries", "json", req, runtime));
        }

        public ListDentryVersionsResponse ListDentryVersions(string spaceId, string dentryId, ListDentryVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
            return ListDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<ListDentryVersionsResponse> ListDentryVersionsAsync(string spaceId, string dentryId, ListDentryVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
            return await ListDentryVersionsWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public ListDentryVersionsResponse ListDentryVersionsWithOptions(string spaceId, string dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<ListDentryVersionsResponse>(DoROARequest("ListDentryVersions", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions", "json", req, runtime));
        }

        public async Task<ListDentryVersionsResponse> ListDentryVersionsWithOptionsAsync(string spaceId, string dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<ListDentryVersionsResponse>(await DoROARequestAsync("ListDentryVersions", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions", "json", req, runtime));
        }

        public ListRecycleItemsResponse ListRecycleItems(string recycleBinId, ListRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
            return ListRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
        }

        public async Task<ListRecycleItemsResponse> ListRecycleItemsAsync(string recycleBinId, ListRecycleItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
            return await ListRecycleItemsWithOptionsAsync(recycleBinId, request, headers, runtime);
        }

        public ListRecycleItemsResponse ListRecycleItemsWithOptions(string recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<ListRecycleItemsResponse>(DoROARequest("ListRecycleItems", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems", "json", req, runtime));
        }

        public async Task<ListRecycleItemsResponse> ListRecycleItemsWithOptionsAsync(string recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
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
            return TeaModel.ToObject<ListRecycleItemsResponse>(await DoROARequestAsync("ListRecycleItems", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems", "json", req, runtime));
        }

        public MoveDentryResponse MoveDentry(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return MoveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<MoveDentryResponse> MoveDentryAsync(string spaceId, string dentryId, MoveDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveDentryHeaders headers = new MoveDentryHeaders();
            return await MoveDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public MoveDentryResponse MoveDentryWithOptions(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<MoveDentryResponse>(DoROARequest("MoveDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime));
        }

        public async Task<MoveDentryResponse> MoveDentryWithOptionsAsync(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<MoveDentryResponse>(await DoROARequestAsync("MoveDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime));
        }

        public RenameDentryResponse RenameDentry(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return RenameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<RenameDentryResponse> RenameDentryAsync(string spaceId, string dentryId, RenameDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameDentryHeaders headers = new RenameDentryHeaders();
            return await RenameDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public RenameDentryResponse RenameDentryWithOptions(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<RenameDentryResponse>(DoROARequest("RenameDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime));
        }

        public async Task<RenameDentryResponse> RenameDentryWithOptionsAsync(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<RenameDentryResponse>(await DoROARequestAsync("RenameDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime));
        }

        public RestoreRecycleItemResponse RestoreRecycleItem(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
            return RestoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public async Task<RestoreRecycleItemResponse> RestoreRecycleItemAsync(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
            return await RestoreRecycleItemWithOptionsAsync(recycleBinId, recycleItemId, request, headers, runtime);
        }

        public RestoreRecycleItemResponse RestoreRecycleItemWithOptions(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<RestoreRecycleItemResponse>(DoROARequest("RestoreRecycleItem", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore", "json", req, runtime));
        }

        public async Task<RestoreRecycleItemResponse> RestoreRecycleItemWithOptionsAsync(string recycleBinId, string recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            recycleBinId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleBinId);
            recycleItemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(recycleItemId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option.ToMap()))
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
            return TeaModel.ToObject<RestoreRecycleItemResponse>(await DoROARequestAsync("RestoreRecycleItem", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore", "json", req, runtime));
        }

        public RevertDentryVersionResponse RevertDentryVersion(string spaceId, string dentryId, string version, RevertDentryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
            return RevertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
        }

        public async Task<RevertDentryVersionResponse> RevertDentryVersionAsync(string spaceId, string dentryId, string version, RevertDentryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
            return await RevertDentryVersionWithOptionsAsync(spaceId, dentryId, version, request, headers, runtime);
        }

        public RevertDentryVersionResponse RevertDentryVersionWithOptions(string spaceId, string dentryId, string version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
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
            return TeaModel.ToObject<RevertDentryVersionResponse>(DoROARequest("RevertDentryVersion", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert", "json", req, runtime));
        }

        public async Task<RevertDentryVersionResponse> RevertDentryVersionWithOptionsAsync(string spaceId, string dentryId, string version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
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
            return TeaModel.ToObject<RevertDentryVersionResponse>(await DoROARequestAsync("RevertDentryVersion", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert", "json", req, runtime));
        }

        public UpdateDentryAppPropertiesResponse UpdateDentryAppProperties(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
            return UpdateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<UpdateDentryAppPropertiesResponse> UpdateDentryAppPropertiesAsync(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
            return await UpdateDentryAppPropertiesWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public UpdateDentryAppPropertiesResponse UpdateDentryAppPropertiesWithOptions(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<UpdateDentryAppPropertiesResponse>(DoROARequest("UpdateDentryAppProperties", "storage_1.0", "HTTP", "PUT", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties", "json", req, runtime));
        }

        public async Task<UpdateDentryAppPropertiesResponse> UpdateDentryAppPropertiesWithOptionsAsync(string spaceId, string dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
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
            return TeaModel.ToObject<UpdateDentryAppPropertiesResponse>(await DoROARequestAsync("UpdateDentryAppProperties", "storage_1.0", "HTTP", "PUT", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties", "json", req, runtime));
        }

    }
}
