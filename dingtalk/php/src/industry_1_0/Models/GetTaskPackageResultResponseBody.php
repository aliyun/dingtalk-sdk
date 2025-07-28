<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\GetTaskPackageResultResponseBody\tasks;
use AlibabaCloud\Tea\Model;

class GetTaskPackageResultResponseBody extends Model
{
    /**
     * @var string
     */
    public $taskPackageId;

    /**
     * @var tasks[]
     */
    public $tasks;
    protected $_name = [
        'taskPackageId' => 'taskPackageId',
        'tasks' => 'tasks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskPackageId) {
            $res['taskPackageId'] = $this->taskPackageId;
        }
        if (null !== $this->tasks) {
            $res['tasks'] = [];
            if (null !== $this->tasks && \is_array($this->tasks)) {
                $n = 0;
                foreach ($this->tasks as $item) {
                    $res['tasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskPackageResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskPackageId'])) {
            $model->taskPackageId = $map['taskPackageId'];
        }
        if (isset($map['tasks'])) {
            if (!empty($map['tasks'])) {
                $model->tasks = [];
                $n = 0;
                foreach ($map['tasks'] as $item) {
                    $model->tasks[$n++] = null !== $item ? tasks::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
