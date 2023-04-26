<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AddRobotInstanceToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AddRobotInstanceToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AddRobotInstanceToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AskRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AskRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\AskRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetIntelligentRobotInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetIntelligentRobotInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetIntelligentRobotInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetOfficialAccountRobotInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetOfficialAccountRobotInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetOfficialAccountRobotInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetWebChannelUserTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetWebChannelUserTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetWebChannelUserTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushCustomerGroupMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushCustomerGroupMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushCustomerGroupMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotGroupMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotGroupMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotGroupMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushIntelligentRobotMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushOfficialAccountMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushOfficialAccountMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushOfficialAccountMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushRobotMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushRobotMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\PushRobotMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\ReplyRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\ReplyRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\ReplyRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\UpdateOfficialAccountRobotInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\UpdateOfficialAccountRobotInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\UpdateOfficialAccountRobotInfoResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AddRobotInstanceToGroupRequest $request
     * @param AddRobotInstanceToGroupHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return AddRobotInstanceToGroupResponse
     */
    public function addRobotInstanceToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatbotId)) {
            $body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddRobotInstanceToGroup',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/intelligentRobots/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddRobotInstanceToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddRobotInstanceToGroupRequest $request
     *
     * @return AddRobotInstanceToGroupResponse
     */
    public function addRobotInstanceToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRobotInstanceToGroupHeaders([]);

        return $this->addRobotInstanceToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AskRobotRequest $request
     * @param AskRobotHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return AskRobotResponse
     */
    public function askRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingUserId)) {
            $body['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->question)) {
            $body['question'] = $request->question;
        }
        if (!Utils::isUnset($request->robotAppKey)) {
            $body['robotAppKey'] = $request->robotAppKey;
        }
        if (!Utils::isUnset($request->sessionUuid)) {
            $body['sessionUuid'] = $request->sessionUuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AskRobot',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/robots/ask',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AskRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AskRobotRequest $request
     *
     * @return AskRobotResponse
     */
    public function askRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AskRobotHeaders([]);

        return $this->askRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDingMeBaseDataRequest $request
     * @param GetDingMeBaseDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetDingMeBaseDataResponse
     */
    public function getDingMeBaseDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appKey)) {
            $query['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->byDay)) {
            $query['byDay'] = $request->byDay;
        }
        if (!Utils::isUnset($request->endDay)) {
            $query['endDay'] = $request->endDay;
        }
        if (!Utils::isUnset($request->startDay)) {
            $query['startDay'] = $request->startDay;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDingMeBaseData',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/robots/data',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetDingMeBaseDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetDingMeBaseDataRequest $request
     *
     * @return GetDingMeBaseDataResponse
     */
    public function getDingMeBaseData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingMeBaseDataHeaders([]);

        return $this->getDingMeBaseDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetIntelligentRobotInfoRequest $request
     * @param GetIntelligentRobotInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetIntelligentRobotInfoResponse
     */
    public function getIntelligentRobotInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->robotAppKey)) {
            $query['robotAppKey'] = $request->robotAppKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetIntelligentRobotInfo',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/intelligentRobots/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetIntelligentRobotInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetIntelligentRobotInfoRequest $request
     *
     * @return GetIntelligentRobotInfoResponse
     */
    public function getIntelligentRobotInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIntelligentRobotInfoHeaders([]);

        return $this->getIntelligentRobotInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOfficialAccountRobotInfoRequest $request
     * @param GetOfficialAccountRobotInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetOfficialAccountRobotInfoResponse
     */
    public function getOfficialAccountRobotInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetOfficialAccountRobotInfo',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/officialAccounts/robots',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOfficialAccountRobotInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOfficialAccountRobotInfoRequest $request
     *
     * @return GetOfficialAccountRobotInfoResponse
     */
    public function getOfficialAccountRobotInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountRobotInfoHeaders([]);

        return $this->getOfficialAccountRobotInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetWebChannelUserTokenRequest $request
     * @param GetWebChannelUserTokenHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetWebChannelUserTokenResponse
     */
    public function getWebChannelUserTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->foreignId)) {
            $body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->nick)) {
            $body['nick'] = $request->nick;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetWebChannelUserToken',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/webChannels/userTokens',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWebChannelUserTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetWebChannelUserTokenRequest $request
     *
     * @return GetWebChannelUserTokenResponse
     */
    public function getWebChannelUserToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWebChannelUserTokenHeaders([]);

        return $this->getWebChannelUserTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushCustomerGroupMessageRequest $request
     * @param PushCustomerGroupMessageHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return PushCustomerGroupMessageResponse
     */
    public function pushCustomerGroupMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushCustomerGroupMessage',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/officialAccounts/robots/groupMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushCustomerGroupMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushCustomerGroupMessageRequest $request
     *
     * @return PushCustomerGroupMessageResponse
     */
    public function pushCustomerGroupMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushCustomerGroupMessageHeaders([]);

        return $this->pushCustomerGroupMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushIntelligentRobotGroupMessageRequest $request
     * @param PushIntelligentRobotGroupMessageHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return PushIntelligentRobotGroupMessageResponse
     */
    public function pushIntelligentRobotGroupMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatbotId)) {
            $body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushIntelligentRobotGroupMessage',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/intelligentRobots/groupMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushIntelligentRobotGroupMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushIntelligentRobotGroupMessageRequest $request
     *
     * @return PushIntelligentRobotGroupMessageResponse
     */
    public function pushIntelligentRobotGroupMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushIntelligentRobotGroupMessageHeaders([]);

        return $this->pushIntelligentRobotGroupMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushIntelligentRobotMessageRequest $request
     * @param PushIntelligentRobotMessageHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return PushIntelligentRobotMessageResponse
     */
    public function pushIntelligentRobotMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatbotId)) {
            $body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushIntelligentRobotMessage',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/intelligentRobots/oToMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushIntelligentRobotMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushIntelligentRobotMessageRequest $request
     *
     * @return PushIntelligentRobotMessageResponse
     */
    public function pushIntelligentRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushIntelligentRobotMessageHeaders([]);

        return $this->pushIntelligentRobotMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushOfficialAccountMessageRequest $request
     * @param PushOfficialAccountMessageHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return PushOfficialAccountMessageResponse
     */
    public function pushOfficialAccountMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushOfficialAccountMessage',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/officialAccounts/robots/oToMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushOfficialAccountMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushOfficialAccountMessageRequest $request
     *
     * @return PushOfficialAccountMessageResponse
     */
    public function pushOfficialAccountMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushOfficialAccountMessageHeaders([]);

        return $this->pushOfficialAccountMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushRobotMessageRequest $request
     * @param PushRobotMessageHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PushRobotMessageResponse
     */
    public function pushRobotMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatbotId)) {
            $body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushRobotMessage',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/robots/oToMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushRobotMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushRobotMessageRequest $request
     *
     * @return PushRobotMessageResponse
     */
    public function pushRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushRobotMessageHeaders([]);

        return $this->pushRobotMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReplyRobotRequest $request
     * @param ReplyRobotHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ReplyRobotResponse
     */
    public function replyRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->proxyMessageStr)) {
            $body['proxyMessageStr'] = $request->proxyMessageStr;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ReplyRobot',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/robots/reply',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ReplyRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReplyRobotRequest $request
     *
     * @return ReplyRobotResponse
     */
    public function replyRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReplyRobotHeaders([]);

        return $this->replyRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateOfficialAccountRobotInfoRequest $request
     * @param UpdateOfficialAccountRobotInfoHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return UpdateOfficialAccountRobotInfoResponse
     */
    public function updateOfficialAccountRobotInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
        $body = [];
        if (!Utils::isUnset($request->avatar)) {
            $body['avatar'] = $request->avatar;
        }
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->previewMediaUrl)) {
            $body['previewMediaUrl'] = $request->previewMediaUrl;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateOfficialAccountRobotInfo',
            'version'     => 'dingmi_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingmi/officialAccounts/robots',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOfficialAccountRobotInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateOfficialAccountRobotInfoRequest $request
     *
     * @return UpdateOfficialAccountRobotInfoResponse
     */
    public function updateOfficialAccountRobotInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOfficialAccountRobotInfoHeaders([]);

        return $this->updateOfficialAccountRobotInfoWithOptions($request, $headers, $runtime);
    }
}
