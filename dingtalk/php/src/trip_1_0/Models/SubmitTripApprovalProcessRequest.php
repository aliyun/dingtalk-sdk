<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SubmitTripApprovalProcessRequest\itineraries;
use AlibabaCloud\Tea\Model;

class SubmitTripApprovalProcessRequest extends Model
{
    /**
     * @var itineraries[]
     */
    public $itineraries;

    /**
     * @example PROC_XXXX
     *
     * @var string
     */
    public $processCode;

    /**
     * @example 拜访客户
     *
     * @var string
     */
    public $reason;

    /**
     * @example 5046195764756652
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'itineraries' => 'itineraries',
        'processCode' => 'processCode',
        'reason' => 'reason',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itineraries) {
            $res['itineraries'] = [];
            if (null !== $this->itineraries && \is_array($this->itineraries)) {
                $n = 0;
                foreach ($this->itineraries as $item) {
                    $res['itineraries'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitTripApprovalProcessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itineraries'])) {
            if (!empty($map['itineraries'])) {
                $model->itineraries = [];
                $n = 0;
                foreach ($map['itineraries'] as $item) {
                    $model->itineraries[$n++] = null !== $item ? itineraries::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
