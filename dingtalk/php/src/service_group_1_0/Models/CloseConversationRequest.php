<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseConversationRequest extends Model
{
    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $openTeamId;

    /**
     * @var string
     */
    public $serverTips;

    /**
     * @var string
     */
    public $serviceToken;

    /**
     * @var string
     */
    public $targetChannel;

    /**
     * @var string
     */
    public $visitorToken;
    protected $_name = [
        'conversationId' => 'conversationId',
        'openTeamId' => 'openTeamId',
        'serverTips' => 'serverTips',
        'serviceToken' => 'serviceToken',
        'targetChannel' => 'targetChannel',
        'visitorToken' => 'visitorToken',
    ];

    public function validate() {}

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
