<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceRequest;

use AlibabaCloud\Tea\Model;

class cardData extends Model
{
    /**
     * @description 卡片模板内容替换参数-多媒体类型
     *
     * @var string[]
     */
    public $cardMediaIdParamMap;

    /**
     * @description 卡片模板内容替换参数-普通文本类型
     *
     * @var string[]
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
