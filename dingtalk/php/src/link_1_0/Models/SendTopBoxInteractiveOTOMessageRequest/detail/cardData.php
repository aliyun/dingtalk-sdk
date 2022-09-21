<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageRequest\detail;

use AlibabaCloud\Tea\Model;

class cardData extends Model
{
    /**
     * @description 富媒体卡片数据
     *
     * @var mixed[]
     */
    public $cardMediaIdParamMap;

    /**
     * @description 普通文本卡片数据
     *
     * @var mixed[]
     */
    public $cardParamMap;
    protected $_name = [
        'cardMediaIdParamMap' => 'cardMediaIdParamMap',
        'cardParamMap'        => 'cardParamMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardMediaIdParamMap) {
            $res['cardMediaIdParamMap'] = $this->cardMediaIdParamMap;
        }
        if (null !== $this->cardParamMap) {
            $res['cardParamMap'] = $this->cardParamMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardMediaIdParamMap'])) {
            $model->cardMediaIdParamMap = $map['cardMediaIdParamMap'];
        }
        if (isset($map['cardParamMap'])) {
            $model->cardParamMap = $map['cardParamMap'];
        }

        return $model;
    }
}
