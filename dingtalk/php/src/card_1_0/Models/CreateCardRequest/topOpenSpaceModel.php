<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;

use AlibabaCloud\Tea\Model;

class topOpenSpaceModel extends Model
{
    /**
     * @description 吊顶无其他场域属性，通过增加spaeType使卡片支持吊顶场域；吊顶对应spaceType为: ONE_BOX
     *
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
