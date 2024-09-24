<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCollegeUserEmpTypeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example college_student
     *
     * @var string
     */
    public $empType;

    /**
     * @description This parameter is required.
     *
     * @example zhangsan666
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'empType' => 'empType',
        'userid'  => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->empType) {
            $res['empType'] = $this->empType;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCollegeUserEmpTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['empType'])) {
            $model->empType = $map['empType'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
