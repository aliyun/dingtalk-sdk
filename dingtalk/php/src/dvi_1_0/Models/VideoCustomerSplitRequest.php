<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest\customer;
use AlibabaCloud\Tea\Model;

class VideoCustomerSplitRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var customer
     */
    public $customer;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $segmentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'customer' => 'customer',
        'segmentId' => 'segmentId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customer) {
            $res['customer'] = null !== $this->customer ? $this->customer->toMap() : null;
        }
        if (null !== $this->segmentId) {
            $res['segmentId'] = $this->segmentId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VideoCustomerSplitRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customer'])) {
            $model->customer = customer::fromMap($map['customer']);
        }
        if (isset($map['segmentId'])) {
            $model->segmentId = $map['segmentId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
