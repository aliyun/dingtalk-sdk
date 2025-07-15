<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class AddRetentionRecordRequest extends Model
{
    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $stateCode;
    protected $_name = [
        'mobile' => 'mobile',
        'stateCode' => 'stateCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRetentionRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }

        return $model;
    }
}
