<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalCreateProgressHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalCreateProgressRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalCreateProgressResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveKeyActionListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveKeyActionListRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveKeyActionListResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveRulePeriodListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveRulePeriodListRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalObjectiveRulePeriodListResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalOrgObjectiveRuleListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalOrgObjectiveRuleListResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalSendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalSendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalSendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserAdminListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserAdminListResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserObjectiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserObjectiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserObjectiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserSubAdminListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserSubAdminListRequest;
use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalUserSubAdminListResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建目标进展
     *  *
     * @param AgoalCreateProgressRequest $request AgoalCreateProgressRequest
     * @param AgoalCreateProgressHeaders $headers AgoalCreateProgressHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalCreateProgressResponse AgoalCreateProgressResponse
     */
    public function agoalCreateProgressWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->krId)) {
            $body['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->mergeIntoLatestProgress)) {
            $body['mergeIntoLatestProgress'] = $request->mergeIntoLatestProgress;
        }
        if (!Utils::isUnset($request->objectiveId)) {
            $body['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->plainText)) {
            $body['plainText'] = $request->plainText;
        }
        if (!Utils::isUnset($request->progress)) {
            $body['progress'] = $request->progress;
        }
        if (!Utils::isUnset($request->progressMergePeriod)) {
            $body['progressMergePeriod'] = $request->progressMergePeriod;
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
            'action'      => 'AgoalCreateProgress',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/objectives/progresses',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalCreateProgressResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建目标进展
     *  *
     * @param AgoalCreateProgressRequest $request AgoalCreateProgressRequest
     *
     * @return AgoalCreateProgressResponse AgoalCreateProgressResponse
     */
    public function agoalCreateProgress($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalCreateProgressHeaders([]);

        return $this->agoalCreateProgressWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Agoal指定目标或者关键结果关联的关键行动
     *  *
     * @param AgoalObjectiveKeyActionListRequest $request AgoalObjectiveKeyActionListRequest
     * @param AgoalObjectiveKeyActionListHeaders $headers AgoalObjectiveKeyActionListHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionListResponse
     */
    public function agoalObjectiveKeyActionListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingUserId)) {
            $query['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->keyResultId)) {
            $query['keyResultId'] = $request->keyResultId;
        }
        if (!Utils::isUnset($request->objectiveId)) {
            $query['objectiveId'] = $request->objectiveId;
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
            'action'      => 'AgoalObjectiveKeyActionList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/objectives/keyActionLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalObjectiveKeyActionListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Agoal指定目标或者关键结果关联的关键行动
     *  *
     * @param AgoalObjectiveKeyActionListRequest $request AgoalObjectiveKeyActionListRequest
     *
     * @return AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionListResponse
     */
    public function agoalObjectiveKeyActionList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalObjectiveKeyActionListHeaders([]);

        return $this->agoalObjectiveKeyActionListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Agoal目标规则下的周期列表
     *  *
     * @param AgoalObjectiveRulePeriodListRequest $request AgoalObjectiveRulePeriodListRequest
     * @param AgoalObjectiveRulePeriodListHeaders $headers AgoalObjectiveRulePeriodListHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodListResponse
     */
    public function agoalObjectiveRulePeriodListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->objectiveRuleId)) {
            $query['objectiveRuleId'] = $request->objectiveRuleId;
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
            'action'      => 'AgoalObjectiveRulePeriodList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/objectiveRules/periodLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalObjectiveRulePeriodListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Agoal目标规则下的周期列表
     *  *
     * @param AgoalObjectiveRulePeriodListRequest $request AgoalObjectiveRulePeriodListRequest
     *
     * @return AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodListResponse
     */
    public function agoalObjectiveRulePeriodList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalObjectiveRulePeriodListHeaders([]);

        return $this->agoalObjectiveRulePeriodListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Agoal目标规则列表
     *  *
     * @param AgoalOrgObjectiveRuleListHeaders $headers AgoalOrgObjectiveRuleListHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleListResponse
     */
    public function agoalOrgObjectiveRuleListWithOptions($headers, $runtime)
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
            'action'      => 'AgoalOrgObjectiveRuleList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/objectiveRules/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalOrgObjectiveRuleListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Agoal目标规则列表
     *  *
     * @return AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleListResponse
     */
    public function agoalOrgObjectiveRuleList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalOrgObjectiveRuleListHeaders([]);

        return $this->agoalOrgObjectiveRuleListWithOptions($headers, $runtime);
    }

    /**
     * @summary Agoal消息发送
     *  *
     * @param AgoalSendMessageRequest $request AgoalSendMessageRequest
     * @param AgoalSendMessageHeaders $headers AgoalSendMessageHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalSendMessageResponse AgoalSendMessageResponse
     */
    public function agoalSendMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mobileUrl)) {
            $body['mobileUrl'] = $request->mobileUrl;
        }
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
        }
        if (!Utils::isUnset($request->pcUrl)) {
            $body['pcUrl'] = $request->pcUrl;
        }
        if (!Utils::isUnset($request->sourceDingUserId)) {
            $body['sourceDingUserId'] = $request->sourceDingUserId;
        }
        if (!Utils::isUnset($request->targetDingUserIds)) {
            $body['targetDingUserIds'] = $request->targetDingUserIds;
        }
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
            'action'      => 'AgoalSendMessage',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalSendMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Agoal消息发送
     *  *
     * @param AgoalSendMessageRequest $request AgoalSendMessageRequest
     *
     * @return AgoalSendMessageResponse AgoalSendMessageResponse
     */
    public function agoalSendMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalSendMessageHeaders([]);

        return $this->agoalSendMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Agoal管理员列表
     *  *
     * @param AgoalUserAdminListHeaders $headers AgoalUserAdminListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalUserAdminListResponse AgoalUserAdminListResponse
     */
    public function agoalUserAdminListWithOptions($headers, $runtime)
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
            'action'      => 'AgoalUserAdminList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/administrators/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalUserAdminListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Agoal管理员列表
     *  *
     * @return AgoalUserAdminListResponse AgoalUserAdminListResponse
     */
    public function agoalUserAdminList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalUserAdminListHeaders([]);

        return $this->agoalUserAdminListWithOptions($headers, $runtime);
    }

    /**
     * @summary Agoal用户目标列表
     *  *
     * @param AgoalUserObjectiveListRequest $request AgoalUserObjectiveListRequest
     * @param AgoalUserObjectiveListHeaders $headers AgoalUserObjectiveListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalUserObjectiveListResponse AgoalUserObjectiveListResponse
     */
    public function agoalUserObjectiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingUserId)) {
            $body['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->objectiveRuleId)) {
            $body['objectiveRuleId'] = $request->objectiveRuleId;
        }
        if (!Utils::isUnset($request->periodIds)) {
            $body['periodIds'] = $request->periodIds;
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
            'action'      => 'AgoalUserObjectiveList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/users/objectiveLists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalUserObjectiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Agoal用户目标列表
     *  *
     * @param AgoalUserObjectiveListRequest $request AgoalUserObjectiveListRequest
     *
     * @return AgoalUserObjectiveListResponse AgoalUserObjectiveListResponse
     */
    public function agoalUserObjectiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalUserObjectiveListHeaders([]);

        return $this->agoalUserObjectiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Agoal子管理员列表
     *  *
     * @param AgoalUserSubAdminListRequest $request AgoalUserSubAdminListRequest
     * @param AgoalUserSubAdminListHeaders $headers AgoalUserSubAdminListHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return AgoalUserSubAdminListResponse AgoalUserSubAdminListResponse
     */
    public function agoalUserSubAdminListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->funcPermissionGroup)) {
            $query['funcPermissionGroup'] = $request->funcPermissionGroup;
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
            'action'      => 'AgoalUserSubAdminList',
            'version'     => 'agoal_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/agoal/administrators/sub/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AgoalUserSubAdminListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Agoal子管理员列表
     *  *
     * @param AgoalUserSubAdminListRequest $request AgoalUserSubAdminListRequest
     *
     * @return AgoalUserSubAdminListResponse AgoalUserSubAdminListResponse
     */
    public function agoalUserSubAdminList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AgoalUserSubAdminListHeaders([]);

        return $this->agoalUserSubAdminListWithOptions($request, $headers, $runtime);
    }
}
