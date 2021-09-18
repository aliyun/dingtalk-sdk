<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSeniorSettingsRequest extends Model
{
    /**
     * @var string
     */
    public $seniorStaffId;
    protected $_name = [
        'seniorStaffId' => 'seniorStaffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->seniorStaffId) {
            $res['seniorStaffId'] = $this->seniorStaffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSeniorSettingsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['seniorStaffId'])) {
            $model->seniorStaffId = $map['seniorStaffId'];
        }

        return $model;
    }
}
