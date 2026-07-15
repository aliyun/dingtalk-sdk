<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardUpdateCardRequest\data;
use AlibabaCloud\Tea\Model;

class CardUpdateCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example industry_centry
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $cardId;

    /**
     * @var data
     */
    public $data;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $identifier;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $shouldSendUpdateMsg;

    /**
     * @description This parameter is required.
     *
     * @example QUPEIYIN
     *
     * @var string
     */
    public $sourceType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizCode' => 'cardBizCode',
        'cardId' => 'cardId',
        'data' => 'data',
        'identifier' => 'identifier',
        'shouldSendUpdateMsg' => 'shouldSendUpdateMsg',
        'sourceType' => 'sourceType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->shouldSendUpdateMsg) {
            $res['shouldSendUpdateMsg'] = $this->shouldSendUpdateMsg;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardUpdateCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['shouldSendUpdateMsg'])) {
            $model->shouldSendUpdateMsg = $map['shouldSendUpdateMsg'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
