<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AppendSpaceRequest $request
     *
     * @return AppendSpaceResponse
     */
    public function appendSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendSpaceHeaders([]);

        return $this->appendSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AppendSpaceRequest $request
     * @param AppendSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return AppendSpaceResponse
     */
    public function appendSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            @$body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            @$body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            @$body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            @$body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AppendSpaceResponse::fromMap($this->doROARequest('AppendSpace', 'card_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/card/instances/spaces', 'json', $req, $runtime));
    }

    /**
     * @param CreateAndDeliverRequest $request
     *
     * @return CreateAndDeliverResponse
     */
    public function createAndDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAndDeliverHeaders([]);

        return $this->createAndDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateAndDeliverRequest $request
     * @param CreateAndDeliverHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateAndDeliverResponse
     */
    public function createAndDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            @$body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            @$body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            @$body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            @$body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            @$body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            @$body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            @$body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            @$body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            @$body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            @$body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            @$body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            @$body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateAndDeliverResponse::fromMap($this->doROARequest('CreateAndDeliver', 'card_1.0', 'HTTP', 'POST', 'AK', '/v1.0/card/instances/createAndDeliver', 'json', $req, $runtime));
    }

    /**
     * @param CreateCardRequest $request
     *
     * @return CreateCardResponse
     */
    public function createCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCardHeaders([]);

        return $this->createCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCardRequest $request
     * @param CreateCardHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateCardResponse
     */
    public function createCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            @$body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            @$body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            @$body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            @$body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            @$body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            @$body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateCardResponse::fromMap($this->doROARequest('CreateCard', 'card_1.0', 'HTTP', 'POST', 'AK', '/v1.0/card/instances', 'json', $req, $runtime));
    }

    /**
     * @param DeliverCardRequest $request
     *
     * @return DeliverCardResponse
     */
    public function deliverCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeliverCardHeaders([]);

        return $this->deliverCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeliverCardRequest $request
     * @param DeliverCardHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeliverCardResponse
     */
    public function deliverCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            @$body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            @$body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            @$body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            @$body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            @$body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            @$body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeliverCardResponse::fromMap($this->doROARequest('DeliverCard', 'card_1.0', 'HTTP', 'POST', 'AK', '/v1.0/card/instances/deliver', 'json', $req, $runtime));
    }

    /**
     * @param RegisterCallbackRequest $request
     *
     * @return RegisterCallbackResponse
     */
    public function registerCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCallbackHeaders([]);

        return $this->registerCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterCallbackRequest $request
     * @param RegisterCallbackHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RegisterCallbackResponse
     */
    public function registerCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            @$body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            @$body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            @$body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->forceUpdate)) {
            @$body['forceUpdate'] = $request->forceUpdate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterCallbackResponse::fromMap($this->doROARequest('RegisterCallback', 'card_1.0', 'HTTP', 'POST', 'AK', '/v1.0/card/callbacks/register', 'json', $req, $runtime));
    }

    /**
     * @param UpdateCardRequest $request
     *
     * @return UpdateCardResponse
     */
    public function updateCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCardHeaders([]);

        return $this->updateCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCardRequest $request
     * @param UpdateCardHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UpdateCardResponse
     */
    public function updateCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardUpdateOptions)) {
            @$body['cardUpdateOptions'] = $request->cardUpdateOptions;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateCardResponse::fromMap($this->doROARequest('UpdateCard', 'card_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/card/instances', 'json', $req, $runtime));
    }
}
