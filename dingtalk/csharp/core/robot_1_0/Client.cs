// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkrobot_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0
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


        public BatchSendOTOResponse BatchSendOTO(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return BatchSendOTOWithOptions(request, headers, runtime);
        }

        public async Task<BatchSendOTOResponse> BatchSendOTOAsync(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return await BatchSendOTOWithOptionsAsync(request, headers, runtime);
        }

        public BatchSendOTOResponse BatchSendOTOWithOptions(BatchSendOTORequest request, BatchSendOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
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
            return TeaModel.ToObject<BatchSendOTOResponse>(DoROARequest("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/oToMessages/batchSend", "json", req, runtime));
        }

        public async Task<BatchSendOTOResponse> BatchSendOTOWithOptionsAsync(BatchSendOTORequest request, BatchSendOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
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
            return TeaModel.ToObject<BatchSendOTOResponse>(await DoROARequestAsync("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/oToMessages/batchSend", "json", req, runtime));
        }

        public BatchOTOQueryResponse BatchOTOQuery(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return BatchOTOQueryWithOptions(request, headers, runtime);
        }

        public async Task<BatchOTOQueryResponse> BatchOTOQueryAsync(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return await BatchOTOQueryWithOptionsAsync(request, headers, runtime);
        }

        public BatchOTOQueryResponse BatchOTOQueryWithOptions(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                query["processQueryKey"] = request.ProcessQueryKey;
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
            return TeaModel.ToObject<BatchOTOQueryResponse>(DoROARequest("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", "/v1.0/robot/oToMessages/readStatus", "json", req, runtime));
        }

        public async Task<BatchOTOQueryResponse> BatchOTOQueryWithOptionsAsync(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                query["processQueryKey"] = request.ProcessQueryKey;
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
            return TeaModel.ToObject<BatchOTOQueryResponse>(await DoROARequestAsync("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", "/v1.0/robot/oToMessages/readStatus", "json", req, runtime));
        }

        public SendRobotDingMessageResponse SendRobotDingMessage(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return SendRobotDingMessageWithOptions(request, headers, runtime);
        }

        public async Task<SendRobotDingMessageResponse> SendRobotDingMessageAsync(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return await SendRobotDingMessageWithOptionsAsync(request, headers, runtime);
        }

        public SendRobotDingMessageResponse SendRobotDingMessageWithOptions(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTemplateId))
            {
                body["dingTemplateId"] = request.DingTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentParams))
            {
                body["contentParams"] = request.ContentParams;
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
            return TeaModel.ToObject<SendRobotDingMessageResponse>(DoROARequest("SendRobotDingMessage", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/dingMessages/send", "json", req, runtime));
        }

        public async Task<SendRobotDingMessageResponse> SendRobotDingMessageWithOptionsAsync(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTemplateId))
            {
                body["dingTemplateId"] = request.DingTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentParams))
            {
                body["contentParams"] = request.ContentParams;
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
            return TeaModel.ToObject<SendRobotDingMessageResponse>(await DoROARequestAsync("SendRobotDingMessage", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/dingMessages/send", "json", req, runtime));
        }

    }
}
