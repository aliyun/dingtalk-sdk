<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceVO;

use AlibabaCloud\Tea\Model;

class iconVO extends Model
{
    /**
     * @description 图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 图标类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'icon' => 'icon',
        'type' => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return iconVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
