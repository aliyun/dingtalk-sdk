<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLeaveTypeRequest extends Model
{
    /**
     * @description 操作者ID
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 空:开放接口定义假期类型;all:所有假期类型
     *
     * @var string
     */
    public $vacationSource;
    protected $_name = [
        'opUserId'       => 'opUserId',
        'vacationSource' => 'vacationSource',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->vacationSource) {
            $res['vacationSource'] = $this->vacationSource;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLeaveTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['vacationSource'])) {
            $model->vacationSource = $map['vacationSource'];
        }

        return $model;
    }
}
