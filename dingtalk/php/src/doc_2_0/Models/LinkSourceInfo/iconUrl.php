<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\LinkSourceInfo;

use AlibabaCloud\Tea\Model;

class iconUrl extends Model
{
    /**
     * @description 默认的目录树图标。
     *
     * @var string
     */
    public $line;

    /**
     * @description 被选中时的加深图标。
     *
     * @var string
     */
    public $small;
    protected $_name = [
        'line'  => 'line',
        'small' => 'small',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->line) {
            $res['line'] = $this->line;
        }
        if (null !== $this->small) {
            $res['small'] = $this->small;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return iconUrl
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['line'])) {
            $model->line = $map['line'];
        }
        if (isset($map['small'])) {
            $model->small = $map['small'];
        }

        return $model;
    }
}
