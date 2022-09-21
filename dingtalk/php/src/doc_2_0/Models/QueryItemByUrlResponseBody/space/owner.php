<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponseBody\space;

use AlibabaCloud\Tea\Model;

class owner extends Model
{
    /**
     * @description 知识库所有者名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 知识库所有者的unionId。
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'name'    => 'name',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return owner
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
