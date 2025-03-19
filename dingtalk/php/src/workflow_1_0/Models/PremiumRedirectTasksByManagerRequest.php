<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumRedirectTasksByManagerRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example staffId-B
     *
     * @var string
     */
    public $handoverUserId;

    /**
     * @description This parameter is required.
     *
     * @example manager-12
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $taskIds;

    /**
     * @description This parameter is required.
     *
     * @example staffId-A
     *
     * @var string
     */
    public $transfereeUserId;
    protected $_name = [
        'handoverUserId' => 'handoverUserId',
        'managerUserId' => 'managerUserId',
        'taskIds' => 'taskIds',
        'transfereeUserId' => 'transfereeUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->handoverUserId) {
            $res['handoverUserId'] = $this->handoverUserId;
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->taskIds) {
            $res['taskIds'] = $this->taskIds;
        }
        if (null !== $this->transfereeUserId) {
            $res['transfereeUserId'] = $this->transfereeUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumRedirectTasksByManagerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['handoverUserId'])) {
            $model->handoverUserId = $map['handoverUserId'];
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['taskIds'])) {
            if (!empty($map['taskIds'])) {
                $model->taskIds = $map['taskIds'];
            }
        }
        if (isset($map['transfereeUserId'])) {
            $model->transfereeUserId = $map['transfereeUserId'];
        }

        return $model;
    }
}
