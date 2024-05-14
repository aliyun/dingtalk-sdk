<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UpdateCardRequest\tips;
use AlibabaCloud\Tea\Model;

class UpdateCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example biz-xxxxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example {"var1":"xxx","var2":"xxx"}
     *
     * @var string
     */
    public $cardData;

    /**
     * @var tips
     */
    public $tips;
    protected $_name = [
        'bizId'    => 'bizId',
        'cardData' => 'cardData',
        'tips'     => 'tips',
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
        if (null !== $this->tips) {
            $res['tips'] = null !== $this->tips ? $this->tips->toMap() : null;
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
        if (isset($map['tips'])) {
            $model->tips = tips::fromMap($map['tips']);
        }

        return $model;
    }
}
