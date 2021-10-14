// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0
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


        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembers(string conferenceId, string deviceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return AddDeviceVideoConferenceMembersWithOptions(conferenceId, deviceId, request, headers, runtime);
        }

        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersAsync(string conferenceId, string deviceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return await AddDeviceVideoConferenceMembersWithOptionsAsync(conferenceId, deviceId, request, headers, runtime);
        }

        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembersWithOptions(string conferenceId, string deviceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(DoROARequest("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members", "none", req, runtime));
        }

        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersWithOptionsAsync(string conferenceId, string deviceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(await DoROARequestAsync("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members", "none", req, runtime));
        }

        public CreateDeviceVideoConferenceResponse CreateDeviceVideoConference(string deviceId, CreateDeviceVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
            return CreateDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
        }

        public async Task<CreateDeviceVideoConferenceResponse> CreateDeviceVideoConferenceAsync(string deviceId, CreateDeviceVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
            return await CreateDeviceVideoConferenceWithOptionsAsync(deviceId, request, headers, runtime);
        }

        public CreateDeviceVideoConferenceResponse CreateDeviceVideoConferenceWithOptions(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(DoROARequest("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences", "json", req, runtime));
        }

        public async Task<CreateDeviceVideoConferenceResponse> CreateDeviceVideoConferenceWithOptionsAsync(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(await DoROARequestAsync("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences", "json", req, runtime));
        }

        public ExtractFacialFeatureResponse ExtractFacialFeature(ExtractFacialFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
            return ExtractFacialFeatureWithOptions(request, headers, runtime);
        }

        public async Task<ExtractFacialFeatureResponse> ExtractFacialFeatureAsync(ExtractFacialFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
            return await ExtractFacialFeatureWithOptionsAsync(request, headers, runtime);
        }

        public ExtractFacialFeatureResponse ExtractFacialFeatureWithOptions(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(DoROARequest("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/faceRecognitions/features/extract", "json", req, runtime));
        }

        public async Task<ExtractFacialFeatureResponse> ExtractFacialFeatureWithOptionsAsync(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(await DoROARequestAsync("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/faceRecognitions/features/extract", "json", req, runtime));
        }

        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembers(string conferenceId, string deviceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return KickDeviceVideoConferenceMembersWithOptions(conferenceId, deviceId, request, headers, runtime);
        }

        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersAsync(string conferenceId, string deviceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return await KickDeviceVideoConferenceMembersWithOptionsAsync(conferenceId, deviceId, request, headers, runtime);
        }

        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembersWithOptions(string conferenceId, string deviceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(DoROARequest("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete", "none", req, runtime));
        }

        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersWithOptionsAsync(string conferenceId, string deviceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(await DoROARequestAsync("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete", "none", req, runtime));
        }

        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBook(string bookId, string deviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return QueryDeviceVideoConferenceBookWithOptions(bookId, deviceId, headers, runtime);
        }

        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookAsync(string bookId, string deviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return await QueryDeviceVideoConferenceBookWithOptionsAsync(bookId, deviceId, headers, runtime);
        }

        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBookWithOptions(string bookId, string deviceId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            bookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bookId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(DoROARequest("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId, "json", req, runtime));
        }

        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookWithOptionsAsync(string bookId, string deviceId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            bookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bookId);
            deviceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deviceId);
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
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(await DoROARequestAsync("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId, "json", req, runtime));
        }

    }
}
