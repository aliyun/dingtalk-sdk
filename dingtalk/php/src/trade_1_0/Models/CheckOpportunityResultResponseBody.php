<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckOpportunityResultResponseBody extends Model
{
    /**
     * @description success
     *
     * @var bool
     */
    public $bizSuccess;
    protected $_name = [
        'bizSuccess' => 'bizSuccess',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizSuccess) {
            $res['bizSuccess'] = $this->bizSuccess;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckOpportunityResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizSuccess'])) {
            $model->bizSuccess = $map['bizSuccess'];
        }

        return $model;
    }
}
