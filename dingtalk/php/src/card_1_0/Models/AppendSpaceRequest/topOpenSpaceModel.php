<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest;

use AlibabaCloud\Tea\Model;

class topOpenSpaceModel extends Model
{
    /**
     * @description 【必填】场域类型
     *
     * 吊顶无其他场域属性，通过设置spaeType为ONE_BOX使卡片支持吊顶场域
     * @var string
     */
    public $spaceType;
    protected $_name = [
        'spaceType' => 'spaceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topOpenSpaceModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }

        return $model;
    }
}
