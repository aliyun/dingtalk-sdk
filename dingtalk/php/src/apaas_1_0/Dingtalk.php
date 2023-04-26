<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateResponse;
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
     * @param BatchCreateTemplateRequest $request
     * @param BatchCreateTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchCreateTemplateResponse
     */
    public function batchCreateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            $body['templateList'] = $request->templateList;
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
            'action'      => 'BatchCreateTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchCreateTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchCreateTemplateRequest $request
     *
     * @return BatchCreateTemplateResponse
     */
    public function batchCreateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateTemplateHeaders([]);

        return $this->batchCreateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchQueryByTemplateKeyRequest $request
     * @param BatchQueryByTemplateKeyHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            $body['templateKeys'] = $request->templateKeys;
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
            'action'      => 'BatchQueryByTemplateKey',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryByTemplateKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchQueryByTemplateKeyRequest $request
     *
     * @return BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryByTemplateKeyHeaders([]);

        return $this->batchQueryByTemplateKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateTemplateRequest $request
     * @param BatchUpdateTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            $body['templateList'] = $request->templateList;
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
            'action'      => 'BatchUpdateTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchUpdateTemplateRequest $request
     *
     * @return BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateTemplateHeaders([]);

        return $this->batchUpdateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryIndustryTagListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryIndustryTagListResponse
     */
    public function queryIndustryTagListWithOptions($headers, $runtime)
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
            'action'      => 'QueryIndustryTagList',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/industries',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryIndustryTagListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return QueryIndustryTagListResponse
     */
    public function queryIndustryTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryIndustryTagListHeaders([]);

        return $this->queryIndustryTagListWithOptions($headers, $runtime);
    }

    /**
     * @param QueryRoleTagListHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryRoleTagListResponse
     */
    public function queryRoleTagListWithOptions($headers, $runtime)
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
            'action'      => 'QueryRoleTagList',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRoleTagListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return QueryRoleTagListResponse
     */
    public function queryRoleTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRoleTagListHeaders([]);

        return $this->queryRoleTagListWithOptions($headers, $runtime);
    }

    /**
     * @param QueryTemplateCategorysHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorysWithOptions($headers, $runtime)
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
            'action'      => 'QueryTemplateCategorys',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/categories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTemplateCategorysResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorys()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTemplateCategorysHeaders([]);

        return $this->queryTemplateCategorysWithOptions($headers, $runtime);
    }

    /**
     * @param RecallAuditTemplateRequest $request
     * @param RecallAuditTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RecallAuditTemplateResponse
     */
    public function recallAuditTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            $body['templateKeys'] = $request->templateKeys;
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
            'action'      => 'RecallAuditTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/audits/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RecallAuditTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RecallAuditTemplateRequest $request
     *
     * @return RecallAuditTemplateResponse
     */
    public function recallAuditTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallAuditTemplateHeaders([]);

        return $this->recallAuditTemplateWithOptions($request, $headers, $runtime);
    }
}
