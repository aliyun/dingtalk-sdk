<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\behaviorLinkage\targets;
use AlibabaCloud\Tea\Model;

class behaviorLinkage extends Model
{
    /**
     * @description 关联控件列表。
     *
     * @var targets[]
     */
    public $targets;

    /**
     * @description 控件值。
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'targets' => 'targets',
        'value'   => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targets) {
            $res['targets'] = [];
            if (null !== $this->targets && \is_array($this->targets)) {
                $n = 0;
                foreach ($this->targets as $item) {
                    $res['targets'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return behaviorLinkage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targets'])) {
            if (!empty($map['targets'])) {
                $model->targets = [];
                $n              = 0;
                foreach ($map['targets'] as $item) {
                    $model->targets[$n++] = null !== $item ? targets::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
