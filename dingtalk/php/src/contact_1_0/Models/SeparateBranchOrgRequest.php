<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SeparateBranchOrgRequest extends Model
{
    /**
     * @var int
     */
    public $attachDeptId;
    protected $_name = [
        'attachDeptId' => 'attachDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachDeptId) {
            $res['attachDeptId'] = $this->attachDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SeparateBranchOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachDeptId'])) {
            $model->attachDeptId = $map['attachDeptId'];
        }

        return $model;
    }
}
