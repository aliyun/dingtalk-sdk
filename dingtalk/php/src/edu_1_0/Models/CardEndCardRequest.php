<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardEndCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @example 856237470
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description This parameter is required.
     *
     * @example 80264668258
     *
     * @var int
     */
    public $cardId;

    /**
     * @description This parameter is required.
     *
     * @example YUFANAI
     *
     * @var string
     */
    public $sourceType;

    /**
     * @description This parameter is required.
     *
     * @example manager7741
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizCode' => 'cardBizCode',
        'cardBizId'   => 'cardBizId',
        'cardId'      => 'cardId',
        'sourceType'  => 'sourceType',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
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
     * @return CardEndCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
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
