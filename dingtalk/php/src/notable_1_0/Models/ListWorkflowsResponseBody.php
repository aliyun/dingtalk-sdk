<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListWorkflowsResponseBody\workflows;
use AlibabaCloud\Tea\Model;

class ListWorkflowsResponseBody extends Model
{
    /**
     * @var int
     */
    public $total;

    /**
     * @var workflows[]
     */
    public $workflows;
    protected $_name = [
        'total' => 'total',
        'workflows' => 'workflows',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->workflows) {
            $res['workflows'] = [];
            if (null !== $this->workflows && \is_array($this->workflows)) {
                $n = 0;
                foreach ($this->workflows as $item) {
                    $res['workflows'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListWorkflowsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['workflows'])) {
            if (!empty($map['workflows'])) {
                $model->workflows = [];
                $n = 0;
                foreach ($map['workflows'] as $item) {
                    $model->workflows[$n++] = null !== $item ? workflows::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
