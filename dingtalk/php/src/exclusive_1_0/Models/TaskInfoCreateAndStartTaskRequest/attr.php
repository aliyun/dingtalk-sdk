<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\attr\listTaskDynamicAttr;
use AlibabaCloud\Tea\Model;

class attr extends Model
{
    /**
     * @var listTaskDynamicAttr[]
     */
    public $listTaskDynamicAttr;
    protected $_name = [
        'listTaskDynamicAttr' => 'listTaskDynamicAttr',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->listTaskDynamicAttr) {
            $res['listTaskDynamicAttr'] = [];
            if (null !== $this->listTaskDynamicAttr && \is_array($this->listTaskDynamicAttr)) {
                $n = 0;
                foreach ($this->listTaskDynamicAttr as $item) {
                    $res['listTaskDynamicAttr'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attr
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['listTaskDynamicAttr'])) {
            if (!empty($map['listTaskDynamicAttr'])) {
                $model->listTaskDynamicAttr = [];
                $n                          = 0;
                foreach ($map['listTaskDynamicAttr'] as $item) {
                    $model->listTaskDynamicAttr[$n++] = null !== $item ? listTaskDynamicAttr::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
