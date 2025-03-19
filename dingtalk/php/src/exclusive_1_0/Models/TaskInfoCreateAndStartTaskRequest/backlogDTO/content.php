<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\backlogDTO;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var bool
     */
    public $isOnlyShowExecutor;

    /**
     * @var int
     */
    public $priority;
    protected $_name = [
        'isOnlyShowExecutor' => 'isOnlyShowExecutor',
        'priority' => 'priority',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isOnlyShowExecutor) {
            $res['isOnlyShowExecutor'] = $this->isOnlyShowExecutor;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isOnlyShowExecutor'])) {
            $model->isOnlyShowExecutor = $map['isOnlyShowExecutor'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }

        return $model;
    }
}
