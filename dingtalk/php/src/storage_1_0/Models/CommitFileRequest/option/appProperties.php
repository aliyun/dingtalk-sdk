<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileRequest\option;

use AlibabaCloud\Tea\Model;

class appProperties extends Model
{
    /**
     * @description 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
     *
     * @var string
     */
    public $name;

    /**
     * @description 属性值
     *
     * @var string
     */
    public $value;

    /**
     * @description 属性可见范围
     * PRIVATE: 该属性仅其归属App可见
     * @var string
     */
    public $visibility;
    protected $_name = [
        'name'       => 'name',
        'value'      => 'value',
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
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appProperties
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
