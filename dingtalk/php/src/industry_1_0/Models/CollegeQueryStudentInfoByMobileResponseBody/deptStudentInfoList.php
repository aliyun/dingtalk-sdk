<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByMobileResponseBody;

use AlibabaCloud\Tea\Model;

class deptStudentInfoList extends Model
{
    /**
     * @example 01123
     *
     * @var int
     */
    public $deptId;

    /**
     * @example student
     *
     * @var string
     */
    public $memberType;

    /**
     * @example mf1922051
     *
     * @var string
     */
    public $studentNumber;
    protected $_name = [
        'deptId'        => 'deptId',
        'memberType'    => 'memberType',
        'studentNumber' => 'studentNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptStudentInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }

        return $model;
    }
}
