<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoResponseBody;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @description 标签id
     *
     * @var int
     */
    public $id;

    /**
     * @description 标签名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 标签名称 tagCode
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'id'      => 'id',
        'name'    => 'name',
        'tagCode' => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
