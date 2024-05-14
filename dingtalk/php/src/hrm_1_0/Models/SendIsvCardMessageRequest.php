<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendIsvCardMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $agentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $messageType;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $receiverUserIds;

    /**
     * @description This parameter is required.
     *
     * @example 16690147049882572
     *
     * @var string
     */
    public $sceneType;

    /**
     * @description This parameter is required.
     *
     * @example 同意转正
     *
     * @var string
     */
    public $scope;

    /**
     * @description This parameter is required.
     *
     * @example 16690147049882572
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @var string[]
     */
    public $valueMap;
    protected $_name = [
        'agentId'         => 'agentId',
        'bizId'           => 'bizId',
        'messageType'     => 'messageType',
        'receiverUserIds' => 'receiverUserIds',
        'sceneType'       => 'sceneType',
        'scope'           => 'scope',
        'senderUserId'    => 'senderUserId',
        'valueMap'        => 'valueMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->receiverUserIds) {
            $res['receiverUserIds'] = $this->receiverUserIds;
        }
        if (null !== $this->sceneType) {
            $res['sceneType'] = $this->sceneType;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }
        if (null !== $this->valueMap) {
            $res['valueMap'] = $this->valueMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendIsvCardMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['receiverUserIds'])) {
            if (!empty($map['receiverUserIds'])) {
                $model->receiverUserIds = $map['receiverUserIds'];
            }
        }
        if (isset($map['sceneType'])) {
            $model->sceneType = $map['sceneType'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }
        if (isset($map['valueMap'])) {
            $model->valueMap = $map['valueMap'];
        }

        return $model;
    }
}
