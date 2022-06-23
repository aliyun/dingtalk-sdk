<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 颜色
     *
     * @var string
     */
    public $color;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 优先级值
     *
     * @var string
     */
    public $priority;

    /**
     * @description id
     *
     * @var string
     */
    public $priorityId;
    protected $_name = [
        'color'      => 'color',
        'name'       => 'name',
        'priority'   => 'priority',
        'priorityId' => 'priorityId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->color) {
            $res['color'] = $this->color;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->priorityId) {
            $res['priorityId'] = $this->priorityId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['color'])) {
            $model->color = $map['color'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['priorityId'])) {
            $model->priorityId = $map['priorityId'];
        }

        return $model;
    }
}
