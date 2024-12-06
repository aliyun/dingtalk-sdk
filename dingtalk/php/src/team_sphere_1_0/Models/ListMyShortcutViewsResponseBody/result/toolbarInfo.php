<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\toolbarInfo\groupTypes;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\toolbarInfo\orderTypes;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\toolbarInfo\showTypes;
use AlibabaCloud\Tea\Model;

class toolbarInfo extends Model
{
    /**
     * @var groupTypes[]
     */
    public $groupTypes;

    /**
     * @var orderTypes[]
     */
    public $orderTypes;

    /**
     * @var showTypes[]
     */
    public $showTypes;
    protected $_name = [
        'groupTypes' => 'groupTypes',
        'orderTypes' => 'orderTypes',
        'showTypes'  => 'showTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupTypes) {
            $res['groupTypes'] = [];
            if (null !== $this->groupTypes && \is_array($this->groupTypes)) {
                $n = 0;
                foreach ($this->groupTypes as $item) {
                    $res['groupTypes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->orderTypes) {
            $res['orderTypes'] = [];
            if (null !== $this->orderTypes && \is_array($this->orderTypes)) {
                $n = 0;
                foreach ($this->orderTypes as $item) {
                    $res['orderTypes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->showTypes) {
            $res['showTypes'] = [];
            if (null !== $this->showTypes && \is_array($this->showTypes)) {
                $n = 0;
                foreach ($this->showTypes as $item) {
                    $res['showTypes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return toolbarInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupTypes'])) {
            if (!empty($map['groupTypes'])) {
                $model->groupTypes = [];
                $n                 = 0;
                foreach ($map['groupTypes'] as $item) {
                    $model->groupTypes[$n++] = null !== $item ? groupTypes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['orderTypes'])) {
            if (!empty($map['orderTypes'])) {
                $model->orderTypes = [];
                $n                 = 0;
                foreach ($map['orderTypes'] as $item) {
                    $model->orderTypes[$n++] = null !== $item ? orderTypes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['showTypes'])) {
            if (!empty($map['showTypes'])) {
                $model->showTypes = [];
                $n                = 0;
                foreach ($map['showTypes'] as $item) {
                    $model->showTypes[$n++] = null !== $item ? showTypes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
