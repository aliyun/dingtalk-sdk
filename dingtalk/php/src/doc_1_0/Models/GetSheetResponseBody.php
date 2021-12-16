<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSheetResponseBody extends Model
{
    /**
     * @description 工作表名称
     *
     * @var string[]
     */
    public $name;

    /**
     * @description 工作表可见性
     *
     * @var string[]
     */
    public $visibility;
    protected $_name = [
        'name'       => 'name',
        'visibility' => 'visibility',
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
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSheetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            if (!empty($map['name'])) {
                $model->name = $map['name'];
            }
        }
        if (isset($map['visibility'])) {
            if (!empty($map['visibility'])) {
                $model->visibility = $map['visibility'];
            }
        }

        return $model;
    }
}
