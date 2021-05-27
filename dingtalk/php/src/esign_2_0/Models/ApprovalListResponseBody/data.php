<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ApprovalListResponseBody\data\approvalNodes;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $approvalName;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $refuseReason;

    /**
     * @var string
     */
    public $sponsorAccountName;

    /**
     * @var float
     */
    public $startTime;

    /**
     * @var float
     */
    public $endTime;

    /**
     * @var string
     */
    public $sealIdImg;

    /**
     * @var approvalNodes[]
     */
    public $approvalNodes;
    protected $_name = [
        'approvalName'       => 'approvalName',
        'status'             => 'status',
        'refuseReason'       => 'refuseReason',
        'sponsorAccountName' => 'sponsorAccountName',
        'startTime'          => 'startTime',
        'endTime'            => 'endTime',
        'sealIdImg'          => 'sealIdImg',
        'approvalNodes'      => 'approvalNodes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvalName) {
            $res['approvalName'] = $this->approvalName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->refuseReason) {
            $res['refuseReason'] = $this->refuseReason;
        }
        if (null !== $this->sponsorAccountName) {
            $res['sponsorAccountName'] = $this->sponsorAccountName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->sealIdImg) {
            $res['sealIdImg'] = $this->sealIdImg;
        }
        if (null !== $this->approvalNodes) {
            $res['approvalNodes'] = [];
            if (null !== $this->approvalNodes && \is_array($this->approvalNodes)) {
                $n = 0;
                foreach ($this->approvalNodes as $item) {
                    $res['approvalNodes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvalName'])) {
            $model->approvalName = $map['approvalName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['refuseReason'])) {
            $model->refuseReason = $map['refuseReason'];
        }
        if (isset($map['sponsorAccountName'])) {
            $model->sponsorAccountName = $map['sponsorAccountName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['sealIdImg'])) {
            $model->sealIdImg = $map['sealIdImg'];
        }
        if (isset($map['approvalNodes'])) {
            if (!empty($map['approvalNodes'])) {
                $model->approvalNodes = [];
                $n                    = 0;
                foreach ($map['approvalNodes'] as $item) {
                    $model->approvalNodes[$n++] = null !== $item ? approvalNodes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
