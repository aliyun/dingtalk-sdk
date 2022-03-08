<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListSealApprovalResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\ListSealApprovalResponseBody\data\approvalNodes;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $approvalName;

    /**
     * @var approvalNodes[]
     */
    public $approvalNodes;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $refuseReason;

    /**
     * @var string
     */
    public $sealIdImg;

    /**
     * @var string
     */
    public $sponsorAccountName;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'approvalName'       => 'approvalName',
        'approvalNodes'      => 'approvalNodes',
        'endTime'            => 'endTime',
        'refuseReason'       => 'refuseReason',
        'sealIdImg'          => 'sealIdImg',
        'sponsorAccountName' => 'sponsorAccountName',
        'startTime'          => 'startTime',
        'status'             => 'status',
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
        if (null !== $this->approvalNodes) {
            $res['approvalNodes'] = [];
            if (null !== $this->approvalNodes && \is_array($this->approvalNodes)) {
                $n = 0;
                foreach ($this->approvalNodes as $item) {
                    $res['approvalNodes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->refuseReason) {
            $res['refuseReason'] = $this->refuseReason;
        }
        if (null !== $this->sealIdImg) {
            $res['sealIdImg'] = $this->sealIdImg;
        }
        if (null !== $this->sponsorAccountName) {
            $res['sponsorAccountName'] = $this->sponsorAccountName;
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
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvalName'])) {
            $model->approvalName = $map['approvalName'];
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
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['refuseReason'])) {
            $model->refuseReason = $map['refuseReason'];
        }
        if (isset($map['sealIdImg'])) {
            $model->sealIdImg = $map['sealIdImg'];
        }
        if (isset($map['sponsorAccountName'])) {
            $model->sponsorAccountName = $map['sponsorAccountName'];
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
