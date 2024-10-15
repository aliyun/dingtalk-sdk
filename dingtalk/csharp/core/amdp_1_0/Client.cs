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
        /// <para>人员角色数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmpRoleDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpEmpRoleDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmpRoleDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员角色数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmpRoleDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpEmpRoleDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmpRoleDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员角色数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmpRoleDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmpRoleDataPushResponse
        /// </returns>
        public AmdpEmpRoleDataPushResponse AmdpEmpRoleDataPush(AmdpEmpRoleDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmpRoleDataPushHeaders headers = new AmdpEmpRoleDataPushHeaders();
            return AmdpEmpRoleDataPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员角色数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmpRoleDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmpRoleDataPushResponse
        /// </returns>
        public async Task<AmdpEmpRoleDataPushResponse> AmdpEmpRoleDataPushAsync(AmdpEmpRoleDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmpRoleDataPushHeaders headers = new AmdpEmpRoleDataPushHeaders();
            return await AmdpEmpRoleDataPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmployeeDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpEmployeeDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmployeeDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmployeeDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpEmployeeDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmployeeDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmployeeDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmployeeDataPushResponse
        /// </returns>
        public AmdpEmployeeDataPushResponse AmdpEmployeeDataPush(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return AmdpEmployeeDataPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpEmployeeDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpEmployeeDataPushResponse
        /// </returns>
        public async Task<AmdpEmployeeDataPushResponse> AmdpEmployeeDataPushAsync(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return await AmdpEmployeeDataPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任职数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpJobPositionDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpJobPositionDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpJobPositionDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任职数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpJobPositionDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpJobPositionDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpJobPositionDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任职数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpJobPositionDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpJobPositionDataPushResponse
        /// </returns>
        public AmdpJobPositionDataPushResponse AmdpJobPositionDataPush(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return AmdpJobPositionDataPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任职数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpJobPositionDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpJobPositionDataPushResponse
        /// </returns>
        public async Task<AmdpJobPositionDataPushResponse> AmdpJobPositionDataPushAsync(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return await AmdpJobPositionDataPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织部门数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpOrganizationDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpOrganizationDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpOrganizationDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织部门数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpOrganizationDataPushRequest
        /// </param>
        /// <param name="headers">
        /// AmdpOrganizationDataPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AmdpOrganizationDataPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织部门数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpOrganizationDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpOrganizationDataPushResponse
        /// </returns>
        public AmdpOrganizationDataPushResponse AmdpOrganizationDataPush(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return AmdpOrganizationDataPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织部门数据推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AmdpOrganizationDataPushRequest
        /// </param>
        /// 
        /// <returns>
        /// AmdpOrganizationDataPushResponse
        /// </returns>
        public async Task<AmdpOrganizationDataPushResponse> AmdpOrganizationDataPushAsync(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return await AmdpOrganizationDataPushWithOptionsAsync(request, headers, runtime);
        }

    }
}
