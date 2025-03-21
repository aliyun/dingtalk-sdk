<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersResponse;
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
     * @summary 创建邮件文件夹
     *  *
     * @param string                  $email
     * @param CreateMailFolderRequest $request CreateMailFolderRequest
     * @param CreateMailFolderHeaders $headers CreateMailFolderHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMailFolderResponse CreateMailFolderResponse
     */
    public function createMailFolderWithOptions($email, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->displayName)) {
            $body['displayName'] = $request->displayName;
        }
        if (!Utils::isUnset($request->extensions)) {
            $body['extensions'] = $request->extensions;
        }
        if (!Utils::isUnset($request->folerId)) {
            $body['folerId'] = $request->folerId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateMailFolder',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMailFolderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建邮件文件夹
     *  *
     * @param string                  $email
     * @param CreateMailFolderRequest $request CreateMailFolderRequest
     *
     * @return CreateMailFolderResponse CreateMailFolderResponse
     */
    public function createMailFolder($email, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMailFolderHeaders([]);

        return $this->createMailFolderWithOptions($email, $request, $headers, $runtime);
    }

    /**
     * @summary 创建企业邮箱用户
     *  *
     * @param CreateUserRequest $request CreateUserRequest
     * @param CreateUserHeaders $headers CreateUserHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateUserResponse CreateUserResponse
     */
    public function createUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->employeeType)) {
            $body['employeeType'] = $request->employeeType;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->password)) {
            $body['password'] = $request->password;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateUser',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建企业邮箱用户
     *  *
     * @param CreateUserRequest $request CreateUserRequest
     *
     * @return CreateUserResponse CreateUserResponse
     */
    public function createUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUserHeaders([]);

        return $this->createUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取指定文件夹的子文件夹列表
     *  *
     * @param string                 $email
     * @param ListMailFoldersRequest $request ListMailFoldersRequest
     * @param ListMailFoldersHeaders $headers ListMailFoldersHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMailFoldersResponse ListMailFoldersResponse
     */
    public function listMailFoldersWithOptions($email, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->folderId)) {
            $query['folderId'] = $request->folderId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListMailFolders',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListMailFoldersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定文件夹的子文件夹列表
     *  *
     * @param string                 $email
     * @param ListMailFoldersRequest $request ListMailFoldersRequest
     *
     * @return ListMailFoldersResponse ListMailFoldersResponse
     */
    public function listMailFolders($email, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMailFoldersHeaders([]);

        return $this->listMailFoldersWithOptions($email, $request, $headers, $runtime);
    }
}
