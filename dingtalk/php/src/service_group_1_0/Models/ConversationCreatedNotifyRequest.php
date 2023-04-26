<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConversationCreatedNotifyRequest extends Model
{
    /**
     * @var string
     */
    public $alipayUserId;

    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $nickName;

    /**
     * @example eWaJSqDcLsoiE
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @var string
     */
    public $serverName;

    /**
     * @var string
     */
    public $serverTips;

    /**
     * @example 对应外部渠道的会话ID
     *
     * @var string
     */
    public $serviceToken;

    /**
     * @var string
     */
    public $timeoutRemindTips;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $visitorToken;
    protected $_name = [
        'alipayUserId'      => 'alipayUserId',
        'conversationId'    => 'conversationId',
        'nickName'          => 'nickName',
        'openTeamId'        => 'openTeamId',
        'serverName'        => 'serverName',
        'serverTips'        => 'serverTips',
        'serviceToken'      => 'serviceToken',
        'timeoutRemindTips' => 'timeoutRemindTips',
        'userId'            => 'userId',
        'visitorToken'      => 'visitorToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayUserId) {
            $res['alipayUserId'] = $this->alipayUserId;
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->serverName) {
            $res['serverName'] = $this->serverName;
        }
        if (null !== $this->serverTips) {
            $res['serverTips'] = $this->serverTips;
        }
        if (null !== $this->serviceToken) {
            $res['serviceToken'] = $this->serviceToken;
        }
        if (null !== $this->timeoutRemindTips) {
            $res['timeoutRemindTips'] = $this->timeoutRemindTips;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->visitorToken) {
            $res['visitorToken'] = $this->visitorToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConversationCreatedNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayUserId'])) {
            $model->alipayUserId = $map['alipayUserId'];
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['serverName'])) {
            $model->serverName = $map['serverName'];
        }
        if (isset($map['serverTips'])) {
            $model->serverTips = $map['serverTips'];
        }
        if (isset($map['serviceToken'])) {
            $model->serviceToken = $map['serviceToken'];
        }
        if (isset($map['timeoutRemindTips'])) {
            $model->timeoutRemindTips = $map['timeoutRemindTips'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['visitorToken'])) {
            $model->visitorToken = $map['visitorToken'];
        }

        return $model;
    }
}
