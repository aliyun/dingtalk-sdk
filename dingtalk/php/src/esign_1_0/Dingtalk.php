<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\AuthUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\AuthUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\AuthUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CancelCorpAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CancelCorpAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ChannelOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ChannelOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ChannelOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ContractMarginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ContractMarginResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpConsoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpConsoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CreateDeveloperHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CreateDeveloperRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CreateDeveloperResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetCorpRealnameUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetCorpRealnameUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetCorpRealnameUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetCropStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetCropStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowSignDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowSignDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowSignDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetSignNoticeUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetSignNoticeUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetSignNoticeUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUploadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUploadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUploadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserRealnameUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserRealnameUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserRealnameUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListFlowDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListFlowDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListFlowDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListSealApprovalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListSealApprovalRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListSealApprovalResponse;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\OrderResaleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\OrderResaleRequest;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\OrderResaleResponse;
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
     * @param AuthUrlRequest $request
     *
     * @return AuthUrlResponse
     */
    public function authUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AuthUrlHeaders([]);

        return $this->authUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AuthUrlRequest $request
     * @param AuthUrlHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return AuthUrlResponse
     */
    public function authUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            @$body['redirectUrl'] = $request->redirectUrl;
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

        return AuthUrlResponse::fromMap($this->doROARequest('AuthUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/auths/url', 'json', $req, $runtime));
    }

    /**
     * @return CancelCorpAuthResponse
     */
    public function cancelCorpAuth()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelCorpAuthHeaders([]);

        return $this->cancelCorpAuthWithOptions($headers, $runtime);
    }

    /**
     * @param CancelCorpAuthHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CancelCorpAuthResponse
     */
    public function cancelCorpAuthWithOptions($headers, $runtime)
    {
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

        return CancelCorpAuthResponse::fromMap($this->doROARequest('CancelCorpAuth', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/corps/auth/cancel', 'json', $req, $runtime));
    }

    /**
     * @param ChannelOrderRequest $request
     *
     * @return ChannelOrderResponse
     */
    public function channelOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChannelOrderHeaders([]);

        return $this->channelOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ChannelOrderRequest $request
     * @param ChannelOrderHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ChannelOrderResponse
     */
    public function channelOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->itemCode)) {
            @$body['itemCode'] = $request->itemCode;
        }
        if (!Utils::isUnset($request->itemName)) {
            @$body['itemName'] = $request->itemName;
        }
        if (!Utils::isUnset($request->orderCreateTime)) {
            @$body['orderCreateTime'] = $request->orderCreateTime;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->payFee)) {
            @$body['payFee'] = $request->payFee;
        }
        if (!Utils::isUnset($request->quantity)) {
            @$body['quantity'] = $request->quantity;
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

        return ChannelOrderResponse::fromMap($this->doROARequest('ChannelOrder', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/orders/channel', 'json', $req, $runtime));
    }

    /**
     * @return ContractMarginResponse
     */
    public function contractMargin()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ContractMarginHeaders([]);

        return $this->contractMarginWithOptions($headers, $runtime);
    }

    /**
     * @param ContractMarginHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ContractMarginResponse
     */
    public function contractMarginWithOptions($headers, $runtime)
    {
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

        return ContractMarginResponse::fromMap($this->doROARequest('ContractMargin', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/contracts/margin', 'json', $req, $runtime));
    }

    /**
     * @return CorpConsoleResponse
     */
    public function corpConsole()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CorpConsoleHeaders([]);

        return $this->corpConsoleWithOptions($headers, $runtime);
    }

    /**
     * @param CorpConsoleHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CorpConsoleResponse
     */
    public function corpConsoleWithOptions($headers, $runtime)
    {
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

        return CorpConsoleResponse::fromMap($this->doROARequest('CorpConsole', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/corps/console', 'json', $req, $runtime));
    }

    /**
     * @return CorpInfoResponse
     */
    public function corpInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CorpInfoHeaders([]);

        return $this->corpInfoWithOptions($headers, $runtime);
    }

    /**
     * @param CorpInfoHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return CorpInfoResponse
     */
    public function corpInfoWithOptions($headers, $runtime)
    {
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

        return CorpInfoResponse::fromMap($this->doROARequest('CorpInfo', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/corps/info', 'json', $req, $runtime));
    }

    /**
     * @param CreateDeveloperRequest $request
     *
     * @return CreateDeveloperResponse
     */
    public function createDeveloper($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeveloperHeaders([]);

        return $this->createDeveloperWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateDeveloperRequest $request
     * @param CreateDeveloperHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateDeveloperResponse
     */
    public function createDeveloperWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            @$body['redirectUrl'] = $request->redirectUrl;
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

        return CreateDeveloperResponse::fromMap($this->doROARequest('CreateDeveloper', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/developers/create', 'json', $req, $runtime));
    }

    /**
     * @param GetCorpRealnameUrlRequest $request
     *
     * @return GetCorpRealnameUrlResponse
     */
    public function getCorpRealnameUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpRealnameUrlHeaders([]);

        return $this->getCorpRealnameUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCorpRealnameUrlRequest $request
     * @param GetCorpRealnameUrlHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetCorpRealnameUrlResponse
     */
    public function getCorpRealnameUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return GetCorpRealnameUrlResponse::fromMap($this->doROARequest('GetCorpRealnameUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/corps/realname', 'json', $req, $runtime));
    }

    /**
     * @return GetCropStatusResponse
     */
    public function getCropStatus()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCropStatusHeaders([]);

        return $this->getCropStatusWithOptions($headers, $runtime);
    }

    /**
     * @param GetCropStatusHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetCropStatusResponse
     */
    public function getCropStatusWithOptions($headers, $runtime)
    {
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

        return GetCropStatusResponse::fromMap($this->doROARequest('GetCropStatus', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/corps/statuses', 'json', $req, $runtime));
    }

    /**
     * @param string $fileId
     *
     * @return GetFileResponse
     */
    public function getFile($fileId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileHeaders([]);

        return $this->getFileWithOptions($fileId, $headers, $runtime);
    }

    /**
     * @param string         $fileId
     * @param GetFileHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetFileResponse
     */
    public function getFileWithOptions($fileId, $headers, $runtime)
    {
        $fileId      = OpenApiUtilClient::getEncodeParam($fileId);
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

        return GetFileResponse::fromMap($this->doROARequest('GetFile', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/files/' . $fileId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetFlowDetailRequest $request
     *
     * @return GetFlowDetailResponse
     */
    public function getFlowDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowDetailHeaders([]);

        return $this->getFlowDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFlowDetailRequest $request
     * @param GetFlowDetailHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetFlowDetailResponse
     */
    public function getFlowDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFlowDetailResponse::fromMap($this->doROARequest('GetFlowDetail', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/flows/detail', 'json', $req, $runtime));
    }

    /**
     * @param GetFlowSignDetailRequest $request
     *
     * @return GetFlowSignDetailResponse
     */
    public function getFlowSignDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowSignDetailHeaders([]);

        return $this->getFlowSignDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFlowSignDetailRequest $request
     * @param GetFlowSignDetailHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFlowSignDetailResponse
     */
    public function getFlowSignDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFlowSignDetailResponse::fromMap($this->doROARequest('GetFlowSignDetail', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/flows/sign/detail', 'json', $req, $runtime));
    }

    /**
     * @param GetProcessStartUrlRequest $request
     *
     * @return GetProcessStartUrlResponse
     */
    public function getProcessStartUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessStartUrlHeaders([]);

        return $this->getProcessStartUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProcessStartUrlRequest $request
     * @param GetProcessStartUrlHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetProcessStartUrlResponse
     */
    public function getProcessStartUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->ccs)) {
            @$body['ccs'] = $request->ccs;
        }
        if (!Utils::isUnset($request->files)) {
            @$body['files'] = $request->files;
        }
        if (!Utils::isUnset($request->initiatorUserId)) {
            @$body['initiatorUserId'] = $request->initiatorUserId;
        }
        if (!Utils::isUnset($request->participants)) {
            @$body['participants'] = $request->participants;
        }
        if (!Utils::isUnset($request->redirectUrl)) {
            @$body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->sourceInfo)) {
            @$body['sourceInfo'] = $request->sourceInfo;
        }
        if (!Utils::isUnset($request->taskName)) {
            @$body['taskName'] = $request->taskName;
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

        return GetProcessStartUrlResponse::fromMap($this->doROARequest('GetProcessStartUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/process/start', 'json', $req, $runtime));
    }

    /**
     * @param GetSignNoticeUrlRequest $request
     *
     * @return GetSignNoticeUrlResponse
     */
    public function getSignNoticeUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignNoticeUrlHeaders([]);

        return $this->getSignNoticeUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSignNoticeUrlRequest $request
     * @param GetSignNoticeUrlHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetSignNoticeUrlResponse
     */
    public function getSignNoticeUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
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

        return GetSignNoticeUrlResponse::fromMap($this->doROARequest('GetSignNoticeUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/signs/notice/url', 'json', $req, $runtime));
    }

    /**
     * @param GetUploadUrlRequest $request
     *
     * @return GetUploadUrlResponse
     */
    public function getUploadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUploadUrlHeaders([]);

        return $this->getUploadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUploadUrlRequest $request
     * @param GetUploadUrlHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetUploadUrlResponse
     */
    public function getUploadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contentMd5)) {
            @$body['contentMd5'] = $request->contentMd5;
        }
        if (!Utils::isUnset($request->contentType)) {
            @$body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->convert2Pdf)) {
            @$body['convert2Pdf'] = $request->convert2Pdf;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            @$body['fileSize'] = $request->fileSize;
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

        return GetUploadUrlResponse::fromMap($this->doROARequest('GetUploadUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/files/getUploadUrl', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return GetUserInfoResponse
     */
    public function getUserInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserInfoHeaders([]);

        return $this->getUserInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param GetUserInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetUserInfoResponse
     */
    public function getUserInfoWithOptions($userId, $headers, $runtime)
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

        return GetUserInfoResponse::fromMap($this->doROARequest('GetUserInfo', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/users/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetUserRealnameUrlRequest $request
     *
     * @return GetUserRealnameUrlResponse
     */
    public function getUserRealnameUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserRealnameUrlHeaders([]);

        return $this->getUserRealnameUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserRealnameUrlRequest $request
     * @param GetUserRealnameUrlHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetUserRealnameUrlResponse
     */
    public function getUserRealnameUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->redirectUrl)) {
            @$body['redirectUrl'] = $request->redirectUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return GetUserRealnameUrlResponse::fromMap($this->doROARequest('GetUserRealnameUrl', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/users/realname', 'json', $req, $runtime));
    }

    /**
     * @param ListFlowDocsRequest $request
     *
     * @return ListFlowDocsResponse
     */
    public function listFlowDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFlowDocsHeaders([]);

        return $this->listFlowDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListFlowDocsRequest $request
     * @param ListFlowDocsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListFlowDocsResponse
     */
    public function listFlowDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListFlowDocsResponse::fromMap($this->doROARequest('ListFlowDocs', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/flows/docs', 'json', $req, $runtime));
    }

    /**
     * @param ListSealApprovalRequest $request
     *
     * @return ListSealApprovalResponse
     */
    public function listSealApproval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSealApprovalHeaders([]);

        return $this->listSealApprovalWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSealApprovalRequest $request
     * @param ListSealApprovalHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListSealApprovalResponse
     */
    public function listSealApprovalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListSealApprovalResponse::fromMap($this->doROARequest('ListSealApproval', 'esign_1.0', 'HTTP', 'GET', 'AK', '/v1.0/esign/seals/approval/list', 'json', $req, $runtime));
    }

    /**
     * @param OrderResaleRequest $request
     *
     * @return OrderResaleResponse
     */
    public function orderResale($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrderResaleHeaders([]);

        return $this->orderResaleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param OrderResaleRequest $request
     * @param OrderResaleHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return OrderResaleResponse
     */
    public function orderResaleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orderCreateTime)) {
            @$body['orderCreateTime'] = $request->orderCreateTime;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->quantity)) {
            @$body['quantity'] = $request->quantity;
        }
        if (!Utils::isUnset($request->serviceStartTime)) {
            @$body['serviceStartTime'] = $request->serviceStartTime;
        }
        if (!Utils::isUnset($request->serviceStopTime)) {
            @$body['serviceStopTime'] = $request->serviceStopTime;
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

        return OrderResaleResponse::fromMap($this->doROARequest('OrderResale', 'esign_1.0', 'HTTP', 'POST', 'AK', '/v1.0/esign/orders/resale', 'json', $req, $runtime));
    }
}
