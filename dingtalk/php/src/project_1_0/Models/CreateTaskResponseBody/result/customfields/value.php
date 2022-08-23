<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponseBody\result\customfields;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @description 自定义字段显示值
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'title' => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return value
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
