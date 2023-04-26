<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckInCrowdsByMobileRequest extends Model
{
    /**
     * @example 12520
     *
     * @var int[]
     */
    public $crowdIds;

    /**
     * @example N5u3hS6KJeoUdopXW4GzFg==
     *
     * @var string
     */
    public $mobile;
    protected $_name = [
        'crowdIds' => 'crowdIds',
        'mobile'   => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->crowdIds) {
            $res['crowdIds'] = $this->crowdIds;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckInCrowdsByMobileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['crowdIds'])) {
            $model->crowdIds = $map['crowdIds'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }

        return $model;
    }
}
