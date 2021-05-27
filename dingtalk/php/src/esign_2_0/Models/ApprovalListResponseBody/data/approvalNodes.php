<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListResponseBody\data;

use AlibabaCloud\Tea\Model;

class approvalNodes extends Model
{
    /**
     * @var string
     */
    public $approverName;

    /**
     * @var string
     */
    public $status;

    /**
     * @var float
     */
    public $startTime;

    /**
     * @var string
     */
    public $approvalTime;
    protected $_name = [
        'approverName' => 'approverName',
        'status'       => 'status',
        'startTime'    => 'startTime',
        'approvalTime' => 'approvalTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approverName) {
            $res['approverName'] = $this->approverName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->approvalTime) {
            $res['approvalTime'] = $this->approvalTime;
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
        if (isset($map['approverName'])) {
            $model->approverName = $map['approverName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['approvalTime'])) {
            $model->approvalTime = $map['approvalTime'];
        }

        return $model;
    }
}
