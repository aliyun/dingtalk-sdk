<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class CategoriesTemplatesResponseBody extends Model
{
    /**
     * @var MapValue[][]
     */
    public $map;
    protected $_name = [
        'map' => 'map',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->map) {
            $res['map'] = $this->map;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CategoriesTemplatesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['map'])) {
            $model->map = $map['map'];
        }

        return $model;
    }
}
