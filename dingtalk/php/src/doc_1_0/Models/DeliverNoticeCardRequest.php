<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeliverNoticeCardRequest extends Model
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
     * @var string[]
     */
    public $btnActionStr;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $detailMobileUrl;

    /**
     * @var string
     */
    public $detailPcUrl;

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
        'btnActionStr' => 'btnActionStr',
        'content' => 'content',
        'detailMobileUrl' => 'detailMobileUrl',
        'detailPcUrl' => 'detailPcUrl',
        'lastMessageI18n' => 'lastMessageI18n',
        'receiverId' => 'receiverId',
        'receiverType' => 'receiverType',
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
        if (null !== $this->btnActionStr) {
            $res['btnActionStr'] = $this->btnActionStr;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->detailMobileUrl) {
            $res['detailMobileUrl'] = $this->detailMobileUrl;
        }
        if (null !== $this->detailPcUrl) {
            $res['detailPcUrl'] = $this->detailPcUrl;
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeliverNoticeCardRequest
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
        if (isset($map['btnActionStr'])) {
            $model->btnActionStr = $map['btnActionStr'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['detailMobileUrl'])) {
            $model->detailMobileUrl = $map['detailMobileUrl'];
        }
        if (isset($map['detailPcUrl'])) {
            $model->detailPcUrl = $map['detailPcUrl'];
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
