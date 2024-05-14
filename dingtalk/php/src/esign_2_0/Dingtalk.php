<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CancelCorpAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CancelCorpAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CancelCorpAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ChannelOrdersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ChannelOrdersRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ChannelOrdersResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CorpRealnameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CorpRealnameRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CorpRealnameResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateDevelopersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateDevelopersRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateDevelopersResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAttachsApprovalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAttachsApprovalResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAuthUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAuthUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAuthUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetContractMarginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetContractMarginResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetCorpConsoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetCorpConsoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetCorpInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetCorpInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetExecuteUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetExecuteUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetExecuteUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFileInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFileUploadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFileUploadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFileUploadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetIsvStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetIsvStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetSignDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetSignDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ResaleOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ResaleOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ResaleOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\UsersRealnameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\UsersRealnameRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\UsersRealnameResponse;
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
     * @summary 获取流程任务用印审批列表
     *  *
     * @param string              $taskId
     * @param ApprovalListHeaders $headers ApprovalListHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ApprovalListResponse ApprovalListResponse
     */
    public function approvalListWithOptions($taskId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ApprovalList',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/approvals/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ApprovalListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程任务用印审批列表
     *  *
     * @param string $taskId
     *
     * @return ApprovalListResponse ApprovalListResponse
     */
    public function approvalList($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApprovalListHeaders([]);

        return $this->approvalListWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 取消企业的授权
     *  *
     * @param CancelCorpAuthRequest $request CancelCorpAuthRequest
     * @param CancelCorpAuthHeaders $headers CancelCorpAuthHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelCorpAuthResponse CancelCorpAuthResponse
     */
    public function cancelCorpAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'CancelCorpAuth',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/auths/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CancelCorpAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消企业的授权
     *  *
     * @param CancelCorpAuthRequest $request CancelCorpAuthRequest
     *
     * @return CancelCorpAuthResponse CancelCorpAuthResponse
     */
    public function cancelCorpAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelCorpAuthHeaders([]);

        return $this->cancelCorpAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套餐转售1（分润模式）
     *  *
     * @param ChannelOrdersRequest $request ChannelOrdersRequest
     * @param ChannelOrdersHeaders $headers ChannelOrdersHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ChannelOrdersResponse ChannelOrdersResponse
     */
    public function channelOrdersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->itemCode)) {
            $body['itemCode'] = $request->itemCode;
        }
        if (!Utils::isUnset($request->itemName)) {
            $body['itemName'] = $request->itemName;
        }
        if (!Utils::isUnset($request->orderCreateTime)) {
            $body['orderCreateTime'] = $request->orderCreateTime;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->payFee)) {
            $body['payFee'] = $request->payFee;
        }
        if (!Utils::isUnset($request->quantity)) {
            $body['quantity'] = $request->quantity;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ChannelOrders',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/orders/channel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ChannelOrdersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套餐转售1（分润模式）
     *  *
     * @param ChannelOrdersRequest $request ChannelOrdersRequest
     *
     * @return ChannelOrdersResponse ChannelOrdersResponse
     */
    public function channelOrders($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChannelOrdersHeaders([]);

        return $this->channelOrdersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生成企业实名的跳转地址
     *  *
     * @param CorpRealnameRequest $request CorpRealnameRequest
     * @param CorpRealnameHeaders $headers CorpRealnameHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CorpRealnameResponse CorpRealnameResponse
     */
    public function corpRealnameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            $body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CorpRealname',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/corps/realnames',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CorpRealnameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成企业实名的跳转地址
     *  *
     * @param CorpRealnameRequest $request CorpRealnameRequest
     *
     * @return CorpRealnameResponse CorpRealnameResponse
     */
    public function corpRealname($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CorpRealnameHeaders([]);

        return $this->corpRealnameWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉ISV服务商数据初始化
     *  *
     * @param CreateDevelopersRequest $request CreateDevelopersRequest
     * @param CreateDevelopersHeaders $headers CreateDevelopersHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDevelopersResponse CreateDevelopersResponse
     */
    public function createDevelopersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->noticeUrl)) {
            $body['noticeUrl'] = $request->noticeUrl;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateDevelopers',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/developers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateDevelopersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉ISV服务商数据初始化
     *  *
     * @param CreateDevelopersRequest $request CreateDevelopersRequest
     *
     * @return CreateDevelopersResponse CreateDevelopersResponse
     */
    public function createDevelopers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDevelopersHeaders([]);

        return $this->createDevelopersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过API发起签署流程
     *  *
     * @param CreateProcessRequest $request CreateProcessRequest
     * @param CreateProcessHeaders $headers CreateProcessHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateProcessResponse CreateProcessResponse
     */
    public function createProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->ccs)) {
            $body['ccs'] = $request->ccs;
        }
        if (!Utils::isUnset($request->files)) {
            $body['files'] = $request->files;
        }
        if (!Utils::isUnset($request->initiatorUserId)) {
            $body['initiatorUserId'] = $request->initiatorUserId;
        }
        if (!Utils::isUnset($request->participants)) {
            $body['participants'] = $request->participants;
        }
        if (!Utils::isUnset($request->redirectUrl)) {
            $body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->signEndTime)) {
            $body['signEndTime'] = $request->signEndTime;
        }
        if (!Utils::isUnset($request->sourceInfo)) {
            $body['sourceInfo'] = $request->sourceInfo;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action'      => 'CreateProcess',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/process/startAtOnce',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过API发起签署流程
     *  *
     * @param CreateProcessRequest $request CreateProcessRequest
     *
     * @return CreateProcessResponse CreateProcessResponse
     */
    public function createProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProcessHeaders([]);

        return $this->createProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取钉钉审批实例-电子附件信息
     *  *
     * @param string                    $instanceId
     * @param GetAttachsApprovalHeaders $headers    GetAttachsApprovalHeaders
     * @param RuntimeOptions            $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetAttachsApprovalResponse GetAttachsApprovalResponse
     */
    public function getAttachsApprovalWithOptions($instanceId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->tsignOpenAppId)) {
            $realHeaders['tsignOpenAppId'] = Utils::toJSONString($headers->tsignOpenAppId);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetAttachsApproval',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/dingInstances/' . $instanceId . '/attachments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetAttachsApprovalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取钉钉审批实例-电子附件信息
     *  *
     * @param string $instanceId
     *
     * @return GetAttachsApprovalResponse GetAttachsApprovalResponse
     */
    public function getAttachsApproval($instanceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAttachsApprovalHeaders([]);

        return $this->getAttachsApprovalWithOptions($instanceId, $headers, $runtime);
    }

    /**
     * @summary 生成授权页面地址
     *  *
     * @param GetAuthUrlRequest $request GetAuthUrlRequest
     * @param GetAuthUrlHeaders $headers GetAuthUrlHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAuthUrlResponse GetAuthUrlResponse
     */
    public function getAuthUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            $body['redirectUrl'] = $request->redirectUrl;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetAuthUrl',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/auths/urls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetAuthUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成授权页面地址
     *  *
     * @param GetAuthUrlRequest $request GetAuthUrlRequest
     *
     * @return GetAuthUrlResponse GetAuthUrlResponse
     */
    public function getAuthUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAuthUrlHeaders([]);

        return $this->getAuthUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询套餐余量
     *  *
     * @param GetContractMarginHeaders $headers GetContractMarginHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetContractMarginResponse GetContractMarginResponse
     */
    public function getContractMarginWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetContractMargin',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/margins',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetContractMarginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询套餐余量
     *  *
     * @return GetContractMarginResponse GetContractMarginResponse
     */
    public function getContractMargin()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetContractMarginHeaders([]);

        return $this->getContractMarginWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业控制台地址
     *  *
     * @param GetCorpConsoleHeaders $headers GetCorpConsoleHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpConsoleResponse GetCorpConsoleResponse
     */
    public function getCorpConsoleWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetCorpConsole',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/corps/consoles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetCorpConsoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业控制台地址
     *  *
     * @return GetCorpConsoleResponse GetCorpConsoleResponse
     */
    public function getCorpConsole()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpConsoleHeaders([]);

        return $this->getCorpConsoleWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询企业信息
     *  *
     * @param GetCorpInfoHeaders $headers GetCorpInfoHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpInfoResponse GetCorpInfoResponse
     */
    public function getCorpInfoWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetCorpInfo',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/corps/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetCorpInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业信息
     *  *
     * @return GetCorpInfoResponse GetCorpInfoResponse
     */
    public function getCorpInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpInfoHeaders([]);

        return $this->getCorpInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取签署人签署地址
     *  *
     * @param GetExecuteUrlRequest $request GetExecuteUrlRequest
     * @param GetExecuteUrlHeaders $headers GetExecuteUrlHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetExecuteUrlResponse GetExecuteUrlResponse
     */
    public function getExecuteUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->account)) {
            $body['account'] = $request->account;
        }
        if (!Utils::isUnset($request->signContainer)) {
            $body['signContainer'] = $request->signContainer;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetExecuteUrl',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/process/executeUrls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetExecuteUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签署人签署地址
     *  *
     * @param GetExecuteUrlRequest $request GetExecuteUrlRequest
     *
     * @return GetExecuteUrlResponse GetExecuteUrlResponse
     */
    public function getExecuteUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetExecuteUrlHeaders([]);

        return $this->getExecuteUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取文件详情
     *  *
     * @param string             $fileId
     * @param GetFileInfoHeaders $headers GetFileInfoHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFileInfoResponse GetFileInfoResponse
     */
    public function getFileInfoWithOptions($fileId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetFileInfo',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/files/' . $fileId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFileInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件详情
     *  *
     * @param string $fileId
     *
     * @return GetFileInfoResponse GetFileInfoResponse
     */
    public function getFileInfo($fileId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileInfoHeaders([]);

        return $this->getFileInfoWithOptions($fileId, $headers, $runtime);
    }

    /**
     * @summary 获取文件上传地址
     *  *
     * @param GetFileUploadUrlRequest $request GetFileUploadUrlRequest
     * @param GetFileUploadUrlHeaders $headers GetFileUploadUrlHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFileUploadUrlResponse GetFileUploadUrlResponse
     */
    public function getFileUploadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contentMd5)) {
            $body['contentMd5'] = $request->contentMd5;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->convert2Pdf)) {
            $body['convert2Pdf'] = $request->convert2Pdf;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetFileUploadUrl',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/files/uploadUrls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFileUploadUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件上传地址
     *  *
     * @param GetFileUploadUrlRequest $request GetFileUploadUrlRequest
     *
     * @return GetFileUploadUrlResponse GetFileUploadUrlResponse
     */
    public function getFileUploadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadUrlHeaders([]);

        return $this->getFileUploadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取流程详细信息及操作记录
     *  *
     * @param string               $taskId
     * @param GetFlowDetailHeaders $headers GetFlowDetailHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFlowDetailResponse GetFlowDetailResponse
     */
    public function getFlowDetailWithOptions($taskId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetFlowDetail',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/flowTasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFlowDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程详细信息及操作记录
     *  *
     * @param string $taskId
     *
     * @return GetFlowDetailResponse GetFlowDetailResponse
     */
    public function getFlowDetail($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowDetailHeaders([]);

        return $this->getFlowDetailWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
     *  *
     * @param string             $taskId
     * @param GetFlowDocsHeaders $headers GetFlowDocsHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFlowDocsResponse GetFlowDocsResponse
     */
    public function getFlowDocsWithOptions($taskId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetFlowDocs',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/flowTasks/' . $taskId . '/docs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFlowDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
     *  *
     * @param string $taskId
     *
     * @return GetFlowDocsResponse GetFlowDocsResponse
     */
    public function getFlowDocs($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowDocsHeaders([]);

        return $this->getFlowDocsWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 获取企业的e签宝微应用当前状态
     *  *
     * @param GetIsvStatusHeaders $headers GetIsvStatusHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetIsvStatusResponse GetIsvStatusResponse
     */
    public function getIsvStatusWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetIsvStatus',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/corps/appStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetIsvStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业的e签宝微应用当前状态
     *  *
     * @return GetIsvStatusResponse GetIsvStatusResponse
     */
    public function getIsvStatus()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIsvStatusHeaders([]);

        return $this->getIsvStatusWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取流程签署的详细信息
     *  *
     * @param string               $taskId
     * @param GetSignDetailHeaders $headers GetSignDetailHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSignDetailResponse GetSignDetailResponse
     */
    public function getSignDetailWithOptions($taskId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetSignDetail',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/signTasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetSignDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程签署的详细信息
     *  *
     * @param string $taskId
     *
     * @return GetSignDetailResponse GetSignDetailResponse
     */
    public function getSignDetail($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignDetailHeaders([]);

        return $this->getSignDetailWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 查询个人信息
     *  *
     * @param string             $userId
     * @param GetUserInfoHeaders $headers GetUserInfoHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserInfoResponse GetUserInfoResponse
     */
    public function getUserInfoWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetUserInfo',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/users/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询个人信息
     *  *
     * @param string $userId
     *
     * @return GetUserInfoResponse GetUserInfoResponse
     */
    public function getUserInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserInfoHeaders([]);

        return $this->getUserInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取发起签署任务的地址
     *  *
     * @param ProcessStartRequest $request ProcessStartRequest
     * @param ProcessStartHeaders $headers ProcessStartHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ProcessStartResponse ProcessStartResponse
     */
    public function processStartWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->autoStart)) {
            $body['autoStart'] = $request->autoStart;
        }
        if (!Utils::isUnset($request->ccs)) {
            $body['ccs'] = $request->ccs;
        }
        if (!Utils::isUnset($request->files)) {
            $body['files'] = $request->files;
        }
        if (!Utils::isUnset($request->initiatorUserId)) {
            $body['initiatorUserId'] = $request->initiatorUserId;
        }
        if (!Utils::isUnset($request->participants)) {
            $body['participants'] = $request->participants;
        }
        if (!Utils::isUnset($request->redirectUrl)) {
            $body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->sourceInfo)) {
            $body['sourceInfo'] = $request->sourceInfo;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ProcessStart',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/processes/startUrls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ProcessStartResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取发起签署任务的地址
     *  *
     * @param ProcessStartRequest $request ProcessStartRequest
     *
     * @return ProcessStartResponse ProcessStartResponse
     */
    public function processStart($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessStartHeaders([]);

        return $this->processStartWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *  *
     * @param ResaleOrderRequest $request ResaleOrderRequest
     * @param ResaleOrderHeaders $headers ResaleOrderHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ResaleOrderResponse ResaleOrderResponse
     */
    public function resaleOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orderCreateTime)) {
            $body['orderCreateTime'] = $request->orderCreateTime;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->quantity)) {
            $body['quantity'] = $request->quantity;
        }
        if (!Utils::isUnset($request->serviceStartTime)) {
            $body['serviceStartTime'] = $request->serviceStartTime;
        }
        if (!Utils::isUnset($request->serviceStopTime)) {
            $body['serviceStopTime'] = $request->serviceStopTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ResaleOrder',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/orders/resale',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ResaleOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套餐转售2（底价结算模式）
     *  *
     * @param ResaleOrderRequest $request ResaleOrderRequest
     *
     * @return ResaleOrderResponse ResaleOrderResponse
     */
    public function resaleOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ResaleOrderHeaders([]);

        return $this->resaleOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *  *
     * @param UsersRealnameRequest $request UsersRealnameRequest
     * @param UsersRealnameHeaders $headers UsersRealnameHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UsersRealnameResponse UsersRealnameResponse
     */
    public function usersRealnameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            $body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->serviceGroup)) {
            $realHeaders['serviceGroup'] = Utils::toJSONString($headers->serviceGroup);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UsersRealname',
            'version'     => 'esign_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/esign/users/realnames',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UsersRealnameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取跳转到个人实名的地址
     *  *
     * @param UsersRealnameRequest $request UsersRealnameRequest
     *
     * @return UsersRealnameResponse UsersRealnameResponse
     */
    public function usersRealname($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UsersRealnameHeaders([]);

        return $this->usersRealnameWithOptions($request, $headers, $runtime);
    }
}
