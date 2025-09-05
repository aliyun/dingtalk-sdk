<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeliverUnifyCardRequest extends Model
{
    /**
     * @var string[]
     */
    public $atUnionIds;

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
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardData;

    /**
     * @var string
     */
    public $dynamicDataConfig;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $lastMessageI18n;

    /**
     * @description This parameter is required.
     *
     * @example receiver_id
     *
     * @var string
     */
    public $receiverId;

    /**
     * @description This parameter is required.
     *
     * @example user/chat
     *
     * @var string
     */
    public $receiverType;

    /**
     * @var string
     */
    public $userPrivateData;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'atUnionIds' => 'atUnionIds',
        'bizId' => 'bizId',
        'bizType' => 'bizType',
        'cardData' => 'cardData',
        'dynamicDataConfig' => 'dynamicDataConfig',
        'lastMessageI18n' => 'lastMessageI18n',
        'receiverId' => 'receiverId',
        'receiverType' => 'receiverType',
        'userPrivateData' => 'userPrivateData',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUnionIds) {
            $res['atUnionIds'] = $this->atUnionIds;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->dynamicDataConfig) {
            $res['dynamicDataConfig'] = $this->dynamicDataConfig;
        }
        if (null !== $this->lastMessageI18n) {
            $res['lastMessageI18n'] = $this->lastMessageI18n;
        }
        if (null !== $this->receiverId) {
            $res['receiverId'] = $this->receiverId;
        }
        if (null !== $this->receiverType) {
            $res['receiverType'] = $this->receiverType;
        }
        if (null !== $this->userPrivateData) {
            $res['userPrivateData'] = $this->userPrivateData;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeliverUnifyCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUnionIds'])) {
            if (!empty($map['atUnionIds'])) {
                $model->atUnionIds = $map['atUnionIds'];
            }
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['dynamicDataConfig'])) {
            $model->dynamicDataConfig = $map['dynamicDataConfig'];
        }
        if (isset($map['lastMessageI18n'])) {
            $model->lastMessageI18n = $map['lastMessageI18n'];
        }
        if (isset($map['receiverId'])) {
            $model->receiverId = $map['receiverId'];
        }
        if (isset($map['receiverType'])) {
            $model->receiverType = $map['receiverType'];
        }
        if (isset($map['userPrivateData'])) {
            $model->userPrivateData = $map['userPrivateData'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
