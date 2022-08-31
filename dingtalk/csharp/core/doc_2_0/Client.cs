// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdoc_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
            return TeaModel.ToObject<CopyDentryResponse>(DoROARequest("CopyDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime));
        }

        public async Task<CopyDentryResponse> CopyDentryWithOptionsAsync(string spaceId, string dentryId, CopyDentryRequest request, CopyDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
            return TeaModel.ToObject<CopyDentryResponse>(await DoROARequestAsync("CopyDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime));
        }

        public CreateDentryResponse CreateDentry(string spaceId, CreateDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDentryHeaders headers = new CreateDentryHeaders();
            return CreateDentryWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<CreateDentryResponse> CreateDentryAsync(string spaceId, CreateDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDentryHeaders headers = new CreateDentryHeaders();
            return await CreateDentryWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public CreateDentryResponse CreateDentryWithOptions(string spaceId, CreateDentryRequest request, CreateDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryType))
            {
                body["dentryType"] = request.DentryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["documentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDentryId))
            {
                body["parentDentryId"] = request.ParentDentryId;
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
            return TeaModel.ToObject<CreateDentryResponse>(DoROARequest("CreateDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries", "json", req, runtime));
        }

        public async Task<CreateDentryResponse> CreateDentryWithOptionsAsync(string spaceId, CreateDentryRequest request, CreateDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryType))
            {
                body["dentryType"] = request.DentryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["documentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDentryId))
            {
                body["parentDentryId"] = request.ParentDentryId;
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
            return TeaModel.ToObject<CreateDentryResponse>(await DoROARequestAsync("CreateDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries", "json", req, runtime));
        }

        public GetSchemaResponse GetSchema(string teamId, GetSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaHeaders headers = new GetSchemaHeaders();
            return GetSchemaWithOptions(teamId, request, headers, runtime);
        }

        public async Task<GetSchemaResponse> GetSchemaAsync(string teamId, GetSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaHeaders headers = new GetSchemaHeaders();
            return await GetSchemaWithOptionsAsync(teamId, request, headers, runtime);
        }

        public GetSchemaResponse GetSchemaWithOptions(string teamId, GetSchemaRequest request, GetSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<GetSchemaResponse>(DoROARequest("GetSchema", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/schemas", "json", req, runtime));
        }

        public async Task<GetSchemaResponse> GetSchemaWithOptionsAsync(string teamId, GetSchemaRequest request, GetSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<GetSchemaResponse>(await DoROARequestAsync("GetSchema", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/schemas", "json", req, runtime));
        }

        public GetSpaceDirectoriesResponse GetSpaceDirectories(string spaceId, GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return GetSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesAsync(string spaceId, GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return await GetSpaceDirectoriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public GetSpaceDirectoriesResponse GetSpaceDirectoriesWithOptions(string spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                query["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(DoROARequest("GetSpaceDirectories", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/directories", "json", req, runtime));
        }

        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesWithOptionsAsync(string spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                query["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(await DoROARequestAsync("GetSpaceDirectories", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/directories", "json", req, runtime));
        }

        public GetTeamResponse GetTeam(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return GetTeamWithOptions(teamId, request, headers, runtime);
        }

        public async Task<GetTeamResponse> GetTeamAsync(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return await GetTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        public GetTeamResponse GetTeamWithOptions(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<GetTeamResponse>(DoROARequest("GetTeam", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId, "json", req, runtime));
        }

        public async Task<GetTeamResponse> GetTeamWithOptionsAsync(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<GetTeamResponse>(await DoROARequestAsync("GetTeam", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId, "json", req, runtime));
        }

        public GetTotalNumberOfDentriesResponse GetTotalNumberOfDentries(GetTotalNumberOfDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfDentriesHeaders headers = new GetTotalNumberOfDentriesHeaders();
            return GetTotalNumberOfDentriesWithOptions(request, headers, runtime);
        }

        public async Task<GetTotalNumberOfDentriesResponse> GetTotalNumberOfDentriesAsync(GetTotalNumberOfDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfDentriesHeaders headers = new GetTotalNumberOfDentriesHeaders();
            return await GetTotalNumberOfDentriesWithOptionsAsync(request, headers, runtime);
        }

        public GetTotalNumberOfDentriesResponse GetTotalNumberOfDentriesWithOptions(GetTotalNumberOfDentriesRequest request, GetTotalNumberOfDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFolder))
            {
                query["includeFolder"] = request.IncludeFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceTypes))
            {
                query["spaceTypes"] = request.SpaceTypes;
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
            return TeaModel.ToObject<GetTotalNumberOfDentriesResponse>(DoROARequest("GetTotalNumberOfDentries", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/statistics/dentryCounts", "json", req, runtime));
        }

        public async Task<GetTotalNumberOfDentriesResponse> GetTotalNumberOfDentriesWithOptionsAsync(GetTotalNumberOfDentriesRequest request, GetTotalNumberOfDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFolder))
            {
                query["includeFolder"] = request.IncludeFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceTypes))
            {
                query["spaceTypes"] = request.SpaceTypes;
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
            return TeaModel.ToObject<GetTotalNumberOfDentriesResponse>(await DoROARequestAsync("GetTotalNumberOfDentries", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/statistics/dentryCounts", "json", req, runtime));
        }

        public GetTotalNumberOfSpacesResponse GetTotalNumberOfSpaces(GetTotalNumberOfSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfSpacesHeaders headers = new GetTotalNumberOfSpacesHeaders();
            return GetTotalNumberOfSpacesWithOptions(request, headers, runtime);
        }

        public async Task<GetTotalNumberOfSpacesResponse> GetTotalNumberOfSpacesAsync(GetTotalNumberOfSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTotalNumberOfSpacesHeaders headers = new GetTotalNumberOfSpacesHeaders();
            return await GetTotalNumberOfSpacesWithOptionsAsync(request, headers, runtime);
        }

        public GetTotalNumberOfSpacesResponse GetTotalNumberOfSpacesWithOptions(GetTotalNumberOfSpacesRequest request, GetTotalNumberOfSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetTotalNumberOfSpacesResponse>(DoROARequest("GetTotalNumberOfSpaces", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/statistics/spaceCounts", "json", req, runtime));
        }

        public async Task<GetTotalNumberOfSpacesResponse> GetTotalNumberOfSpacesWithOptionsAsync(GetTotalNumberOfSpacesRequest request, GetTotalNumberOfSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetTotalNumberOfSpacesResponse>(await DoROARequestAsync("GetTotalNumberOfSpaces", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/statistics/spaceCounts", "json", req, runtime));
        }

        public GetUserInfoByOpenTokenResponse GetUserInfoByOpenToken(GetUserInfoByOpenTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
            return GetUserInfoByOpenTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetUserInfoByOpenTokenResponse> GetUserInfoByOpenTokenAsync(GetUserInfoByOpenTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
            return await GetUserInfoByOpenTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetUserInfoByOpenTokenResponse GetUserInfoByOpenTokenWithOptions(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenToken))
            {
                query["openToken"] = request.OpenToken;
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
            return TeaModel.ToObject<GetUserInfoByOpenTokenResponse>(DoROARequest("GetUserInfoByOpenToken", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/userInfos", "json", req, runtime));
        }

        public async Task<GetUserInfoByOpenTokenResponse> GetUserInfoByOpenTokenWithOptionsAsync(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKey))
            {
                query["docKey"] = request.DocKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenToken))
            {
                query["openToken"] = request.OpenToken;
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
            return TeaModel.ToObject<GetUserInfoByOpenTokenResponse>(await DoROARequestAsync("GetUserInfoByOpenToken", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/userInfos", "json", req, runtime));
        }

        public ListFeedsResponse ListFeeds(string teamId, ListFeedsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFeedsHeaders headers = new ListFeedsHeaders();
            return ListFeedsWithOptions(teamId, request, headers, runtime);
        }

        public async Task<ListFeedsResponse> ListFeedsAsync(string teamId, ListFeedsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFeedsHeaders headers = new ListFeedsHeaders();
            return await ListFeedsWithOptionsAsync(teamId, request, headers, runtime);
        }

        public ListFeedsResponse ListFeedsWithOptions(string teamId, ListFeedsRequest request, ListFeedsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFile))
            {
                query["excludeFile"] = request.ExcludeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            return TeaModel.ToObject<ListFeedsResponse>(DoROARequest("ListFeeds", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/feeds", "json", req, runtime));
        }

        public async Task<ListFeedsResponse> ListFeedsWithOptionsAsync(string teamId, ListFeedsRequest request, ListFeedsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFile))
            {
                query["excludeFile"] = request.ExcludeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            return TeaModel.ToObject<ListFeedsResponse>(await DoROARequestAsync("ListFeeds", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/feeds", "json", req, runtime));
        }

        public ListHotDocsResponse ListHotDocs(string teamId, ListHotDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotDocsHeaders headers = new ListHotDocsHeaders();
            return ListHotDocsWithOptions(teamId, request, headers, runtime);
        }

        public async Task<ListHotDocsResponse> ListHotDocsAsync(string teamId, ListHotDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotDocsHeaders headers = new ListHotDocsHeaders();
            return await ListHotDocsWithOptionsAsync(teamId, request, headers, runtime);
        }

        public ListHotDocsResponse ListHotDocsWithOptions(string teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<ListHotDocsResponse>(DoROARequest("ListHotDocs", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/hotDocs", "json", req, runtime));
        }

        public async Task<ListHotDocsResponse> ListHotDocsWithOptionsAsync(string teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<ListHotDocsResponse>(await DoROARequestAsync("ListHotDocs", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/hotDocs", "json", req, runtime));
        }

        public ListRelatedSpaceTeamsResponse ListRelatedSpaceTeams(ListRelatedSpaceTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
            return ListRelatedSpaceTeamsWithOptions(request, headers, runtime);
        }

        public async Task<ListRelatedSpaceTeamsResponse> ListRelatedSpaceTeamsAsync(ListRelatedSpaceTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
            return await ListRelatedSpaceTeamsWithOptionsAsync(request, headers, runtime);
        }

        public ListRelatedSpaceTeamsResponse ListRelatedSpaceTeamsWithOptions(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
            return TeaModel.ToObject<ListRelatedSpaceTeamsResponse>(DoROARequest("ListRelatedSpaceTeams", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/relations/spaceTeams", "json", req, runtime));
        }

        public async Task<ListRelatedSpaceTeamsResponse> ListRelatedSpaceTeamsWithOptionsAsync(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
            return TeaModel.ToObject<ListRelatedSpaceTeamsResponse>(await DoROARequestAsync("ListRelatedSpaceTeams", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/relations/spaceTeams", "json", req, runtime));
        }

        public ListSpaceSectionsResponse ListSpaceSections(string teamId, ListSpaceSectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
            return ListSpaceSectionsWithOptions(teamId, request, headers, runtime);
        }

        public async Task<ListSpaceSectionsResponse> ListSpaceSectionsAsync(string teamId, ListSpaceSectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
            return await ListSpaceSectionsWithOptionsAsync(teamId, request, headers, runtime);
        }

        public ListSpaceSectionsResponse ListSpaceSectionsWithOptions(string teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<ListSpaceSectionsResponse>(DoROARequest("ListSpaceSections", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/spaceSections", "json", req, runtime));
        }

        public async Task<ListSpaceSectionsResponse> ListSpaceSectionsWithOptionsAsync(string teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            teamId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId);
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
            return TeaModel.ToObject<ListSpaceSectionsResponse>(await DoROARequestAsync("ListSpaceSections", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/spaceSections", "json", req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
            return TeaModel.ToObject<MoveDentryResponse>(DoROARequest("MoveDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime));
        }

        public async Task<MoveDentryResponse> MoveDentryWithOptionsAsync(string spaceId, string dentryId, MoveDentryRequest request, MoveDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpaceId))
            {
                body["targetSpaceId"] = request.TargetSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToNextDentryId))
            {
                body["toNextDentryId"] = request.ToNextDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentDentryId))
            {
                body["toParentDentryId"] = request.ToParentDentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToPrevDentryId))
            {
                body["toPrevDentryId"] = request.ToPrevDentryId;
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
            return TeaModel.ToObject<MoveDentryResponse>(await DoROARequestAsync("MoveDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime));
        }

        public QueryDentryResponse QueryDentry(string spaceId, string dentryId, QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return QueryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        public async Task<QueryDentryResponse> QueryDentryAsync(string spaceId, string dentryId, QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return await QueryDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        public QueryDentryResponse QueryDentryWithOptions(string spaceId, string dentryId, QueryDentryRequest request, QueryDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                query["includeSpace"] = request.IncludeSpace;
            }
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
            return TeaModel.ToObject<QueryDentryResponse>(DoROARequest("QueryDentry", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId, "json", req, runtime));
        }

        public async Task<QueryDentryResponse> QueryDentryWithOptionsAsync(string spaceId, string dentryId, QueryDentryRequest request, QueryDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                query["includeSpace"] = request.IncludeSpace;
            }
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
            return TeaModel.ToObject<QueryDentryResponse>(await DoROARequestAsync("QueryDentry", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId, "json", req, runtime));
        }

        public QueryMineSpaceResponse QueryMineSpace(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
            return QueryMineSpaceWithOptions(unionId, headers, runtime);
        }

        public async Task<QueryMineSpaceResponse> QueryMineSpaceAsync(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
            return await QueryMineSpaceWithOptionsAsync(unionId, headers, runtime);
        }

        public QueryMineSpaceResponse QueryMineSpaceWithOptions(string unionId, QueryMineSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            unionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(unionId);
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
            };
            return TeaModel.ToObject<QueryMineSpaceResponse>(DoROARequest("QueryMineSpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/users/" + unionId + "/mine", "json", req, runtime));
        }

        public async Task<QueryMineSpaceResponse> QueryMineSpaceWithOptionsAsync(string unionId, QueryMineSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            unionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(unionId);
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
            };
            return TeaModel.ToObject<QueryMineSpaceResponse>(await DoROARequestAsync("QueryMineSpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/users/" + unionId + "/mine", "json", req, runtime));
        }

        public QueryRecentListResponse QueryRecentList(QueryRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentListHeaders headers = new QueryRecentListHeaders();
            return QueryRecentListWithOptions(request, headers, runtime);
        }

        public async Task<QueryRecentListResponse> QueryRecentListAsync(QueryRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentListHeaders headers = new QueryRecentListHeaders();
            return await QueryRecentListWithOptionsAsync(request, headers, runtime);
        }

        public QueryRecentListResponse QueryRecentListWithOptions(QueryRecentListRequest request, QueryRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorType))
            {
                query["creatorType"] = request.CreatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentType))
            {
                query["recentType"] = request.RecentType;
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
            return TeaModel.ToObject<QueryRecentListResponse>(DoROARequest("QueryRecentList", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/docs/recent", "json", req, runtime));
        }

        public async Task<QueryRecentListResponse> QueryRecentListWithOptionsAsync(QueryRecentListRequest request, QueryRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorType))
            {
                query["creatorType"] = request.CreatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentType))
            {
                query["recentType"] = request.RecentType;
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
            return TeaModel.ToObject<QueryRecentListResponse>(await DoROARequestAsync("QueryRecentList", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/docs/recent", "json", req, runtime));
        }

        public QuerySpaceResponse QuerySpace(string spaceId, QuerySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySpaceHeaders headers = new QuerySpaceHeaders();
            return QuerySpaceWithOptions(spaceId, request, headers, runtime);
        }

        public async Task<QuerySpaceResponse> QuerySpaceAsync(string spaceId, QuerySpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySpaceHeaders headers = new QuerySpaceHeaders();
            return await QuerySpaceWithOptionsAsync(spaceId, request, headers, runtime);
        }

        public QuerySpaceResponse QuerySpaceWithOptions(string spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            return TeaModel.ToObject<QuerySpaceResponse>(DoROARequest("QuerySpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId, "json", req, runtime));
        }

        public async Task<QuerySpaceResponse> QuerySpaceWithOptionsAsync(string spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
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
            return TeaModel.ToObject<QuerySpaceResponse>(await DoROARequestAsync("QuerySpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId, "json", req, runtime));
        }

        public RelatedSpacesResponse RelatedSpaces(RelatedSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
            return RelatedSpacesWithOptions(request, headers, runtime);
        }

        public async Task<RelatedSpacesResponse> RelatedSpacesAsync(RelatedSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
            return await RelatedSpacesWithOptionsAsync(request, headers, runtime);
        }

        public RelatedSpacesResponse RelatedSpacesWithOptions(RelatedSpacesRequest request, RelatedSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
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
            return TeaModel.ToObject<RelatedSpacesResponse>(DoROARequest("RelatedSpaces", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/relations/spaces", "json", req, runtime));
        }

        public async Task<RelatedSpacesResponse> RelatedSpacesWithOptionsAsync(RelatedSpacesRequest request, RelatedSpacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
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
            return TeaModel.ToObject<RelatedSpacesResponse>(await DoROARequestAsync("RelatedSpaces", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/relations/spaces", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
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
            return TeaModel.ToObject<RenameDentryResponse>(DoROARequest("RenameDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime));
        }

        public async Task<RenameDentryResponse> RenameDentryWithOptionsAsync(string spaceId, string dentryId, RenameDentryRequest request, RenameDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            spaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(spaceId);
            dentryId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dentryId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
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
            return TeaModel.ToObject<RenameDentryResponse>(await DoROARequestAsync("RenameDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime));
        }

        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return SearchWithOptions(request, headers, runtime);
        }

        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

        public SearchResponse SearchWithOptions(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryRequest.ToMap()))
            {
                body["dentryRequest"] = request.DentryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceRequest.ToMap()))
            {
                body["spaceRequest"] = request.SpaceRequest;
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
            return TeaModel.ToObject<SearchResponse>(DoROARequest("Search", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/search", "json", req, runtime));
        }

        public async Task<SearchResponse> SearchWithOptionsAsync(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryRequest.ToMap()))
            {
                body["dentryRequest"] = request.DentryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceRequest.ToMap()))
            {
                body["spaceRequest"] = request.SpaceRequest;
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
            return TeaModel.ToObject<SearchResponse>(await DoROARequestAsync("Search", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/search", "json", req, runtime));
        }

    }
}
