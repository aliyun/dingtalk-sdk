<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCardRequest extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $cardData;
    protected $_name = [
        'bizId'    => 'bizId',
        'cardData' => 'cardData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }

        return $model;
    }
}
