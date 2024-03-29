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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembersWithOptions(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersWithOptionsAsync(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembers(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return AddDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
        }

        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersAsync(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return await AddDeviceVideoConferenceMembersWithOptionsAsync(deviceId, conferenceId, request, headers, runtime);
        }

        public CreateDeviceVideoConferenceResponse CreateDeviceVideoConferenceWithOptions(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeviceVideoConference",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateDeviceVideoConferenceResponse> CreateDeviceVideoConferenceWithOptionsAsync(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeviceVideoConference",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtractFacialFeature",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/faceRecognitions/features/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(Execute(params_, req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtractFacialFeature",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/faceRecognitions/features/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(await ExecuteAsync(params_, req, runtime));
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

        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembersWithOptions(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersWithOptionsAsync(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembers(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return KickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
        }

        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersAsync(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return await KickDeviceVideoConferenceMembersWithOptionsAsync(deviceId, conferenceId, request, headers, runtime);
        }

        public MachineManagerUpdateResponse MachineManagerUpdateWithOptions(MachineManagerUpdateRequest request, MachineManagerUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtmManagerRightMap))
            {
                body["atmManagerRightMap"] = request.AtmManagerRightMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeDeptIds))
            {
                body["scopeDeptIds"] = request.ScopeDeptIds;
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
                Action = "MachineManagerUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/managers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineManagerUpdateResponse>(Execute(params_, req, runtime));
        }

        public async Task<MachineManagerUpdateResponse> MachineManagerUpdateWithOptionsAsync(MachineManagerUpdateRequest request, MachineManagerUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtmManagerRightMap))
            {
                body["atmManagerRightMap"] = request.AtmManagerRightMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeDeptIds))
            {
                body["scopeDeptIds"] = request.ScopeDeptIds;
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
                Action = "MachineManagerUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/managers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineManagerUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public MachineManagerUpdateResponse MachineManagerUpdate(MachineManagerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
            return MachineManagerUpdateWithOptions(request, headers, runtime);
        }

        public async Task<MachineManagerUpdateResponse> MachineManagerUpdateAsync(MachineManagerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
            return await MachineManagerUpdateWithOptionsAsync(request, headers, runtime);
        }

        public MachineUsersUpdateResponse MachineUsersUpdateWithOptions(MachineUsersUpdateRequest request, MachineUsersUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevIds))
            {
                body["devIds"] = request.DevIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MachineUsersUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineUsersUpdateResponse>(Execute(params_, req, runtime));
        }

        public async Task<MachineUsersUpdateResponse> MachineUsersUpdateWithOptionsAsync(MachineUsersUpdateRequest request, MachineUsersUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevIds))
            {
                body["devIds"] = request.DevIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MachineUsersUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineUsersUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public MachineUsersUpdateResponse MachineUsersUpdate(MachineUsersUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
            return MachineUsersUpdateWithOptions(request, headers, runtime);
        }

        public async Task<MachineUsersUpdateResponse> MachineUsersUpdateAsync(MachineUsersUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
            return await MachineUsersUpdateWithOptionsAsync(request, headers, runtime);
        }

        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBookWithOptions(string deviceId, string bookId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVideoConferenceBook",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookWithOptionsAsync(string deviceId, string bookId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVideoConferenceBook",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBook(string deviceId, string bookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return QueryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
        }

        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookAsync(string deviceId, string bookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return await QueryDeviceVideoConferenceBookWithOptionsAsync(deviceId, bookId, headers, runtime);
        }

    }
}
