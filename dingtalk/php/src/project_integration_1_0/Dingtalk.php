<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0;

use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\AddAttendeeToEventGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\AddAttendeeToEventGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\CreateEventGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\CreateEventGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\SendInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\SendInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\SendSingleInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\SendSingleInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\UpdateInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0\Models\UpdateInteractiveCardResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 在项目事件会话中加人
     *  *
     * @param string                         $userId
     * @param string                         $groupId
     * @param AddAttendeeToEventGroupHeaders $headers AddAttendeeToEventGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AddAttendeeToEventGroupResponse AddAttendeeToEventGroupResponse
     */
    public function addAttendeeToEventGroupWithOptions($userId, $groupId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'AddAttendeeToEventGroup',
            'version' => 'projectIntegration_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/projectIntegration/users/' . $userId . '/eventGroups/' . $groupId . '/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddAttendeeToEventGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 在项目事件会话中加人
     *  *
     * @param string $userId
     * @param string $groupId
     *
     * @return AddAttendeeToEventGroupResponse AddAttendeeToEventGroupResponse
     */
    public function addAttendeeToEventGroup($userId, $groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAttendeeToEventGroupHeaders([]);

        return $this->addAttendeeToEventGroupWithOptions($userId, $groupId, $headers, $runtime);
    }

    /**
     * @summary 创建项目事件会话
     *  *
     * @param string                  $userId
     * @param CreateEventGroupHeaders $headers CreateEventGroupHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateEventGroupResponse CreateEventGroupResponse
     */
    public function createEventGroupWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'CreateEventGroup',
            'version' => 'projectIntegration_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/projectIntegration/users/' . $userId . '/eventGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateEventGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建项目事件会话
     *  *
     * @param string $userId
     *
     * @return CreateEventGroupResponse CreateEventGroupResponse
     */
    public function createEventGroup($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventGroupHeaders([]);

        return $this->createEventGroupWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 在群会话发送项目卡片消息
     *  *
     * @param string                     $userId
     * @param SendInteractiveCardHeaders $headers SendInteractiveCardHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SendInteractiveCardResponse SendInteractiveCardResponse
     */
    public function sendInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'SendInteractiveCard',
            'version' => 'projectIntegration_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/projectIntegration/users/' . $userId . '/groupChatCardMessages',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SendInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 在群会话发送项目卡片消息
     *  *
     * @param string $userId
     *
     * @return SendInteractiveCardResponse SendInteractiveCardResponse
     */
    public function sendInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveCardHeaders([]);

        return $this->sendInteractiveCardWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 单聊会话发送项目卡片消息
     *  *
     * @param string                           $userId
     * @param SendSingleInteractiveCardHeaders $headers SendSingleInteractiveCardHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SendSingleInteractiveCardResponse SendSingleInteractiveCardResponse
     */
    public function sendSingleInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'SendSingleInteractiveCard',
            'version' => 'projectIntegration_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/projectIntegration/users/' . $userId . '/singleChatCardMessages',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SendSingleInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 单聊会话发送项目卡片消息
     *  *
     * @param string $userId
     *
     * @return SendSingleInteractiveCardResponse SendSingleInteractiveCardResponse
     */
    public function sendSingleInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendSingleInteractiveCardHeaders([]);

        return $this->sendSingleInteractiveCardWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 更新项目卡片消息
     *  *
     * @param string                       $userId
     * @param UpdateInteractiveCardHeaders $headers UpdateInteractiveCardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInteractiveCardResponse UpdateInteractiveCardResponse
     */
    public function updateInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'UpdateInteractiveCard',
            'version' => 'projectIntegration_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/projectIntegration/users/' . $userId . '/cardMessages',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新项目卡片消息
     *  *
     * @param string $userId
     *
     * @return UpdateInteractiveCardResponse UpdateInteractiveCardResponse
     */
    public function updateInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveCardHeaders([]);

        return $this->updateInteractiveCardWithOptions($userId, $headers, $runtime);
    }
}
