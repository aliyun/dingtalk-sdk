<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DeleteMailFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DeleteMailFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DeleteMessagesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DeleteMessagesRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DeleteMessagesResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\GetMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\GetMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\GetMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMessagesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMessagesRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMessagesResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\MoveMailFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\MoveMailFolderRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\MoveMailFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\SendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMailFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMailFolderRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMailFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\UpdateMessageResponse;
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
     * @summary 创建草稿
     *  *
     * @param string               $email
     * @param CreateMessageRequest $request CreateMessageRequest
     * @param CreateMessageHeaders $headers CreateMessageHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMessageResponse CreateMessageResponse
     */
    public function createMessageWithOptions($email, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->message)) {
            $body['message'] = $request->message;
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
            'action' => 'CreateMessage',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/messages',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建草稿
     *  *
     * @param string               $email
     * @param CreateMessageRequest $request CreateMessageRequest
     *
     * @return CreateMessageResponse CreateMessageResponse
     */
    public function createMessage($email, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMessageHeaders([]);

        return $this->createMessageWithOptions($email, $request, $headers, $runtime);
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
     * @summary 删除文件夹
     *  *
     * @param string                  $email
     * @param string                  $id
     * @param DeleteMailFolderHeaders $headers DeleteMailFolderHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMailFolderResponse DeleteMailFolderResponse
     */
    public function deleteMailFolderWithOptions($email, $id, $headers, $runtime)
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
            'action' => 'DeleteMailFolder',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders/' . $id . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMailFolderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除文件夹
     *  *
     * @param string $email
     * @param string $id
     *
     * @return DeleteMailFolderResponse DeleteMailFolderResponse
     */
    public function deleteMailFolder($email, $id)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMailFolderHeaders([]);

        return $this->deleteMailFolderWithOptions($email, $id, $headers, $runtime);
    }

    /**
     * @summary 批量删除邮件
     *  *
     * @param string                $email
     * @param DeleteMessagesRequest $request DeleteMessagesRequest
     * @param DeleteMessagesHeaders $headers DeleteMessagesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMessagesResponse DeleteMessagesResponse
     */
    public function deleteMessagesWithOptions($email, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deleteType)) {
            $body['deleteType'] = $request->deleteType;
        }
        if (!Utils::isUnset($request->ids)) {
            $body['ids'] = $request->ids;
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
            'action' => 'DeleteMessages',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/messages/batchDelete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMessagesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量删除邮件
     *  *
     * @param string                $email
     * @param DeleteMessagesRequest $request DeleteMessagesRequest
     *
     * @return DeleteMessagesResponse DeleteMessagesResponse
     */
    public function deleteMessages($email, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMessagesHeaders([]);

        return $this->deleteMessagesWithOptions($email, $request, $headers, $runtime);
    }

    /**
     * @summary 获取邮件元数据
     *  *
     * @param string            $email
     * @param string            $id
     * @param GetMessageRequest $request GetMessageRequest
     * @param GetMessageHeaders $headers GetMessageHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMessageResponse GetMessageResponse
     */
    public function getMessageWithOptions($email, $id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->selectFields)) {
            $query['selectFields'] = $request->selectFields;
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
            'action' => 'GetMessage',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/messages/' . $id . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取邮件元数据
     *  *
     * @param string            $email
     * @param string            $id
     * @param GetMessageRequest $request GetMessageRequest
     *
     * @return GetMessageResponse GetMessageResponse
     */
    public function getMessage($email, $id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMessageHeaders([]);

        return $this->getMessageWithOptions($email, $id, $request, $headers, $runtime);
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

    /**
     * @summary 获取邮件列表
     *  *
     * @param string              $email
     * @param string              $folderId
     * @param ListMessagesRequest $request  ListMessagesRequest
     * @param ListMessagesHeaders $headers  ListMessagesHeaders
     * @param RuntimeOptions      $runtime  runtime options for this request RuntimeOptions
     *
     * @return ListMessagesResponse ListMessagesResponse
     */
    public function listMessagesWithOptions($email, $folderId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->selectFields)) {
            $query['selectFields'] = $request->selectFields;
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
            'action' => 'ListMessages',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders/' . $folderId . '/messages',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListMessagesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取邮件列表
     *  *
     * @param string              $email
     * @param string              $folderId
     * @param ListMessagesRequest $request  ListMessagesRequest
     *
     * @return ListMessagesResponse ListMessagesResponse
     */
    public function listMessages($email, $folderId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMessagesHeaders([]);

        return $this->listMessagesWithOptions($email, $folderId, $request, $headers, $runtime);
    }

    /**
     * @summary 移动文件夹
     *  *
     * @param string                $email
     * @param string                $id
     * @param MoveMailFolderRequest $request MoveMailFolderRequest
     * @param MoveMailFolderHeaders $headers MoveMailFolderHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return MoveMailFolderResponse MoveMailFolderResponse
     */
    public function moveMailFolderWithOptions($email, $id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->destinationFolderId)) {
            $body['destinationFolderId'] = $request->destinationFolderId;
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
            'action' => 'MoveMailFolder',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders/' . $id . '/move',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return MoveMailFolderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移动文件夹
     *  *
     * @param string                $email
     * @param string                $id
     * @param MoveMailFolderRequest $request MoveMailFolderRequest
     *
     * @return MoveMailFolderResponse MoveMailFolderResponse
     */
    public function moveMailFolder($email, $id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveMailFolderHeaders([]);

        return $this->moveMailFolderWithOptions($email, $id, $request, $headers, $runtime);
    }

    /**
     * @summary 发送邮件
     *  *
     * @param string             $email
     * @param string             $id
     * @param SendMessageRequest $request SendMessageRequest
     * @param SendMessageHeaders $headers SendMessageHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMessageResponse SendMessageResponse
     */
    public function sendMessageWithOptions($email, $id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->saveToSentItems)) {
            $body['saveToSentItems'] = $request->saveToSentItems;
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
            'action' => 'SendMessage',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/messages/' . $id . '/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送邮件
     *  *
     * @param string             $email
     * @param string             $id
     * @param SendMessageRequest $request SendMessageRequest
     *
     * @return SendMessageResponse SendMessageResponse
     */
    public function sendMessage($email, $id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageHeaders([]);

        return $this->sendMessageWithOptions($email, $id, $request, $headers, $runtime);
    }

    /**
     * @summary 修改文件夹信息
     *  *
     * @param string                  $email
     * @param string                  $id
     * @param UpdateMailFolderRequest $request UpdateMailFolderRequest
     * @param UpdateMailFolderHeaders $headers UpdateMailFolderHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMailFolderResponse UpdateMailFolderResponse
     */
    public function updateMailFolderWithOptions($email, $id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->displayName)) {
            $body['displayName'] = $request->displayName;
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
            'action' => 'UpdateMailFolder',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/mailFolders/' . $id . '/update',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMailFolderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改文件夹信息
     *  *
     * @param string                  $email
     * @param string                  $id
     * @param UpdateMailFolderRequest $request UpdateMailFolderRequest
     *
     * @return UpdateMailFolderResponse UpdateMailFolderResponse
     */
    public function updateMailFolder($email, $id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMailFolderHeaders([]);

        return $this->updateMailFolderWithOptions($email, $id, $request, $headers, $runtime);
    }

    /**
     * @summary 修改草稿
     *  *
     * @param string               $email
     * @param string               $id
     * @param UpdateMessageRequest $request UpdateMessageRequest
     * @param UpdateMessageHeaders $headers UpdateMessageHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMessageResponse UpdateMessageResponse
     */
    public function updateMessageWithOptions($email, $id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->message)) {
            $body['message'] = $request->message;
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
            'action' => 'UpdateMessage',
            'version' => 'mail_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mail/users/' . $email . '/messages/' . $id . '/update',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改草稿
     *  *
     * @param string               $email
     * @param string               $id
     * @param UpdateMessageRequest $request UpdateMessageRequest
     *
     * @return UpdateMessageResponse UpdateMessageResponse
     */
    public function updateMessage($email, $id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMessageHeaders([]);

        return $this->updateMessageWithOptions($email, $id, $request, $headers, $runtime);
    }
}
