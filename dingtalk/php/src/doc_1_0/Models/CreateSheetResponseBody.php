<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSheetResponseBody extends Model
{
    /**
     * @description 工作表可见性
     *
     * @var string
     */
    public $visibility;

    /**
     * @description 创建的工作表的名称。当输入参数中的工作表名称在表格中已存在时，可能与输入参数指定的工作表名称不同。
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'visibility' => 'visibility',
        'name'       => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSheetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
