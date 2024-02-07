<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardBatchQueryCardsRequest extends Model
{
    /**
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @var int[]
     */
    public $cardIds;

    /**
     * @example YUFANAI
     *
     * @var string
     */
    public $sourceType;

    /**
     * @example 1678445875001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizCode' => 'cardBizCode',
        'cardIds'     => 'cardIds',
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
        if (null !== $this->cardIds) {
            $res['cardIds'] = $this->cardIds;
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
     * @return CardBatchQueryCardsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardIds'])) {
            if (!empty($map['cardIds'])) {
                $model->cardIds = $map['cardIds'];
            }
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
