<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddLeadsRequest\leads;
use AlibabaCloud\Tea\Model;

class AddLeadsRequest extends Model
{
    /**
     * @description 分配时间戳，如果不传则默认为当前时间。
     *
     * @var int
     */
    public $assignTimestamp;

    /**
     * @description 分配线索的员工userId。
     *
     * @var string
     */
    public $assignUserId;

    /**
     * @description 被分配线索的员工userId。
     *
     * @var string
     */
    public $assignedUserId;

    /**
     * @description 线索。
     *
     * @var leads[]
     */
    public $leads;

    /**
     * @description 任务ID，用于幂等控制。
     *
     * @var string
     */
    public $outTaskId;
    protected $_name = [
        'assignTimestamp' => 'assignTimestamp',
        'assignUserId'    => 'assignUserId',
        'assignedUserId'  => 'assignedUserId',
        'leads'           => 'leads',
        'outTaskId'       => 'outTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assignTimestamp) {
            $res['assignTimestamp'] = $this->assignTimestamp;
        }
        if (null !== $this->assignUserId) {
            $res['assignUserId'] = $this->assignUserId;
        }
        if (null !== $this->assignedUserId) {
            $res['assignedUserId'] = $this->assignedUserId;
        }
        if (null !== $this->leads) {
            $res['leads'] = [];
            if (null !== $this->leads && \is_array($this->leads)) {
                $n = 0;
                foreach ($this->leads as $item) {
                    $res['leads'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outTaskId) {
            $res['outTaskId'] = $this->outTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLeadsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assignTimestamp'])) {
            $model->assignTimestamp = $map['assignTimestamp'];
        }
        if (isset($map['assignUserId'])) {
            $model->assignUserId = $map['assignUserId'];
        }
        if (isset($map['assignedUserId'])) {
            $model->assignedUserId = $map['assignedUserId'];
        }
        if (isset($map['leads'])) {
            if (!empty($map['leads'])) {
                $model->leads = [];
                $n            = 0;
                foreach ($map['leads'] as $item) {
                    $model->leads[$n++] = null !== $item ? leads::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outTaskId'])) {
            $model->outTaskId = $map['outTaskId'];
        }

        return $model;
    }
}
