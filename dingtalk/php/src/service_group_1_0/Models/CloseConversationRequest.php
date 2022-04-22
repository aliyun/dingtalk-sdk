<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseConversationRequest extends Model
{
    /**
     * @description DT端会话ID
     *
     * @var string
     */
    public $conversationId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 客户信息
     *
     * @var string
     */
    public $serverTips;

    /**
     * @description 对应外部渠道的会话ID
     *
     * @var string
     */
    public $serviceToken;

    /**
     * @description 渠道类型
     *
     * @var string
     */
    public $targetChannel;

    /**
     * @description DT端定义的
     *
     * @var string
     */
    public $visitorToken;
    protected $_name = [
        'conversationId' => 'conversationId',
        'openTeamId'     => 'openTeamId',
        'serverTips'     => 'serverTips',
        'serviceToken'   => 'serviceToken',
        'targetChannel'  => 'targetChannel',
        'visitorToken'   => 'visitorToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->serverTips) {
            $res['serverTips'] = $this->serverTips;
        }
        if (null !== $this->serviceToken) {
            $res['serviceToken'] = $this->serviceToken;
        }
        if (null !== $this->targetChannel) {
            $res['targetChannel'] = $this->targetChannel;
        }
        if (null !== $this->visitorToken) {
            $res['visitorToken'] = $this->visitorToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['serverTips'])) {
            $model->serverTips = $map['serverTips'];
        }
        if (isset($map['serviceToken'])) {
            $model->serviceToken = $map['serviceToken'];
        }
        if (isset($map['targetChannel'])) {
            $model->targetChannel = $map['targetChannel'];
        }
        if (isset($map['visitorToken'])) {
            $model->visitorToken = $map['visitorToken'];
        }

        return $model;
    }
}
