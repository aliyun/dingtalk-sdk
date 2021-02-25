<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateDataValue extends Model
{
    /**
     * @description 卡片模板内容替换参数-普通文本类型
     *
     * @var string[]
     */
    public $cardParamMap;

    /**
     * @description 卡片模板内容替换参数-多媒体类型
     *
     * @var string[]
     */
    public $cardMediaIdParamMap;
    protected $_name = [
        'cardParamMap'        => 'cardParamMap',
        'cardMediaIdParamMap' => 'cardMediaIdParamMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardParamMap) {
            $res['cardParamMap'] = $this->cardParamMap;
        }
        if (null !== $this->cardMediaIdParamMap) {
            $res['cardMediaIdParamMap'] = $this->cardMediaIdParamMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateDataValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardParamMap'])) {
            $model->cardParamMap = $map['cardParamMap'];
        }
        if (isset($map['cardMediaIdParamMap'])) {
            $model->cardMediaIdParamMap = $map['cardMediaIdParamMap'];
        }

        return $model;
    }
}
