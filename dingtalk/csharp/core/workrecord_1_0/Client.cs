// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkworkrecord_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkworkrecord_1_0
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


        /**
         * @summary 查询个人单企业待办数
         *
         * @param request CountWorkRecordRequest
         * @param headers CountWorkRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CountWorkRecordResponse
         */
        public CountWorkRecordResponse CountWorkRecordWithOptions(CountWorkRecordRequest request, CountWorkRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountWorkRecord",
                Version = "workrecord_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workrecord/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountWorkRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询个人单企业待办数
         *
         * @param request CountWorkRecordRequest
         * @param headers CountWorkRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CountWorkRecordResponse
         */
        public async Task<CountWorkRecordResponse> CountWorkRecordWithOptionsAsync(CountWorkRecordRequest request, CountWorkRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountWorkRecord",
                Version = "workrecord_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workrecord/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountWorkRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询个人单企业待办数
         *
         * @param request CountWorkRecordRequest
         * @return CountWorkRecordResponse
         */
        public CountWorkRecordResponse CountWorkRecord(CountWorkRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountWorkRecordHeaders headers = new CountWorkRecordHeaders();
            return CountWorkRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询个人单企业待办数
         *
         * @param request CountWorkRecordRequest
         * @return CountWorkRecordResponse
         */
        public async Task<CountWorkRecordResponse> CountWorkRecordAsync(CountWorkRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountWorkRecordHeaders headers = new CountWorkRecordHeaders();
            return await CountWorkRecordWithOptionsAsync(request, headers, runtime);
        }

    }
}
