<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardGetCardRequest extends Model
{
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
    protected $_name = [
        'cardId'     => 'cardId',
        'sourceType' => 'sourceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardGetCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }

        return $model;
    }
}
