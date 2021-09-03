// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0
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


        public GetConferenceDetailResponse GetConferenceDetail(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return GetConferenceDetailWithOptions(conferenceId, headers, runtime);
        }

        public async Task<GetConferenceDetailResponse> GetConferenceDetailAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return await GetConferenceDetailWithOptionsAsync(conferenceId, headers, runtime);
        }

        public GetConferenceDetailResponse GetConferenceDetailWithOptions(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetConferenceDetailResponse>(DoROARequest("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences/" + conferenceId, "json", req, runtime));
        }

        public async Task<GetConferenceDetailResponse> GetConferenceDetailWithOptionsAsync(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetConferenceDetailResponse>(await DoROARequestAsync("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences/" + conferenceId, "json", req, runtime));
        }

        public GetUserAppVersionSummaryResponse GetUserAppVersionSummary(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return GetUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryAsync(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return await GetUserAppVersionSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetUserAppVersionSummaryResponse GetUserAppVersionSummaryWithOptions(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(DoROARequest("GetUserAppVersionSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/appVersion/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryWithOptionsAsync(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(await DoROARequestAsync("GetUserAppVersionSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/appVersion/org/" + dataId, "json", req, runtime));
        }

        public DeleteCommentResponse DeleteComment(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return DeleteCommentWithOptions(publisherId, commentId, headers, runtime);
        }

        public async Task<DeleteCommentResponse> DeleteCommentAsync(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return await DeleteCommentWithOptionsAsync(publisherId, commentId, headers, runtime);
        }

        public DeleteCommentResponse DeleteCommentWithOptions(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteCommentResponse>(DoROARequest("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId, "boolean", req, runtime));
        }

        public async Task<DeleteCommentResponse> DeleteCommentWithOptionsAsync(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteCommentResponse>(await DoROARequestAsync("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId, "boolean", req, runtime));
        }

        public GetAllLabelableDeptsResponse GetAllLabelableDepts()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return GetAllLabelableDeptsWithOptions(headers, runtime);
        }

        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return await GetAllLabelableDeptsWithOptionsAsync(headers, runtime);
        }

        public GetAllLabelableDeptsResponse GetAllLabelableDeptsWithOptions(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(DoROARequest("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerDepartments", "json", req, runtime));
        }

        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsWithOptionsAsync(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(await DoROARequestAsync("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerDepartments", "json", req, runtime));
        }

        public GetPublisherSummaryResponse GetPublisherSummary(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return GetPublisherSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryAsync(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return await GetPublisherSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetPublisherSummaryResponse GetPublisherSummaryWithOptions(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetPublisherSummaryResponse>(DoROARequest("GetPublisherSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/publisher/" + dataId, "json", req, runtime));
        }

        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryWithOptionsAsync(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetPublisherSummaryResponse>(await DoROARequestAsync("GetPublisherSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/publisher/" + dataId, "json", req, runtime));
        }

        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummary(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return GetDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryAsync(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return await GetDocCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummaryWithOptions(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(DoROARequest("GetDocCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryWithOptionsAsync(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(await DoROARequestAsync("GetDocCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/dept/" + dataId, "json", req, runtime));
        }

        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return GetGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return await GetGeneralFormCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummaryWithOptions(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(DoROARequest("GetGeneralFormCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(await DoROARequestAsync("GetGeneralFormCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/org/" + dataId, "json", req, runtime));
        }

        public CreateTrustedDeviceResponse CreateTrustedDevice(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return CreateTrustedDeviceWithOptions(request, headers, runtime);
        }

        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceAsync(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return await CreateTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        public CreateTrustedDeviceResponse CreateTrustedDeviceWithOptions(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(DoROARequest("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices", "json", req, runtime));
        }

        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceWithOptionsAsync(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(await DoROARequestAsync("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices", "json", req, runtime));
        }

        public GetDocCreatedSummaryResponse GetDocCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return GetDocCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return await GetDocCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetDocCreatedSummaryResponse GetDocCreatedSummaryWithOptions(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(DoROARequest("GetDocCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryWithOptionsAsync(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(await DoROARequestAsync("GetDocCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/org/" + dataId, "json", req, runtime));
        }

        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentId(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return GetPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
        }

        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return await GetPartnerTypeByParentIdWithOptionsAsync(parentId, headers, runtime);
        }

        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentIdWithOptions(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(DoROARequest("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerLabels/" + parentId, "json", req, runtime));
        }

        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdWithOptionsAsync(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(await DoROARequestAsync("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerLabels/" + parentId, "json", req, runtime));
        }

        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNum(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return SetDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
        }

        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumAsync(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return await SetDeptPartnerTypeAndNumWithOptionsAsync(request, headers, runtime);
        }

        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNumWithOptions(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
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
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(DoROARequest("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments", "none", req, runtime));
        }

        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumWithOptionsAsync(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
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
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(await DoROARequestAsync("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments", "none", req, runtime));
        }

        public GetActiveUserSummaryResponse GetActiveUserSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return GetActiveUserSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return await GetActiveUserSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetActiveUserSummaryResponse GetActiveUserSummaryWithOptions(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(DoROARequest("GetActiveUserSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/dau/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryWithOptionsAsync(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(await DoROARequestAsync("GetActiveUserSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/dau/org/" + dataId, "json", req, runtime));
        }

        public GetOaOperatorLogListResponse GetOaOperatorLogList(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return GetOaOperatorLogListWithOptions(request, headers, runtime);
        }

        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListAsync(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return await GetOaOperatorLogListWithOptionsAsync(request, headers, runtime);
        }

        public GetOaOperatorLogListResponse GetOaOperatorLogListWithOptions(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
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
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(DoROARequest("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/oaOperatorLogs/query", "json", req, runtime));
        }

        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListWithOptionsAsync(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
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
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(await DoROARequestAsync("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/oaOperatorLogs/query", "json", req, runtime));
        }

        public GetDingReportDeptSummaryResponse GetDingReportDeptSummary(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return GetDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryAsync(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return await GetDingReportDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetDingReportDeptSummaryResponse GetDingReportDeptSummaryWithOptions(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(DoROARequest("GetDingReportDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/report/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryWithOptionsAsync(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(await DoROARequestAsync("GetDingReportDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/report/dept/" + dataId, "json", req, runtime));
        }

        public GetTrustDeviceListResponse GetTrustDeviceList(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return GetTrustDeviceListWithOptions(request, headers, runtime);
        }

        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListAsync(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return await GetTrustDeviceListWithOptionsAsync(request, headers, runtime);
        }

        public GetTrustDeviceListResponse GetTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<GetTrustDeviceListResponse>(DoROARequest("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices/query", "json", req, runtime));
        }

        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListWithOptionsAsync(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<GetTrustDeviceListResponse>(await DoROARequestAsync("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices/query", "json", req, runtime));
        }

        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummary(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return GetGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return await GetGeneralFormCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummaryWithOptions(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(DoROARequest("GetGeneralFormCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(await DoROARequestAsync("GetGeneralFormCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/dept/" + dataId, "json", req, runtime));
        }

        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return SearchOrgInnerGroupInfoWithOptions(request, headers, runtime);
        }

        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoAsync(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return await SearchOrgInnerGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfoWithOptions(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
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
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(DoROARequest("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/securities/orgGroupInfos", "json", req, runtime));
        }

        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoWithOptionsAsync(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
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
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(await DoROARequestAsync("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/securities/orgGroupInfos", "json", req, runtime));
        }

        public GetCalenderSummaryResponse GetCalenderSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return GetCalenderSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return await GetCalenderSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetCalenderSummaryResponse GetCalenderSummaryWithOptions(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCalenderSummaryResponse>(DoROARequest("GetCalenderSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/calendar/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryWithOptionsAsync(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCalenderSummaryResponse>(await DoROARequestAsync("GetCalenderSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/calendar/org/" + dataId, "json", req, runtime));
        }

        public GetGroupActiveInfoResponse GetGroupActiveInfo(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return GetGroupActiveInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoAsync(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return await GetGroupActiveInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetGroupActiveInfoResponse GetGroupActiveInfoWithOptions(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(DoROARequest("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/activeGroups", "json", req, runtime));
        }

        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoWithOptionsAsync(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(await DoROARequestAsync("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/activeGroups", "json", req, runtime));
        }

        public GetCommentListResponse GetCommentList(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return GetCommentListWithOptions(publisherId, request, headers, runtime);
        }

        public async Task<GetCommentListResponse> GetCommentListAsync(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return await GetCommentListWithOptionsAsync(publisherId, request, headers, runtime);
        }

        public GetCommentListResponse GetCommentListWithOptions(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetCommentListResponse>(DoROARequest("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list", "json", req, runtime));
        }

        public async Task<GetCommentListResponse> GetCommentListWithOptionsAsync(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetCommentListResponse>(await DoROARequestAsync("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list", "json", req, runtime));
        }

    }
}
