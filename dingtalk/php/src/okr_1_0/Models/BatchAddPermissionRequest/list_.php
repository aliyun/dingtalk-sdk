<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionRequest;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionRequest\list_\member;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var member
     */
    public $member;

    /**
     * @var int
     */
    public $policyType;
    protected $_name = [
        'member'     => 'member',
        'policyType' => 'policyType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->member) {
            $res['member'] = null !== $this->member ? $this->member->toMap() : null;
        }
        if (null !== $this->policyType) {
            $res['policyType'] = $this->policyType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['member'])) {
            $model->member = member::fromMap($map['member']);
        }
        if (isset($map['policyType'])) {
            $model->policyType = $map['policyType'];
        }

        return $model;
    }
}
