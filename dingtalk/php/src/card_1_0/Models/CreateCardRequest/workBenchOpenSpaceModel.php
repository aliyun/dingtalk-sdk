<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;

use AlibabaCloud\Tea\Model;

class workBenchOpenSpaceModel extends Model
{
    /**
     * @description 工作台无其他场域属性，通过增加spaeType使卡片支持工作台场域;工作台对应spaceType为: WORK_BENCH
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
     * @return workBenchOpenSpaceModel
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
