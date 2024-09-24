<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceWithDelegateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CopyTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CopyTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CopyTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardWithDelegateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeleteTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeleteTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeleteTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardWithDelegateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\GetTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\GetTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\GetTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\PublishTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\PublishTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\PublishTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackWithDelegateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\SaveTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\SaveTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\SaveTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\StreamingUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\StreamingUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\StreamingUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardWithDelegateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardWithDelegateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardWithDelegateResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 新增或更新卡片的场域信息
     *  *
     * @param AppendSpaceRequest $request AppendSpaceRequest
     * @param AppendSpaceHeaders $headers AppendSpaceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return AppendSpaceResponse AppendSpaceResponse
     */
    public function appendSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
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
            'action'      => 'AppendSpace',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/instances/spaces',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppendSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增或更新卡片的场域信息
     *  *
     * @param AppendSpaceRequest $request AppendSpaceRequest
     *
     * @return AppendSpaceResponse AppendSpaceResponse
     */
    public function appendSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendSpaceHeaders([]);

        return $this->appendSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增或更新卡片的场域信息
     *  *
     * @param AppendSpaceWithDelegateRequest $request AppendSpaceWithDelegateRequest
     * @param AppendSpaceWithDelegateHeaders $headers AppendSpaceWithDelegateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AppendSpaceWithDelegateResponse AppendSpaceWithDelegateResponse
     */
    public function appendSpaceWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
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
            'action'      => 'AppendSpaceWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/instances/spaces',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppendSpaceWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增或更新卡片的场域信息
     *  *
     * @param AppendSpaceWithDelegateRequest $request AppendSpaceWithDelegateRequest
     *
     * @return AppendSpaceWithDelegateResponse AppendSpaceWithDelegateResponse
     */
    public function appendSpaceWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendSpaceWithDelegateHeaders([]);

        return $this->appendSpaceWithDelegateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 复制模板
     *  *
     * @param CopyTemplateRequest $request CopyTemplateRequest
     * @param CopyTemplateHeaders $headers CopyTemplateHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CopyTemplateResponse CopyTemplateResponse
     */
    public function copyTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'CopyTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates/copy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CopyTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 复制模板
     *  *
     * @param CopyTemplateRequest $request CopyTemplateRequest
     *
     * @return CopyTemplateResponse CopyTemplateResponse
     */
    public function copyTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyTemplateHeaders([]);

        return $this->copyTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建并投放卡片
     *  *
     * @param CreateAndDeliverRequest $request CreateAndDeliverRequest
     * @param CreateAndDeliverHeaders $headers CreateAndDeliverHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAndDeliverResponse CreateAndDeliverResponse
     */
    public function createAndDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackType)) {
            $body['callbackType'] = $request->callbackType;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            $body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            $body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            $body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            $body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imSingleOpenDeliverModel)) {
            $body['imSingleOpenDeliverModel'] = $request->imSingleOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imSingleOpenSpaceModel)) {
            $body['imSingleOpenSpaceModel'] = $request->imSingleOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            $body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            $body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            $body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'CreateAndDeliver',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/instances/createAndDeliver',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateAndDeliverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建并投放卡片
     *  *
     * @param CreateAndDeliverRequest $request CreateAndDeliverRequest
     *
     * @return CreateAndDeliverResponse CreateAndDeliverResponse
     */
    public function createAndDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAndDeliverHeaders([]);

        return $this->createAndDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建并投放卡片
     *  *
     * @param CreateAndDeliverWithDelegateRequest $request CreateAndDeliverWithDelegateRequest
     * @param CreateAndDeliverWithDelegateHeaders $headers CreateAndDeliverWithDelegateHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAndDeliverWithDelegateResponse CreateAndDeliverWithDelegateResponse
     */
    public function createAndDeliverWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackType)) {
            $body['callbackType'] = $request->callbackType;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            $body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            $body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            $body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            $body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imSingleOpenDeliverModel)) {
            $body['imSingleOpenDeliverModel'] = $request->imSingleOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imSingleOpenSpaceModel)) {
            $body['imSingleOpenSpaceModel'] = $request->imSingleOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            $body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            $body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            $body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'CreateAndDeliverWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/instances/createAndDeliver',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateAndDeliverWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建并投放卡片
     *  *
     * @param CreateAndDeliverWithDelegateRequest $request CreateAndDeliverWithDelegateRequest
     *
     * @return CreateAndDeliverWithDelegateResponse CreateAndDeliverWithDelegateResponse
     */
    public function createAndDeliverWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAndDeliverWithDelegateHeaders([]);

        return $this->createAndDeliverWithDelegateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建卡片
     *  *
     * @param CreateCardRequest $request CreateCardRequest
     * @param CreateCardHeaders $headers CreateCardHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCardResponse CreateCardResponse
     */
    public function createCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackType)) {
            $body['callbackType'] = $request->callbackType;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imSingleOpenSpaceModel)) {
            $body['imSingleOpenSpaceModel'] = $request->imSingleOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            $body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'CreateCard',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建卡片
     *  *
     * @param CreateCardRequest $request CreateCardRequest
     *
     * @return CreateCardResponse CreateCardResponse
     */
    public function createCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCardHeaders([]);

        return $this->createCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建卡片
     *  *
     * @param CreateCardWithDelegateRequest $request CreateCardWithDelegateRequest
     * @param CreateCardWithDelegateHeaders $headers CreateCardWithDelegateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCardWithDelegateResponse CreateCardWithDelegateResponse
     */
    public function createCardWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackType)) {
            $body['callbackType'] = $request->callbackType;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->coFeedOpenSpaceModel)) {
            $body['coFeedOpenSpaceModel'] = $request->coFeedOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imGroupOpenSpaceModel)) {
            $body['imGroupOpenSpaceModel'] = $request->imGroupOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imRobotOpenSpaceModel)) {
            $body['imRobotOpenSpaceModel'] = $request->imRobotOpenSpaceModel;
        }
        if (!Utils::isUnset($request->imSingleOpenSpaceModel)) {
            $body['imSingleOpenSpaceModel'] = $request->imSingleOpenSpaceModel;
        }
        if (!Utils::isUnset($request->openDynamicDataConfig)) {
            $body['openDynamicDataConfig'] = $request->openDynamicDataConfig;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->topOpenSpaceModel)) {
            $body['topOpenSpaceModel'] = $request->topOpenSpaceModel;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'CreateCardWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCardWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建卡片
     *  *
     * @param CreateCardWithDelegateRequest $request CreateCardWithDelegateRequest
     *
     * @return CreateCardWithDelegateResponse CreateCardWithDelegateResponse
     */
    public function createCardWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCardWithDelegateHeaders([]);

        return $this->createCardWithDelegateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建模板
     *  *
     * @param CreateTemplateRequest $request CreateTemplateRequest
     * @param CreateTemplateHeaders $headers CreateTemplateHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTemplateResponse CreateTemplateResponse
     */
    public function createTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->creatorId)) {
            $body['creatorId'] = $request->creatorId;
        }
        if (!Utils::isUnset($request->extendType)) {
            $body['extendType'] = $request->extendType;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'CreateTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建模板
     *  *
     * @param CreateTemplateRequest $request CreateTemplateRequest
     *
     * @return CreateTemplateResponse CreateTemplateResponse
     */
    public function createTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTemplateHeaders([]);

        return $this->createTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除模板
     *  *
     * @param DeleteTemplateRequest $request DeleteTemplateRequest
     * @param DeleteTemplateHeaders $headers DeleteTemplateHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTemplateResponse DeleteTemplateResponse
     */
    public function deleteTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'DeleteTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除模板
     *  *
     * @param DeleteTemplateRequest $request DeleteTemplateRequest
     *
     * @return DeleteTemplateResponse DeleteTemplateResponse
     */
    public function deleteTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTemplateHeaders([]);

        return $this->deleteTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 投放卡片
     *  *
     * @param DeliverCardRequest $request DeliverCardRequest
     * @param DeliverCardHeaders $headers DeliverCardHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeliverCardResponse DeliverCardResponse
     */
    public function deliverCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            $body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            $body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            $body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            $body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imSingleOpenDeliverModel)) {
            $body['imSingleOpenDeliverModel'] = $request->imSingleOpenDeliverModel;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            $body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            $body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'DeliverCard',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/instances/deliver',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeliverCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 投放卡片
     *  *
     * @param DeliverCardRequest $request DeliverCardRequest
     *
     * @return DeliverCardResponse DeliverCardResponse
     */
    public function deliverCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeliverCardHeaders([]);

        return $this->deliverCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 投放卡片
     *  *
     * @param DeliverCardWithDelegateRequest $request DeliverCardWithDelegateRequest
     * @param DeliverCardWithDelegateHeaders $headers DeliverCardWithDelegateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeliverCardWithDelegateResponse DeliverCardWithDelegateResponse
     */
    public function deliverCardWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coFeedOpenDeliverModel)) {
            $body['coFeedOpenDeliverModel'] = $request->coFeedOpenDeliverModel;
        }
        if (!Utils::isUnset($request->docOpenDeliverModel)) {
            $body['docOpenDeliverModel'] = $request->docOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imGroupOpenDeliverModel)) {
            $body['imGroupOpenDeliverModel'] = $request->imGroupOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imRobotOpenDeliverModel)) {
            $body['imRobotOpenDeliverModel'] = $request->imRobotOpenDeliverModel;
        }
        if (!Utils::isUnset($request->imSingleOpenDeliverModel)) {
            $body['imSingleOpenDeliverModel'] = $request->imSingleOpenDeliverModel;
        }
        if (!Utils::isUnset($request->openSpaceId)) {
            $body['openSpaceId'] = $request->openSpaceId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->topOpenDeliverModel)) {
            $body['topOpenDeliverModel'] = $request->topOpenDeliverModel;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'DeliverCardWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/instances/deliver',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeliverCardWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 投放卡片
     *  *
     * @param DeliverCardWithDelegateRequest $request DeliverCardWithDelegateRequest
     *
     * @return DeliverCardWithDelegateResponse DeliverCardWithDelegateResponse
     */
    public function deliverCardWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeliverCardWithDelegateHeaders([]);

        return $this->deliverCardWithDelegateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取模板信息
     *  *
     * @param GetTemplateRequest $request GetTemplateRequest
     * @param GetTemplateHeaders $headers GetTemplateHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTemplateResponse GetTemplateResponse
     */
    public function getTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
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
            'action'      => 'GetTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取模板信息
     *  *
     * @param GetTemplateRequest $request GetTemplateRequest
     *
     * @return GetTemplateResponse GetTemplateResponse
     */
    public function getTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTemplateHeaders([]);

        return $this->getTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发布模板
     *  *
     * @param PublishTemplateRequest $request PublishTemplateRequest
     * @param PublishTemplateHeaders $headers PublishTemplateHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return PublishTemplateResponse PublishTemplateResponse
     */
    public function publishTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateSource)) {
            $body['templateSource'] = $request->templateSource;
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
            'action'      => 'PublishTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates/publish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PublishTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布模板
     *  *
     * @param PublishTemplateRequest $request PublishTemplateRequest
     *
     * @return PublishTemplateResponse PublishTemplateResponse
     */
    public function publishTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishTemplateHeaders([]);

        return $this->publishTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册卡片回调地址
     *  *
     * @param RegisterCallbackRequest $request RegisterCallbackRequest
     * @param RegisterCallbackHeaders $headers RegisterCallbackHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterCallbackResponse RegisterCallbackResponse
     */
    public function registerCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            $body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->forceUpdate)) {
            $body['forceUpdate'] = $request->forceUpdate;
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
            'action'      => 'RegisterCallback',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/callbacks/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RegisterCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册卡片回调地址
     *  *
     * @param RegisterCallbackRequest $request RegisterCallbackRequest
     *
     * @return RegisterCallbackResponse RegisterCallbackResponse
     */
    public function registerCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCallbackHeaders([]);

        return $this->registerCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册卡片回调地址
     *  *
     * @param RegisterCallbackWithDelegateRequest $request RegisterCallbackWithDelegateRequest
     * @param RegisterCallbackWithDelegateHeaders $headers RegisterCallbackWithDelegateHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterCallbackWithDelegateResponse RegisterCallbackWithDelegateResponse
     */
    public function registerCallbackWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            $body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->forceUpdate)) {
            $body['forceUpdate'] = $request->forceUpdate;
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
            'action'      => 'RegisterCallbackWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/callbacks/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RegisterCallbackWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册卡片回调地址
     *  *
     * @param RegisterCallbackWithDelegateRequest $request RegisterCallbackWithDelegateRequest
     *
     * @return RegisterCallbackWithDelegateResponse RegisterCallbackWithDelegateResponse
     */
    public function registerCallbackWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCallbackWithDelegateHeaders([]);

        return $this->registerCallbackWithDelegateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存模板
     *  *
     * @param SaveTemplateRequest $request SaveTemplateRequest
     * @param SaveTemplateHeaders $headers SaveTemplateHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveTemplateResponse SaveTemplateResponse
     */
    public function saveTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateSource)) {
            $body['templateSource'] = $request->templateSource;
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
            'action'      => 'SaveTemplate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/templates/save',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存模板
     *  *
     * @param SaveTemplateRequest $request SaveTemplateRequest
     *
     * @return SaveTemplateResponse SaveTemplateResponse
     */
    public function saveTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveTemplateHeaders([]);

        return $this->saveTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary AI互动卡片流式更新
     *  *
     * @param StreamingUpdateRequest $request StreamingUpdateRequest
     * @param StreamingUpdateHeaders $headers StreamingUpdateHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return StreamingUpdateResponse StreamingUpdateResponse
     */
    public function streamingUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->guid)) {
            $body['guid'] = $request->guid;
        }
        if (!Utils::isUnset($request->isError)) {
            $body['isError'] = $request->isError;
        }
        if (!Utils::isUnset($request->isFinalize)) {
            $body['isFinalize'] = $request->isFinalize;
        }
        if (!Utils::isUnset($request->isFull)) {
            $body['isFull'] = $request->isFull;
        }
        if (!Utils::isUnset($request->key)) {
            $body['key'] = $request->key;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
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
            'action'      => 'StreamingUpdate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/streaming',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StreamingUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary AI互动卡片流式更新
     *  *
     * @param StreamingUpdateRequest $request StreamingUpdateRequest
     *
     * @return StreamingUpdateResponse StreamingUpdateResponse
     */
    public function streamingUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StreamingUpdateHeaders([]);

        return $this->streamingUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardRequest $request UpdateCardRequest
     * @param UpdateCardHeaders $headers UpdateCardHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCardResponse UpdateCardResponse
     */
    public function updateCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardUpdateOptions)) {
            $body['cardUpdateOptions'] = $request->cardUpdateOptions;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'UpdateCard',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardRequest $request UpdateCardRequest
     *
     * @return UpdateCardResponse UpdateCardResponse
     */
    public function updateCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCardHeaders([]);

        return $this->updateCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardWithDelegateRequest $request UpdateCardWithDelegateRequest
     * @param UpdateCardWithDelegateHeaders $headers UpdateCardWithDelegateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCardWithDelegateResponse UpdateCardWithDelegateResponse
     */
    public function updateCardWithDelegateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardUpdateOptions)) {
            $body['cardUpdateOptions'] = $request->cardUpdateOptions;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'UpdateCardWithDelegate',
            'version'     => 'card_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/card/me/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCardWithDelegateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardWithDelegateRequest $request UpdateCardWithDelegateRequest
     *
     * @return UpdateCardWithDelegateResponse UpdateCardWithDelegateResponse
     */
    public function updateCardWithDelegate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCardWithDelegateHeaders([]);

        return $this->updateCardWithDelegateWithOptions($request, $headers, $runtime);
    }
}
