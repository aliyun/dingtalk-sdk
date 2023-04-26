<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxResponse;
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
     * @param CloseTopboxRequest $request
     * @param CloseTopboxHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CloseTopboxResponse
     */
    public function closeTopboxWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->unoinId)) {
            $body['unoinId'] = $request->unoinId;
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
            'action'      => 'CloseTopbox',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/topBoxes/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseTopboxResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CloseTopboxRequest $request
     *
     * @return CloseTopboxResponse
     */
    public function closeTopbox($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseTopboxHeaders([]);

        return $this->closeTopboxWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTopboxRequest $request
     * @param CreateTopboxHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateTopboxResponse
     */
    public function createTopboxWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardSettings)) {
            $body['cardSettings'] = $request->cardSettings;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->expiredTime)) {
            $body['expiredTime'] = $request->expiredTime;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->platforms)) {
            $body['platforms'] = $request->platforms;
        }
        if (!Utils::isUnset($request->receiverUnionIdList)) {
            $body['receiverUnionIdList'] = $request->receiverUnionIdList;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->unionIdPrivateDataMap)) {
            $body['unionIdPrivateDataMap'] = $request->unionIdPrivateDataMap;
        }
        if (!Utils::isUnset($request->unoinId)) {
            $body['unoinId'] = $request->unoinId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdPrivateDataMap)) {
            $body['userIdPrivateDataMap'] = $request->userIdPrivateDataMap;
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
            'action'      => 'CreateTopbox',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/topBoxes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTopboxResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTopboxRequest $request
     *
     * @return CreateTopboxResponse
     */
    public function createTopbox($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTopboxHeaders([]);

        return $this->createTopboxWithOptions($request, $headers, $runtime);
    }
}
