<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateUserTaskStatusRequest\userTaskStatuses;
use AlibabaCloud\Tea\Model;

class AppUpdateUserTaskStatusRequest extends Model
{
    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var userTaskStatuses[]
     */
    public $userTaskStatuses;
    protected $_name = [
        'operatorId' => 'operatorId',
        'userTaskStatuses' => 'userTaskStatuses',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->userTaskStatuses) {
            $res['userTaskStatuses'] = [];
            if (null !== $this->userTaskStatuses && \is_array($this->userTaskStatuses)) {
                $n = 0;
                foreach ($this->userTaskStatuses as $item) {
                    $res['userTaskStatuses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppUpdateUserTaskStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['userTaskStatuses'])) {
            if (!empty($map['userTaskStatuses'])) {
                $model->userTaskStatuses = [];
                $n = 0;
                foreach ($map['userTaskStatuses'] as $item) {
                    $model->userTaskStatuses[$n++] = null !== $item ? userTaskStatuses::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
