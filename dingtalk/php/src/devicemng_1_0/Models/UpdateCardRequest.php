<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCardRequest extends Model
{
    /**
     * @description 卡片实例唯一标识
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 卡片变量赋值，json结构
     *
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
