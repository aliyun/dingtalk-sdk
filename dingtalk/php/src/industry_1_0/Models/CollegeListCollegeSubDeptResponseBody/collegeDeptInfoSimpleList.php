<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListCollegeSubDeptResponseBody;

use AlibabaCloud\Tea\Model;

class collegeDeptInfoSimpleList extends Model
{
    /**
     * @example 01123
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 三年二班
     *
     * @var string
     */
    public $deptName;

    /**
     * @example class
     *
     * @var string
     */
    public $deptType;
    protected $_name = [
        'deptId' => 'deptId',
        'deptName' => 'deptName',
        'deptType' => 'deptType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return collegeDeptInfoSimpleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }

        return $model;
    }
}
