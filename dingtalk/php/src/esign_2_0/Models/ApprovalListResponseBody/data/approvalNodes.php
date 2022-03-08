<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListResponseBody\data;

use AlibabaCloud\Tea\Model;

class approvalNodes extends Model
{
    /**
     * @var string
     */
    public $approvalTime;

    /**
     * @var string
     */
    public $approverName;

    /**
     * @var float
     */
    public $startTime;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'approvalTime' => 'approvalTime',
        'approverName' => 'approverName',
        'startTime'    => 'startTime',
        'status'       => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvalTime) {
            $res['approvalTime'] = $this->approvalTime;
        }
        if (null !== $this->approverName) {
            $res['approverName'] = $this->approverName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return approvalNodes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvalTime'])) {
            $model->approvalTime = $map['approvalTime'];
        }
        if (isset($map['approverName'])) {
            $model->approverName = $map['approverName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
