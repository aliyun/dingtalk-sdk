<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\filter;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\filter\conditions\op;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponseBody\result\filter\conditions\values;
use AlibabaCloud\Tea\Model;

class conditions extends Model
{
    /**
     * @var bool
     */
    public $fixed;

    /**
     * @var string
     */
    public $key;

    /**
     * @var op
     */
    public $op;

    /**
     * @var values[]
     */
    public $values;
    protected $_name = [
        'fixed'  => 'fixed',
        'key'    => 'key',
        'op'     => 'op',
        'values' => 'values',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fixed) {
            $res['fixed'] = $this->fixed;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->op) {
            $res['op'] = null !== $this->op ? $this->op->toMap() : null;
        }
        if (null !== $this->values) {
            $res['values'] = [];
            if (null !== $this->values && \is_array($this->values)) {
                $n = 0;
                foreach ($this->values as $item) {
                    $res['values'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conditions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fixed'])) {
            $model->fixed = $map['fixed'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['op'])) {
            $model->op = op::fromMap($map['op']);
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = [];
                $n             = 0;
                foreach ($map['values'] as $item) {
                    $model->values[$n++] = null !== $item ? values::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
