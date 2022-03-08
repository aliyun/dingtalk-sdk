<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_integration_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
     * @param string $userId
     * @param string $groupId
     *
     * @return AddAttendeeToEventGroupResponse
     */
    public function addAttendeeToEventGroup($userId, $groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAttendeeToEventGroupHeaders([]);

        return $this->addAttendeeToEventGroupWithOptions($userId, $groupId, $headers, $runtime);
    }

    /**
     * @param string                         $userId
     * @param string                         $groupId
     * @param AddAttendeeToEventGroupHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return AddAttendeeToEventGroupResponse
     */
    public function addAttendeeToEventGroupWithOptions($userId, $groupId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $groupId     = OpenApiUtilClient::getEncodeParam($groupId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return AddAttendeeToEventGroupResponse::fromMap($this->doROARequest('AddAttendeeToEventGroup', 'projectIntegration_1.0', 'HTTP', 'POST', 'AK', '/v1.0/projectIntegration/users/' . $userId . '/eventGroups/' . $groupId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return CreateEventGroupResponse
     */
    public function createEventGroup($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventGroupHeaders([]);

        return $this->createEventGroupWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param CreateEventGroupHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateEventGroupResponse
     */
    public function createEventGroupWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return CreateEventGroupResponse::fromMap($this->doROARequest('CreateEventGroup', 'projectIntegration_1.0', 'HTTP', 'POST', 'AK', '/v1.0/projectIntegration/users/' . $userId . '/eventGroups', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return SendInteractiveCardResponse
     */
    public function sendInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveCardHeaders([]);

        return $this->sendInteractiveCardWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param SendInteractiveCardHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return SendInteractiveCardResponse
     */
    public function sendInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return SendInteractiveCardResponse::fromMap($this->doROARequest('SendInteractiveCard', 'projectIntegration_1.0', 'HTTP', 'POST', 'AK', '/v1.0/projectIntegration/users/' . $userId . '/groupChatCardMessages', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return SendSingleInteractiveCardResponse
     */
    public function sendSingleInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendSingleInteractiveCardHeaders([]);

        return $this->sendSingleInteractiveCardWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                           $userId
     * @param SendSingleInteractiveCardHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SendSingleInteractiveCardResponse
     */
    public function sendSingleInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return SendSingleInteractiveCardResponse::fromMap($this->doROARequest('SendSingleInteractiveCard', 'projectIntegration_1.0', 'HTTP', 'POST', 'AK', '/v1.0/projectIntegration/users/' . $userId . '/singleChatCardMessages', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return UpdateInteractiveCardResponse
     */
    public function updateInteractiveCard($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveCardHeaders([]);

        return $this->updateInteractiveCardWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                       $userId
     * @param UpdateInteractiveCardHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateInteractiveCardResponse
     */
    public function updateInteractiveCardWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return UpdateInteractiveCardResponse::fromMap($this->doROARequest('UpdateInteractiveCard', 'projectIntegration_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/projectIntegration/users/' . $userId . '/cardMessages', 'json', $req, $runtime));
    }
}
