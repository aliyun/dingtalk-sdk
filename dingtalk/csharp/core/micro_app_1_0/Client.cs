// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0
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


        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroup(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return AddAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
        }

        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupAsync(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return await AddAppToWorkBenchGroupWithOptionsAsync(agentId, request, headers, runtime);
        }

        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroupWithOptions(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["componentId"] = request.ComponentId;
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
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(DoROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup", "json", req, runtime));
        }

        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupWithOptionsAsync(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["componentId"] = request.ComponentId;
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
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(await DoROARequestAsync("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup", "json", req, runtime));
        }

        public CreateInnerAppResponse CreateInnerApp(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return CreateInnerAppWithOptions(request, headers, runtime);
        }

        public async Task<CreateInnerAppResponse> CreateInnerAppAsync(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return await CreateInnerAppWithOptionsAsync(request, headers, runtime);
        }

        public CreateInnerAppResponse CreateInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
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
            return TeaModel.ToObject<CreateInnerAppResponse>(DoROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public async Task<CreateInnerAppResponse> CreateInnerAppWithOptionsAsync(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
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
            return TeaModel.ToObject<CreateInnerAppResponse>(await DoROARequestAsync("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public UpdateInnerAppResponse UpdateInnerApp(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return UpdateInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<UpdateInnerAppResponse> UpdateInnerAppAsync(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return await UpdateInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public UpdateInnerAppResponse UpdateInnerAppWithOptions(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
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
            return TeaModel.ToObject<UpdateInnerAppResponse>(DoROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<UpdateInnerAppResponse> UpdateInnerAppWithOptionsAsync(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
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
            return TeaModel.ToObject<UpdateInnerAppResponse>(await DoROARequestAsync("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public DeleteInnerAppResponse DeleteInnerApp(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return DeleteInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<DeleteInnerAppResponse> DeleteInnerAppAsync(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return await DeleteInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public DeleteInnerAppResponse DeleteInnerAppWithOptions(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<DeleteInnerAppResponse>(DoROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<DeleteInnerAppResponse> DeleteInnerAppWithOptionsAsync(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<DeleteInnerAppResponse>(await DoROARequestAsync("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public GetInnerAppResponse GetInnerApp(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return GetInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<GetInnerAppResponse> GetInnerAppAsync(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return await GetInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public GetInnerAppResponse GetInnerAppWithOptions(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<GetInnerAppResponse>(DoROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<GetInnerAppResponse> GetInnerAppWithOptionsAsync(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<GetInnerAppResponse>(await DoROARequestAsync("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public ListInnerAppResponse ListInnerApp(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return ListInnerAppWithOptions(request, headers, runtime);
        }

        public async Task<ListInnerAppResponse> ListInnerAppAsync(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return await ListInnerAppWithOptionsAsync(request, headers, runtime);
        }

        public ListInnerAppResponse ListInnerAppWithOptions(ListInnerAppRequest request, ListInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<ListInnerAppResponse>(DoROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public async Task<ListInnerAppResponse> ListInnerAppWithOptionsAsync(ListInnerAppRequest request, ListInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
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
            return TeaModel.ToObject<ListInnerAppResponse>(await DoROARequestAsync("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

    }
}
