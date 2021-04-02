<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApproveCityCarApplyResponseBody extends Model
{
    /**
     * @description 审批结果
     *
     * @var bool
     */
    public $approveResult;
    protected $_name = [
        'approveResult' => 'approveResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveResult) {
            $res['approveResult'] = $this->approveResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApproveCityCarApplyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveResult'])) {
            $model->approveResult = $map['approveResult'];
        }

        return $model;
    }
}
