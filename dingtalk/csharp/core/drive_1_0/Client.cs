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


        public AddFileResponse AddFile(string unionId, string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return AddFileWithOptions(unionId, spaceId, request, headers, runtime);
        }

        public async Task<AddFileResponse> AddFileAsync(string unionId, string spaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return await AddFileWithOptionsAsync(unionId, spaceId, request, headers, runtime);
        }

        public AddFileResponse AddFileWithOptions(string unionId, string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
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
            return TeaModel.ToObject<AddFileResponse>(DoROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public async Task<AddFileResponse> AddFileWithOptionsAsync(string unionId, string spaceId, AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
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
            return TeaModel.ToObject<AddFileResponse>(await DoROARequestAsync("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public RecoverRecycleFilesResponse RecoverRecycleFiles(string unionId, RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return RecoverRecycleFilesWithOptions(unionId, request, headers, runtime);
        }

        public async Task<RecoverRecycleFilesResponse> RecoverRecycleFilesAsync(string unionId, RecoverRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
            return await RecoverRecycleFilesWithOptionsAsync(unionId, request, headers, runtime);
        }

        public RecoverRecycleFilesResponse RecoverRecycleFilesWithOptions(string unionId, RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(DoROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/recover", "none", req, runtime));
        }

        public async Task<RecoverRecycleFilesResponse> RecoverRecycleFilesWithOptionsAsync(string unionId, RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<RecoverRecycleFilesResponse>(await DoROARequestAsync("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/recover", "none", req, runtime));
        }

        public DeleteRecycleFilesResponse DeleteRecycleFiles(string unionId, DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return DeleteRecycleFilesWithOptions(unionId, request, headers, runtime);
        }

        public async Task<DeleteRecycleFilesResponse> DeleteRecycleFilesAsync(string unionId, DeleteRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
            return await DeleteRecycleFilesWithOptionsAsync(unionId, request, headers, runtime);
        }

        public DeleteRecycleFilesResponse DeleteRecycleFilesWithOptions(string unionId, DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(DoROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/delete", "none", req, runtime));
        }

        public async Task<DeleteRecycleFilesResponse> DeleteRecycleFilesWithOptionsAsync(string unionId, DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteRecycleFilesResponse>(await DoROARequestAsync("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/delete", "none", req, runtime));
        }

        public GetFileInfoResponse GetFileInfo(string unionId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return GetFileInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
        }

        public async Task<GetFileInfoResponse> GetFileInfoAsync(string unionId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return await GetFileInfoWithOptionsAsync(unionId, spaceId, fileId, headers, runtime);
        }

        public GetFileInfoResponse GetFileInfoWithOptions(string unionId, string spaceId, string fileId, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetFileInfoResponse>(DoROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public async Task<GetFileInfoResponse> GetFileInfoWithOptionsAsync(string unionId, string spaceId, string fileId, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetFileInfoResponse>(await DoROARequestAsync("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public ListRecycleFilesResponse ListRecycleFiles(string unionId, ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return ListRecycleFilesWithOptions(unionId, request, headers, runtime);
        }

        public async Task<ListRecycleFilesResponse> ListRecycleFilesAsync(string unionId, ListRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
            return await ListRecycleFilesWithOptionsAsync(unionId, request, headers, runtime);
        }

        public ListRecycleFilesResponse ListRecycleFilesWithOptions(string unionId, ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                query["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
            return TeaModel.ToObject<ListRecycleFilesResponse>(DoROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems", "json", req, runtime));
        }

        public async Task<ListRecycleFilesResponse> ListRecycleFilesWithOptionsAsync(string unionId, ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                query["recycleType"] = request.RecycleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
            return TeaModel.ToObject<ListRecycleFilesResponse>(await DoROARequestAsync("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems", "json", req, runtime));
        }

        public RenameFileResponse RenameFile(string unionId, string spaceId, string fileId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return RenameFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
        }

        public async Task<RenameFileResponse> RenameFileAsync(string unionId, string spaceId, string fileId, RenameFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenameFileHeaders headers = new RenameFileHeaders();
            return await RenameFileWithOptionsAsync(unionId, spaceId, fileId, request, headers, runtime);
        }

        public RenameFileResponse RenameFileWithOptions(string unionId, string spaceId, string fileId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFileName))
            {
                body["newFileName"] = request.NewFileName;
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
            return TeaModel.ToObject<RenameFileResponse>(DoROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime));
        }

        public async Task<RenameFileResponse> RenameFileWithOptionsAsync(string unionId, string spaceId, string fileId, RenameFileRequest request, RenameFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFileName))
            {
                body["newFileName"] = request.NewFileName;
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
            return TeaModel.ToObject<RenameFileResponse>(await DoROARequestAsync("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime));
        }

        public ListFilesResponse ListFiles(string unionId, string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return ListFilesWithOptions(unionId, spaceId, request, headers, runtime);
        }

        public async Task<ListFilesResponse> ListFilesAsync(string unionId, string spaceId, ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFilesHeaders headers = new ListFilesHeaders();
            return await ListFilesWithOptionsAsync(unionId, spaceId, request, headers, runtime);
        }

        public ListFilesResponse ListFilesWithOptions(string unionId, string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListFilesResponse>(DoROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(string unionId, string spaceId, ListFilesRequest request, ListFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListFilesResponse>(await DoROARequestAsync("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime));
        }

        public MoveFileResponse MoveFile(string unionId, string spaceId, string fileId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return MoveFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
        }

        public async Task<MoveFileResponse> MoveFileAsync(string unionId, string spaceId, string fileId, MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveFileHeaders headers = new MoveFileHeaders();
            return await MoveFileWithOptionsAsync(unionId, spaceId, fileId, request, headers, runtime);
        }

        public MoveFileResponse MoveFileWithOptions(string unionId, string spaceId, string fileId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
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
            return TeaModel.ToObject<MoveFileResponse>(DoROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime));
        }

        public async Task<MoveFileResponse> MoveFileWithOptionsAsync(string unionId, string spaceId, string fileId, MoveFileRequest request, MoveFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetParentId))
            {
                body["targetParentId"] = request.TargetParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                body["addConflictPolicy"] = request.AddConflictPolicy;
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
            return TeaModel.ToObject<MoveFileResponse>(await DoROARequestAsync("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime));
        }

        public GetDownloadInfoResponse GetDownloadInfo(string unionId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return GetDownloadInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoAsync(string unionId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return await GetDownloadInfoWithOptionsAsync(unionId, spaceId, fileId, headers, runtime);
        }

        public GetDownloadInfoResponse GetDownloadInfoWithOptions(string unionId, string spaceId, string fileId, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(DoROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime));
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoWithOptionsAsync(string unionId, string spaceId, string fileId, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(await DoROARequestAsync("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime));
        }

        public GetUploadInfoResponse GetUploadInfo(string unionId, string spaceId, string parentId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return GetUploadInfoWithOptions(unionId, spaceId, parentId, request, headers, runtime);
        }

        public async Task<GetUploadInfoResponse> GetUploadInfoAsync(string unionId, string spaceId, string parentId, GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
            return await GetUploadInfoWithOptionsAsync(unionId, spaceId, parentId, request, headers, runtime);
        }

        public GetUploadInfoResponse GetUploadInfoWithOptions(string unionId, string spaceId, string parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
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
            return TeaModel.ToObject<GetUploadInfoResponse>(DoROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime));
        }

        public async Task<GetUploadInfoResponse> GetUploadInfoWithOptionsAsync(string unionId, string spaceId, string parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConflictPolicy))
            {
                query["addConflictPolicy"] = request.AddConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
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
            return TeaModel.ToObject<GetUploadInfoResponse>(await DoROARequestAsync("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime));
        }

        public ListSpacesResponse ListSpaces(string unionId, ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return ListSpacesWithOptions(unionId, request, headers, runtime);
        }

        public async Task<ListSpacesResponse> ListSpacesAsync(string unionId, ListSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpacesHeaders headers = new ListSpacesHeaders();
            return await ListSpacesWithOptionsAsync(unionId, request, headers, runtime);
        }

        public ListSpacesResponse ListSpacesWithOptions(string unionId, ListSpacesRequest request, ListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListSpacesResponse>(DoROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces", "json", req, runtime));
        }

        public async Task<ListSpacesResponse> ListSpacesWithOptionsAsync(string unionId, ListSpacesRequest request, ListSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListSpacesResponse>(await DoROARequestAsync("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces", "json", req, runtime));
        }

        public ClearRecycleFilesResponse ClearRecycleFiles(string unionId, ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return ClearRecycleFilesWithOptions(unionId, request, headers, runtime);
        }

        public async Task<ClearRecycleFilesResponse> ClearRecycleFilesAsync(string unionId, ClearRecycleFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
            return await ClearRecycleFilesWithOptionsAsync(unionId, request, headers, runtime);
        }

        public ClearRecycleFilesResponse ClearRecycleFilesWithOptions(string unionId, ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
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
            return TeaModel.ToObject<ClearRecycleFilesResponse>(DoROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/clear", "none", req, runtime));
        }

        public async Task<ClearRecycleFilesResponse> ClearRecycleFilesWithOptionsAsync(string unionId, ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleType))
            {
                body["recycleType"] = request.RecycleType;
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
            return TeaModel.ToObject<ClearRecycleFilesResponse>(await DoROARequestAsync("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/clear", "none", req, runtime));
        }

        public DeleteFileResponse DeleteFile(string unionId, string spaceId, string fileId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return DeleteFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(string unionId, string spaceId, string fileId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFileHeaders headers = new DeleteFileHeaders();
            return await DeleteFileWithOptionsAsync(unionId, spaceId, fileId, request, headers, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(string unionId, string spaceId, string fileId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                query["deletePolicy"] = request.DeletePolicy;
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
            return TeaModel.ToObject<DeleteFileResponse>(DoROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string unionId, string spaceId, string fileId, DeleteFileRequest request, DeleteFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePolicy))
            {
                query["deletePolicy"] = request.DeletePolicy;
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
            return TeaModel.ToObject<DeleteFileResponse>(await DoROARequestAsync("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId, "json", req, runtime));
        }

    }
}
