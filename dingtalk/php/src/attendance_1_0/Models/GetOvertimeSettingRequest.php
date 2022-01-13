<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOvertimeSettingRequest extends Model
{
    /**
     * @var int[]
     */
    public $overtimeSettingIds;
    protected $_name = [
        'overtimeSettingIds' => 'overtimeSettingIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->overtimeSettingIds) {
            $res['overtimeSettingIds'] = $this->overtimeSettingIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOvertimeSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['overtimeSettingIds'])) {
            if (!empty($map['overtimeSettingIds'])) {
                $model->overtimeSettingIds = $map['overtimeSettingIds'];
            }
        }

        return $model;
    }
}
