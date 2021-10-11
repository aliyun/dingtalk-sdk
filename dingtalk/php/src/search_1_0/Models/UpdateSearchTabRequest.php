<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSearchTabRequest extends Model
{
    /**
     * @description 数据源名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 数据源优先级，数值越小优先级越高
     *
     * @var int
     */
    public $priority;

    /**
     * @description 数据源状态，1表示上线，0表示下线
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'name'     => 'name',
        'priority' => 'priority',
        'status'   => 'status',
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
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSearchTabRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
