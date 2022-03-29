// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0
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


        public WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbon(WriteAlibabaOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
            return WriteAlibabaOrgCarbonWithOptions(request, headers, runtime);
        }

        public async Task<WriteAlibabaOrgCarbonResponse> WriteAlibabaOrgCarbonAsync(WriteAlibabaOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
            return await WriteAlibabaOrgCarbonWithOptionsAsync(request, headers, runtime);
        }

        public WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbonWithOptions(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
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
            return TeaModel.ToObject<WriteAlibabaOrgCarbonResponse>(DoROARequest("WriteAlibabaOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaOrgDetails/write", "json", req, runtime));
        }

        public async Task<WriteAlibabaOrgCarbonResponse> WriteAlibabaOrgCarbonWithOptionsAsync(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
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
            return TeaModel.ToObject<WriteAlibabaOrgCarbonResponse>(await DoROARequestAsync("WriteAlibabaOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaOrgDetails/write", "json", req, runtime));
        }

        public WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbon(WriteAlibabaUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
            return WriteAlibabaUserCarbonWithOptions(request, headers, runtime);
        }

        public async Task<WriteAlibabaUserCarbonResponse> WriteAlibabaUserCarbonAsync(WriteAlibabaUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
            return await WriteAlibabaUserCarbonWithOptionsAsync(request, headers, runtime);
        }

        public WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbonWithOptions(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
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
            return TeaModel.ToObject<WriteAlibabaUserCarbonResponse>(DoROARequest("WriteAlibabaUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaUserDetails/write", "json", req, runtime));
        }

        public async Task<WriteAlibabaUserCarbonResponse> WriteAlibabaUserCarbonWithOptionsAsync(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
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
            return TeaModel.ToObject<WriteAlibabaUserCarbonResponse>(await DoROARequestAsync("WriteAlibabaUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaUserDetails/write", "json", req, runtime));
        }

        public WriteIsvStateResponse WriteIsvState(WriteIsvStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteIsvStateHeaders headers = new WriteIsvStateHeaders();
            return WriteIsvStateWithOptions(request, headers, runtime);
        }

        public async Task<WriteIsvStateResponse> WriteIsvStateAsync(WriteIsvStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteIsvStateHeaders headers = new WriteIsvStateHeaders();
            return await WriteIsvStateWithOptionsAsync(request, headers, runtime);
        }

        public WriteIsvStateResponse WriteIsvStateWithOptions(WriteIsvStateRequest request, WriteIsvStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isvName"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<WriteIsvStateResponse>(DoROARequest("WriteIsvState", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/datas/states/write", "json", req, runtime));
        }

        public async Task<WriteIsvStateResponse> WriteIsvStateWithOptionsAsync(WriteIsvStateRequest request, WriteIsvStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isvName"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<WriteIsvStateResponse>(await DoROARequestAsync("WriteIsvState", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/datas/states/write", "json", req, runtime));
        }

        public WriteOrgCarbonResponse WriteOrgCarbon(WriteOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
            return WriteOrgCarbonWithOptions(request, headers, runtime);
        }

        public async Task<WriteOrgCarbonResponse> WriteOrgCarbonAsync(WriteOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
            return await WriteOrgCarbonWithOptionsAsync(request, headers, runtime);
        }

        public WriteOrgCarbonResponse WriteOrgCarbonWithOptions(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
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
            return TeaModel.ToObject<WriteOrgCarbonResponse>(DoROARequest("WriteOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/orgDetails/write", "json", req, runtime));
        }

        public async Task<WriteOrgCarbonResponse> WriteOrgCarbonWithOptionsAsync(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
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
            return TeaModel.ToObject<WriteOrgCarbonResponse>(await DoROARequestAsync("WriteOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/orgDetails/write", "json", req, runtime));
        }

        public WriteUserCarbonResponse WriteUserCarbon(WriteUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
            return WriteUserCarbonWithOptions(request, headers, runtime);
        }

        public async Task<WriteUserCarbonResponse> WriteUserCarbonAsync(WriteUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
            return await WriteUserCarbonWithOptionsAsync(request, headers, runtime);
        }

        public WriteUserCarbonResponse WriteUserCarbonWithOptions(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
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
            return TeaModel.ToObject<WriteUserCarbonResponse>(DoROARequest("WriteUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/userDetails/write", "json", req, runtime));
        }

        public async Task<WriteUserCarbonResponse> WriteUserCarbonWithOptionsAsync(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
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
            return TeaModel.ToObject<WriteUserCarbonResponse>(await DoROARequestAsync("WriteUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/userDetails/write", "json", req, runtime));
        }

    }
}
