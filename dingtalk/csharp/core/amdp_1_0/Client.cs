// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkamdp_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0
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


        /**
         * @summary 人员角色数据推送
         *
         * @param request AmdpEmpRoleDataPushRequest
         * @param headers AmdpEmpRoleDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpEmpRoleDataPushResponse
         */
        public AmdpEmpRoleDataPushResponse AmdpEmpRoleDataPushWithOptions(AmdpEmpRoleDataPushRequest request, AmdpEmpRoleDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmpRoleDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employeeRoles/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmpRoleDataPushResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人员角色数据推送
         *
         * @param request AmdpEmpRoleDataPushRequest
         * @param headers AmdpEmpRoleDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpEmpRoleDataPushResponse
         */
        public async Task<AmdpEmpRoleDataPushResponse> AmdpEmpRoleDataPushWithOptionsAsync(AmdpEmpRoleDataPushRequest request, AmdpEmpRoleDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmpRoleDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employeeRoles/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmpRoleDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人员角色数据推送
         *
         * @param request AmdpEmpRoleDataPushRequest
         * @return AmdpEmpRoleDataPushResponse
         */
        public AmdpEmpRoleDataPushResponse AmdpEmpRoleDataPush(AmdpEmpRoleDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmpRoleDataPushHeaders headers = new AmdpEmpRoleDataPushHeaders();
            return AmdpEmpRoleDataPushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人员角色数据推送
         *
         * @param request AmdpEmpRoleDataPushRequest
         * @return AmdpEmpRoleDataPushResponse
         */
        public async Task<AmdpEmpRoleDataPushResponse> AmdpEmpRoleDataPushAsync(AmdpEmpRoleDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmpRoleDataPushHeaders headers = new AmdpEmpRoleDataPushHeaders();
            return await AmdpEmpRoleDataPushWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人员数据推送
         *
         * @param request AmdpEmployeeDataPushRequest
         * @param headers AmdpEmployeeDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpEmployeeDataPushResponse
         */
        public AmdpEmployeeDataPushResponse AmdpEmployeeDataPushWithOptions(AmdpEmployeeDataPushRequest request, AmdpEmployeeDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmployeeDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employees/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmployeeDataPushResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人员数据推送
         *
         * @param request AmdpEmployeeDataPushRequest
         * @param headers AmdpEmployeeDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpEmployeeDataPushResponse
         */
        public async Task<AmdpEmployeeDataPushResponse> AmdpEmployeeDataPushWithOptionsAsync(AmdpEmployeeDataPushRequest request, AmdpEmployeeDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmployeeDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employees/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmployeeDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人员数据推送
         *
         * @param request AmdpEmployeeDataPushRequest
         * @return AmdpEmployeeDataPushResponse
         */
        public AmdpEmployeeDataPushResponse AmdpEmployeeDataPush(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return AmdpEmployeeDataPushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人员数据推送
         *
         * @param request AmdpEmployeeDataPushRequest
         * @return AmdpEmployeeDataPushResponse
         */
        public async Task<AmdpEmployeeDataPushResponse> AmdpEmployeeDataPushAsync(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return await AmdpEmployeeDataPushWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 任职数据推送
         *
         * @param request AmdpJobPositionDataPushRequest
         * @param headers AmdpJobPositionDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpJobPositionDataPushResponse
         */
        public AmdpJobPositionDataPushResponse AmdpJobPositionDataPushWithOptions(AmdpJobPositionDataPushRequest request, AmdpJobPositionDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpJobPositionDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/empJobs/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpJobPositionDataPushResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 任职数据推送
         *
         * @param request AmdpJobPositionDataPushRequest
         * @param headers AmdpJobPositionDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpJobPositionDataPushResponse
         */
        public async Task<AmdpJobPositionDataPushResponse> AmdpJobPositionDataPushWithOptionsAsync(AmdpJobPositionDataPushRequest request, AmdpJobPositionDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpJobPositionDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/empJobs/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpJobPositionDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 任职数据推送
         *
         * @param request AmdpJobPositionDataPushRequest
         * @return AmdpJobPositionDataPushResponse
         */
        public AmdpJobPositionDataPushResponse AmdpJobPositionDataPush(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return AmdpJobPositionDataPushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 任职数据推送
         *
         * @param request AmdpJobPositionDataPushRequest
         * @return AmdpJobPositionDataPushResponse
         */
        public async Task<AmdpJobPositionDataPushResponse> AmdpJobPositionDataPushAsync(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return await AmdpJobPositionDataPushWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 组织部门数据推送
         *
         * @param request AmdpOrganizationDataPushRequest
         * @param headers AmdpOrganizationDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpOrganizationDataPushResponse
         */
        public AmdpOrganizationDataPushResponse AmdpOrganizationDataPushWithOptions(AmdpOrganizationDataPushRequest request, AmdpOrganizationDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpOrganizationDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/organizations/departments/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpOrganizationDataPushResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 组织部门数据推送
         *
         * @param request AmdpOrganizationDataPushRequest
         * @param headers AmdpOrganizationDataPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AmdpOrganizationDataPushResponse
         */
        public async Task<AmdpOrganizationDataPushResponse> AmdpOrganizationDataPushWithOptionsAsync(AmdpOrganizationDataPushRequest request, AmdpOrganizationDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpOrganizationDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/organizations/departments/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpOrganizationDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 组织部门数据推送
         *
         * @param request AmdpOrganizationDataPushRequest
         * @return AmdpOrganizationDataPushResponse
         */
        public AmdpOrganizationDataPushResponse AmdpOrganizationDataPush(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return AmdpOrganizationDataPushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 组织部门数据推送
         *
         * @param request AmdpOrganizationDataPushRequest
         * @return AmdpOrganizationDataPushResponse
         */
        public async Task<AmdpOrganizationDataPushResponse> AmdpOrganizationDataPushAsync(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return await AmdpOrganizationDataPushWithOptionsAsync(request, headers, runtime);
        }

    }
}
